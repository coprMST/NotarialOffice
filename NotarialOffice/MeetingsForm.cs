using System;
using System.Data;
using System.Windows.Forms;

namespace NotarialOffice
{
    public partial class MeetingsForm : Form
    {
        public MeetingsForm()
        {
            InitializeComponent();

            date1.Text = DateTime.Today.AddDays(1).ToString("dd MMM");
            date2.Text = DateTime.Today.AddDays(2).ToString("dd MMM");
            date3.Text = DateTime.Today.AddDays(3).ToString("dd MMM");
            date4.Text = DateTime.Today.AddDays(4).ToString("dd MMM");

            var data = MainForm.GetData($"select [DateTime] from [dbo].[Meetings] where [DateTime] > sysdatetime()");

            if (data.Rows.Count == 0) return;
            for (var i = 0; i < data.Rows.Count; i++)
            {
                var tempDate = Convert.ToDateTime(data.Rows[i][0]);
                    
                
            }
        }
    }
}