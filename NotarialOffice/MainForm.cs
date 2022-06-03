using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

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
         
            Log.Write("DEBUG", "Программа запущена");
            Application.ApplicationExit += OnApplicationExit;
            
            LastUsedButton = goToInfo;

            if (File.Exists("temp"))
                AutoAuthUser();
            EnableUserPanel();
            
            ColorSwitcher(goToInfo);
            OpenChildForm(new InfoForm());
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            Log.Write("DEBUG", "Программа закрыта");
        }
        
        private void EnableUserPanel()
        {
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
                    goToAdminMeetings.Visible = true;
                }
                else if (CustomerId != null)
                {
                    goToCreateMeeting.Visible = true;
                }
            }
            else
            {
                goToCreateMeeting.Visible = false;
                goToLogIn.Visible = true;
                logInPanel.Visible = false;
                goToEmployees.Visible = false;
                goToCustomers.Visible = false;
                goToAdminMeetings.Visible = false;
            }
        }
        
        private static void AutoAuthUser()
        {
            var login = Empty;
            var password = Empty;
            DataTable data;

            try
            {
                using (var sr = new StreamReader("temp", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        login = line.Split(' ')[0];
                        password = line.Split(' ')[1];
                    }
                }
                
                if (Regex.IsMatch(login, ".+[@].+[.].+"))
                {
                    data = GetData($"exec [dbo].[GetCustomer] null, '{login}', '{password}'");
                    
                    if (data.Rows.Count == 0)
                    {
                        data = GetData($"exec [dbo].[GetEmployee] null, '{login}', '{password}'");
                        if (data.Rows.Count == 0)
                        {
                            File.Delete(@"temp");
                        } 
                        else 
                            SuccessfulAuthorization("employee");
                    }
                    else 
                        SuccessfulAuthorization("customer");
                }
                else if (long.TryParse(login, out _))
                {
                    data = GetData($"exec [dbo].[GetCustomer] '{login}', null, '{password}'");
                    if (data.Rows.Count == 0)
                    {
                        data = GetData($"exec [dbo].[GetEmployee] '{login}', null, '{password}'");
                        if (data.Rows.Count == 0)
                        {
                            File.Delete(@"temp");
                        }
                        else
                            SuccessfulAuthorization("employee");
                    }
                    else
                        SuccessfulAuthorization("customer");
                }
            }
            catch
            {
                // ignored
            }

            void SuccessfulAuthorization(string user)
            {
                AccountId = data.Rows[0][0].ToString();
                UserName = data.Rows[0][2] + " " + data.Rows[0][3].ToString().Substring(0, 1) + ".";
                if (data.Rows[0][4] != DBNull.Value)
                    UserName += data.Rows[0][4].ToString().Substring(0, 1) + ".";
                
                switch (user)
                {
                    case "customer": CustomerId = data.Rows[0][1].ToString(); break;
                    case "employee": EmployeeId = data.Rows[0][1].ToString(); break;
                }
                
                Log.Write("INFO", $"Автоматический вход был осуществлен пользователем {UserName}; идентификатор аккаунта: {AccountId}");
            }
        }
        
        public static void CreateUserFile(string login, string password)
        {
            const string path = "temp";
            var fs = File.Open(path, File.Exists(path) ? FileMode.Truncate : FileMode.OpenOrCreate);
            File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.Compressed);
            using (var sw = new StreamWriter(fs, Encoding.Default))
                sw.WriteLine("{0} {1}", login, password);
            fs.Close();
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
        }

        private void ColorSwitcher(object sender)
        {
            var btSender = (Button)sender;

            if (Size != new Size(1000, 700))
                Size = new Size(1000, 700);
            
            if (btSender.Name == "goToSettings")
            {
                myNameLabel.Visible = false;
                label4.Visible = false;
                Size = new Size(650, 700);
            }

            if (LastUsedButton.Name == "goToSettings")
            {
                myNameLabel.Visible = true;
                label4.Visible = true;
            }
            
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
            Hide();
            authorization.Show();

            AccountId = null;
            EmployeeId = null;
            CustomerId = null;
            UserName = null;
            
            Log.Write("INFO", "Осуществлен переход на окно авторизации");
        }

        private void goToLogOut_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            goToLogIn.Visible = true;

            AccountId = null;
            EmployeeId = null;
            CustomerId = null;
            UserName = null;
            File.Delete(@"temp");
            EnableUserPanel();

            if (LastUsedButton == goToInfo || LastUsedButton == goToDocuments) return;
            
            ColorSwitcher(goToInfo);
            OpenChildForm(new InfoForm());

            Log.Write("INFO", $"Выход из учетной записи был осуществлен пользователем {UserName}; идентификатор аккаунта: {AccountId}");
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
                
                // Если соединение не установлено, то завершаем работу
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
            
            // Возвращаем данные
            return dataTable;
        }

        private void goToInfo_Click(object sender, EventArgs e)
        {
            ColorSwitcher(goToInfo);
            OpenChildForm(new InfoForm());
            
            Log.Write("INFO", "Осуществлен переход на информационную страницу");
        }

        private void goToDocuments_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new Documents());
            
            Log.Write("INFO", "Осуществлен переход на страницу документов");
        }

        private void goToSettings_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new SettingsForm());
            
            Log.Write("INFO", "Осуществлен переход на страницу настроек приложения");
        }

        private void goToMyDocuments_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new MeetingsForm());
            
            Log.Write("INFO", "Осуществлен переход на страницу моих документов");
        }

        private void goToMyMeetings_Click(object sender, EventArgs e)
        {
            Log.Write("INFO", "Осуществлен переход на страницу встреч клиента");
        }

        private void goToAdminMeetings_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new MeetingDates());
            
            Log.Write("INFO", "Осуществлен переход на страницу встреч для администратора");
        }

        private void goToCustomers_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new CustomersForm());
            
            Log.Write("INFO", "Осуществлен переход на страницу списка клиентов");
        }

        private void goToEmployees_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new EmployeesForm());
            
            Log.Write("INFO", "Осуществлен переход на страницу списка сотрудников");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new EmployeesForm());
            
            Log.Write("INFO", "Осуществлен переход на страницу профиля");
        }
    }
}

public static class Log
{
    private static readonly object Sync = new object();
    public static void Write(string loggingLevel, string msg)
    {
        try
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            var filename = Path.Combine(path, $"{DateTime.Now:dd.MM.yyy}.log");
            var fullText = $"[{DateTime.Now:HH:mm:ss.fff}] [{loggingLevel}] {msg}\r";
            lock (Sync)
            {
                File.AppendAllText(filename, fullText, Encoding.GetEncoding("Windows-1251"));
            }
            File.SetAttributes(filename, FileAttributes.Compressed);
        }
        catch
        {
            // ignored
        }
    }
}