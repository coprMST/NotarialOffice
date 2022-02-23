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

            //OpenMainPage();
        }

        private void ColorSwitcher(object sender)
        {
            Button btSender = (Button)sender;

            if (Size != new Size(1200, 800))
                Size = new Size(1200, 800);
            lastUsedButton.BackColor = Color.FromArgb(140, 179, 247);
            lastUsedButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lastUsedButton.Enabled = true;

            btSender.BackColor = Color.FromArgb(211, 227, 252);
            btSender.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btSender.Enabled = false;
            if (btSender.Name == "goToSettings")
                Size = new Size(600, 800);
            if (btSender.Name == "goToHotelRooms")
                Size = new Size(1393, 800);

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
            ControlPaint.DrawBorder(e.Graphics, formPanel.ClientRectangle,
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
            string connectionString = $@"Data Source={DataSource};Initial Catalog={InitialCatalog};Integrated Security=True";

            DataTable dataTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                // Открываем асинхронное соединение с базой данных
                Task connectionTask = connection.OpenAsync();
                Task.WaitAll(connectionTask);

                // Если соединение произвелось успешно
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
    }
}
