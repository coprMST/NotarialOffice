using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;

namespace NotarialOffice
{
    public partial class MainForm : Form
    {
        public static string AccountID { get; set; }
        public static string EmployeeID { get; set; }
        public static string CustomerID { get; set; }
        public static string UserName { get; set; }
        Button lastUsedButton { get; set; }

        private int x = 0;
        private int y = 0;
        public static string DataSource = "localhost";
        public static string InitialCatalog = "NotarialOffice";

        public MainForm()
        {
            InitializeComponent();
            lastUsedButton = goToInfo;

            if (AccountID != null)
            {
                goToLogIn.Visible = false;
                logInPanel.Visible = true;
                myNameLabel.Text = UserName;

                if (EmployeeID != null)
                {
                    goToEmployees.Visible = true;
                    goToDocuments.Visible = false;
                    goToCustomers.Visible = true;
                    goToEmployees.Visible = true;
                }
                else if (CustomerID != null)
                {
                    goToMyDocuments.Visible = true;
                }
            }
            else
            {
                goToLogIn.Visible = true;
                logInPanel.Visible = false;
            }

            ColorSwitcher(goToInfo);
            OpenChildForm(new InfoForm());
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            workPanel.Controls.Add(childForm);
            workPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            //string path = Path.Combine(Registry.LocalMachine.Name, @"SOFTWARE\Microsoft\SQMClient");
            //Guid MachineId = new Guid((string)Registry.GetValue(path, "MachineId", null));
            MessageBox.Show(Environment.MachineName.ToString());
        }

        private void ColorSwitcher(object sender)
        {
            Button btSender = (Button)sender;

            if (Size != new Size(1000, 700))
                Size = new Size(1000, 700);
            if (btSender.Name == "goToSettings")
                Size = new Size(650, 700);

            if (btSender.Name == "goToInfo")
                mainLogo.Enabled = false;
            else
                mainLogo.Enabled = true;

            lastUsedButton.BackColor = Color.FromArgb(214, 184, 134);
            lastUsedButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lastUsedButton.Enabled = true;

            btSender.BackColor = Color.FromArgb(216, 200, 172);
            btSender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btSender.Enabled = false;

            lastUsedButton = btSender;
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, menuPanel.ClientRectangle,
                           Color.FromArgb(90, 54, 32), 2, ButtonBorderStyle.Solid, 
                           Color.FromArgb(90, 54, 32), 0, ButtonBorderStyle.Solid, 
                           Color.FromArgb(90, 54, 32), 0, ButtonBorderStyle.Solid, 
                           Color.FromArgb(90, 54, 32), 2, ButtonBorderStyle.Solid);
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, workPanel.ClientRectangle,
                           Color.FromArgb(90, 54, 32), 0, ButtonBorderStyle.Solid, 
                           Color.FromArgb(90, 54, 32), 0, ButtonBorderStyle.Solid, 
                           Color.FromArgb(90, 54, 32), 2, ButtonBorderStyle.Solid, 
                           Color.FromArgb(90, 54, 32), 2, ButtonBorderStyle.Solid);
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void goToExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMaximizedApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void goToLogIn_Click(object sender, EventArgs e)
        {
            Form authorization = new AuthorizationForm();
            this.Hide();
            authorization.Show();

            AccountID = null;
            EmployeeID = null;
            CustomerID = null;
            UserName = null;
        }

        private void goToLogOut_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            goToLogIn.Visible = true;

            AccountID = null;
            EmployeeID = null;
            CustomerID = null;
            UserName = null;
        }

        public static DataTable GetData(string cmd)
        {
            // Строка для подключения к базе данных
            string connectionString = $@"Data Source={DataSource};Initial Catalog={InitialCatalog};Integrated Security=True";
            
            // Хранилище для выходящих данных
            DataTable dataTable = new DataTable();
            
            // Работа с базой данных
            using (var connection = new SqlConnection(connectionString))
            {
                // Открываем асинхронное соединение с базой данных
                Task connectionTask = connection.OpenAsync();
                Task.WaitAll(connectionTask);

                // Если соединение произвелось успешно, то
                // выполняем команду и считываем выходящие данные
                if (!connectionTask.IsFaulted)
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = cmd;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SqlDataReader DataRead = null;
                        DataRead = reader;
                        dataTable.Load(DataRead);
                    }
                }
            }

            return dataTable;
        }

        private void goToInfo_Click(object sender, EventArgs e)
        {
            ColorSwitcher(goToInfo);
            OpenChildForm(new InfoForm());
        }

        private void goToDocuments_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToSettings_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToMyDocuments_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToCustomers_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToEmployees_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }
    }
}
