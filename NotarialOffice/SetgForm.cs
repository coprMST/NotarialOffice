using System;
using System.Windows.Forms;
using System.Drawing;

namespace NotarialOffice
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            SetRoundedShape(goToSavegoToSave, 30);
            SetRoundedShape(goToSetSettings, 30);
            
            dataSource.Text = MainForm.DataSource;
            initialCatalog.Text = MainForm.InitialCatalog;
        }
        
        private static void SetRoundedShape(Control control, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
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

        private void goToSave_Click(object sender, EventArgs e)
        {
            MainForm.DataSource = dataSource.Text.Trim();
            MainForm.InitialCatalog = initialCatalog.Text.Trim();

            MessageBox.Show(@"Настройки были обновлены", @"Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void goToSetSettings_Click(object sender, EventArgs e)
        {
            MainForm.DataSource = "localhost";
            MainForm.InitialCatalog = "NotarialOffice";

            dataSource.Text = MainForm.DataSource;
            initialCatalog.Text = MainForm.InitialCatalog;
            
            MessageBox.Show(@"Настройки были сброшены", @"Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}