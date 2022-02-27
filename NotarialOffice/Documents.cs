using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace NotarialOffice
{
    public partial class Documents : Form
    {
        List<string> comments = new List<string>();

        string sortType = string.Empty;
        string filtrationType = string.Empty;

        public Documents()
        {
            InitializeComponent();

            SetRoundedShape(seacherPanel, 15);
            SetRoundedShape(filtrationPanel, 15);
            SetRoundedShape(sortPanel, 15);
            SetRoundedShape(goToSortDocumentAZ, 45);
            SetRoundedShape(goToSortDocumentZA, 45);
            SetRoundedShape(goToSortDocumentTypeAZ, 45);
            SetRoundedShape(goToSortDocumentTypeZA, 45);

            sortType = "order by DT.DocumentTypeName asc, D.DocumentName asc";

            Update();
        }

        private void linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel snd = (LinkLabel)sender;

            string[] temp = snd.Name.Split(new char[] { '_' });
            int serviceID = Convert.ToInt32(temp[1]);

            MessageBox.Show(comments.ElementAt(serviceID), "Информация");
        }

        void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        void Update()
        {
            workPanel.Enabled = false;

            filtrationType = $"where DT.DocumentTypeName like '%' + '{seacher.Text.Trim()}' + '%' or D.DocumentName like '%' + '{seacher.Text.Trim()}' + '%'";
            switch (filtrationBox.SelectedItem)
            {
                case "По названию документа": filtrationType = $"where D.DocumentName like '%' + '{seacher.Text.Trim()}' + '%'"; break;
                case "По названию типа документа": filtrationType = $"where DT.DocumentTypeName like '%' + '{seacher.Text.Trim()}' + '%'"; break;
                case "none": filtrationType = $"where DT.DocumentTypeName like '%' + '{seacher.Text.Trim()}' + '%' or D.DocumentName like '%' + '{seacher.Text.Trim()}' + '%'"; break;
            }

            string cmd;
            cmd = "select DT.DocumentTypeName, D.DocumentName, D.Tariff, D.[Percent], D.Apiece, D.Comment from [dbo].[Documents] D inner join [dbo].[DocumentTypes] DT on D.DocumentTypeID = DT.DocumentTypeID";
            cmd += " " + filtrationType;
            cmd += " " + sortType;

            try
            {
                comments.Clear();
                servicesPanel.Controls.Clear();
                DataTable data = MainForm.GetData(cmd);

                if (data.Rows.Count != 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        var pn = new Panel();
                        pn.AutoSize = false;
                        pn.BackColor = Color.FromArgb(210, 190, 157);
                        pn.Size = data.Rows[i][5] != DBNull.Value ? new Size(725, 140) : new Size(725, 124);
                        servicesPanel.Controls.Add(pn);
                        SetRoundedShape(pn, 30);

                        var lb2 = new Label();
                        lb2.Dock = DockStyle.Top;
                        lb2.Height = 52;
                        lb2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                        lb2.ForeColor = Color.FromArgb(90, 54, 32);
                        lb2.Padding = new Padding(10, 5, 10, 0);
                        lb2.Text = data.Rows[i][1].ToString();
                        pn.Controls.Add(lb2);

                        var lb = new Label();
                        lb.Text = data.Rows[i][0].ToString();
                        lb.Dock = DockStyle.Top;
                        lb.Height = 38;
                        lb.Width = 720;
                        lb.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                        lb.ForeColor = Color.FromArgb(90, 54, 32);
                        lb.Padding = new Padding(10, 10, 10, 0);
                        pn.Controls.Add(lb);

                        var lb3 = new Label();
                        lb3.Dock = DockStyle.Bottom;
                        lb3.Height = 26;
                        lb3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                        lb3.ForeColor = Color.FromArgb(90, 54, 32);
                        lb3.Padding = new Padding(10, 0, 10, 0);
                        lb3.Text = "Стоимость: " + data.Rows[i][2].ToString().Substring(0, data.Rows[i][2].ToString().Length - 3) + "₽";
                        if (data.Rows[i][3] != DBNull.Value)
                            lb3.Text += " + " + data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length - 1) + "%";
                        if (data.Rows[i][4] != DBNull.Value)
                            lb3.Text += " + " + data.Rows[i][4].ToString().Substring(0, data.Rows[i][4].ToString().Length - 3) + "₽/шт.";
                        pn.Controls.Add(lb3);

                        if (data.Rows[i][5] != DBNull.Value)
                        {
                            var lb4 = new LinkLabel();
                            lb4.Dock = DockStyle.Bottom;
                            lb4.Height = 30;
                            lb4.Name = "link_" + i;
                            lb4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                            lb4.LinkColor = Color.FromArgb(90, 54, 32);
                            lb4.ForeColor = Color.FromArgb(90, 54, 32);
                            lb4.Padding = new Padding(10, 0, 10, 10);
                            lb4.LinkClicked += linkClicked;
                            lb4.Text = "Смотреть подробнее...";
                            pn.Controls.Add(lb4);
                        }

                        if (data.Rows[i][5] == DBNull.Value) comments.Add("Ошибка");
                        else comments.Add(data.Rows[i][5].ToString());

                    }

                    servicesPanel.Visible = true;
                }
            }
            catch { }

            workPanel.Enabled = true;
        }

        private void DataSort(object sender, EventArgs e)
        {
            IconButton btSender = (IconButton)sender;

            switch (btSender.Name)
            {
                case "goToSortDocumentTypeAZ": sortType = "order by DT.DocumentTypeName asc, D.DocumentName asc"; break;
                case "goToSortDocumentTypeZA": sortType = "order by DT.DocumentTypeName desc, D.DocumentName asc"; break;
                case "goToSortDocumentAZ": sortType = "order by D.DocumentName asc, DT.DocumentTypeName asc"; break;
                case "goToSortDocumentZA": sortType = "order by D.DocumentName desc, DT.DocumentTypeName asc"; break;
            }

            Update();
        }

        private void filtrationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
