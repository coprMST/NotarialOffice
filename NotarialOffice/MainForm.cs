using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotarialOffice
{
    public partial class MainForm : Form
    {
        public static string AccountId { get; set; }
        public static string EmployeeId { get; set; }
        public static string CustomerId { get; set; }
        public static string UserName { get; set; }
        private Button LastUsedButton { get; set; }

        private int _x;
        private int _y; 
        public static string DataSource = "localhost"; 
        public static string InitialCatalog = "NotarialOffice";

        public MainForm()
        {
            InitializeComponent();
            LastUsedButton = goToInfo;

            if (AccountId != null)
            {
                goToLogIn.Visible = false;
                logInPanel.Visible = true;
                myNameLabel.Text = UserName;

                if (EmployeeId != null)
                {
                    goToEmployees.Visible = true;
                    goToDocuments.Visible = false;
                    goToCustomers.Visible = true;
                    goToEmployees.Visible = true;
                }
                else if (CustomerId != null)
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
            
            //MessageBox.Show(Environment.MachineName.ToString());
        }

        private void ColorSwitcher(object sender)
        {
            var btSender = (Button)sender;

            if (Size != new Size(1000, 700))
                Size = new Size(1000, 700);
            if (btSender.Name == "goToSettings")
                Size = new Size(650, 700);

            mainLogo.Enabled = btSender.Name != "goToInfo";

            LastUsedButton.BackColor = Color.FromArgb(214, 184, 134);
            LastUsedButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LastUsedButton.Enabled = true;

            btSender.BackColor = Color.FromArgb(216, 200, 172);
            btSender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btSender.Enabled = false;

            LastUsedButton = btSender;
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
                Location = new Point(Location.X + (e.X - _x), Location.Y + (e.Y - _y));
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X; _y = e.Y;
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

            AccountId = null;
            EmployeeId = null;
            CustomerId = null;
            UserName = null;
        }

        private void goToLogOut_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            goToLogIn.Visible = true;

            AccountId = null;
            EmployeeId = null;
            CustomerId = null;
            UserName = null;
        }

        public static DataTable GetData(string cmd)
        {
            // Строка для подключения к базе данных
            var connectionString = $@"Data Source={DataSource};Initial Catalog={InitialCatalog};Integrated Security=True";
            
            // Хранилище для выходящих данных
            var dataTable = new DataTable();
            
            // Работа с базой данных
            using (var connection = new SqlConnection(connectionString))
            {
                // Открываем асинхронное соединение с базой данных
                var connectionTask = connection.OpenAsync();
                Task.WaitAll(connectionTask);
                if (connectionTask.IsFaulted) return dataTable;

                // Если соединение произвелось успешно, то
                // выполняем команду и считываем выходящие данные
                var command = connection.CreateCommand();
                command.CommandText = cmd;

                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
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
            OpenChildForm(new Documents());
        }

        private void goToSettings_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new SettingsForm());
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
