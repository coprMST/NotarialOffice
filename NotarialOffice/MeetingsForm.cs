using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using EasyDox;
using static System.String;

namespace NotarialOffice
{
    public partial class MeetingsForm : Form
    {
        public MeetingsForm()
        {
            InitializeComponent();

            //date1.Text = DateTime.Today.AddDays(1).ToString("dd MMMM");
            //date2.Text = DateTime.Today.AddDays(2).ToString("dd MMMM");
            //date3.Text = DateTime.Today.AddDays(3).ToString("dd MMMM");
            //date4.Text = DateTime.Today.AddDays(4).ToString("dd MMMM");


            
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {
            var date = dateBox.Text;

            if (date.Length != 10)
            {
                timeBox.Enabled = false;
                commentBox.Enabled = false;
                goToCreate.Enabled = false;
                return;
            }
            
            if (!DateTime.TryParse(date, out var tempTime) )
            {
                MessageBox.Show(@"Введите корректно дату встречи", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    
                dateBox.Text = Empty;
                timeBox.Enabled = false;
                commentBox.Enabled = false;
                goToCreate.Enabled = false;
            }
            else if (tempTime <= DateTime.Today)
            {
                MessageBox.Show(@"Введите корректно дату встречи", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                dateBox.Text = Empty;
                timeBox.Enabled = false;
                commentBox.Enabled = false;
                goToCreate.Enabled = false;
            }
            else
            {
                var dt = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
                var data = MainForm.GetData($"select [DateTime] from [dbo].[Meetings] where [DateTime] like '%{dt}%'");
                    
                timeBox.Enabled = true;

                timeBox.SelectedItem = -1;
                timeBox.Items.Clear();
                for (var i = 10; i < 19; i++)
                {
                    timeBox.Items.Add($"{i}:00");
                }
                
                if (data.Rows.Count == 0) return;
                
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var tempDate = Convert.ToDateTime(data.Rows[i][0]).ToString("HH:mm");
                            
                    if (timeBox.Items.Contains(tempDate))
                       timeBox.Items.Remove(tempDate);
                }

                if (timeBox.Items.Count != 0) return;
                
                MessageBox.Show(@"В указанный день свободные дни отсутствуют", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timeBox.Text = Empty;
            }
        }

        private void timeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeBox.SelectedIndex == -1) return;
            
            commentBox.Enabled = true;
            goToCreate.Enabled = true;
        }
        
        private void goToCreate_Click(object sender, EventArgs e)
        {
            try
            { 
                var data = MainForm.GetData($"exec [dbo].[AddNewMeeting] '{MainForm.CustomerId}', '{dateBox.Text + " " + timeBox.SelectedItem}', '{commentBox.Text}'");
            
                MessageBox.Show(@"Вы были успешно записаны на встречу с нотариусом", @"Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var talonId = data.Rows[0][0].ToString();
                var name = data.Rows[0][1] + " " +  data.Rows[0][2];
                if (data.Rows[0][2] != DBNull.Value)
                    name += " " + data.Rows[0][3];
                
                var fieldValues = new Dictionary <string, string> {
                    {"Номер записи", talonId},
                    {"ФИО",  name},
                    {"Дата 1",  dateBox.Text + " " + timeBox.SelectedItem},
                    {"Дата 2", DateTime.Now.ToString("f")},
                };

                var engine = new Engine();
                engine.Merge(Application.StartupPath + @"\\template.docx", fieldValues, Application.StartupPath + $@"\\Talon_{talonId}.docx");
                
                dateBox.Text = "";
                timeBox.Enabled = false;
                timeBox.SelectedIndex = -1;
                commentBox.Enabled = false;
                goToCreate.Enabled = false;
            }
            catch
            {
                MessageBox.Show(@"Не удалось записаться на встречу с нотариусом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}