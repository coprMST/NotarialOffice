using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace NotarialOffice
{
    public partial class AuthorizationForm : Form
    {
        private int _x;
        private int _y;

        public AuthorizationForm()
        {
            InitializeComponent();
            SetRoundedShape(goToLogIn, 45);
            SetRoundedShape(goToClear, 45);
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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, mainPanel.ClientRectangle,
                           Color.FromArgb(90, 54, 32), 2, ButtonBorderStyle.Solid,
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

        private void goToBack_Click(object sender, EventArgs e)
        {
            GoToBackForm();
        }

        private void GoToBackForm()
        {
            Form mainForm = new MainForm();
            Close();
            mainForm.Show();
        }

        private void goToCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form createAccountForm = new CreateAccountForm();
            Close();
            createAccountForm.Show();
        }

        private async void goToCheckPassword_Click(object sender, EventArgs e)
        {
            goToCheckPassword.Enabled = false;
            passwordBox.UseSystemPasswordChar = false;
            await Task.Delay(2000);
            passwordBox.UseSystemPasswordChar = true;
            goToCheckPassword.Enabled = true;
        }

        private void goToLogIn_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text;
            var password = passwordBox.Text;
            DataTable data;
            
            if (IsNullOrEmpty(login))
                MessageBox.Show(@"Для авторизации введите номер телефона или электронную почту", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IsNullOrEmpty(password))
                MessageBox.Show(@"Для авторизации введите пароль", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (Regex.IsMatch(login, ".+[@].+[.].+"))
                    {
                        data = MainForm.GetData($"exec [dbo].[GetCustomer] null, '{login}', '{password}'");
                        
                        if (data.Rows.Count == 0)
                        {
                            data = MainForm.GetData($"exec [dbo].[GetEmployee] null, '{login}', '{password}'");
                            if (data.Rows.Count == 0)
                            {
                                MessageBox.Show(@"Для авторизации были введены неверные данные", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                passwordBox.Text = Empty;
                            } 
                            else 
                                SuccessfulAuthorization("employee");
                        }
                        else 
                            SuccessfulAuthorization("customer");
                    }
                    else if (long.TryParse(login, out _))
                    {
                        data = MainForm.GetData($"exec [dbo].[GetCustomer] '{login}', null, '{password}'");
                        if (data.Rows.Count == 0)
                        {
                            data = MainForm.GetData($"exec [dbo].[GetEmployee] '{login}', null, '{password}'");
                            if (data.Rows.Count == 0)
                            {
                                MessageBox.Show(@"Для авторизации были введены неверные данные", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                passwordBox.Text = Empty;
                            }
                            else
                                SuccessfulAuthorization("employee");
                        }
                        else
                            SuccessfulAuthorization("customer");
                    }
                    else
                        MessageBox.Show(@"Для авторизации были введены некорректные данные", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show(@"Не удалось установить соединение с базой данных
Попробуйте позже или восстановите резервную копию необходимой базы данных", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            void SuccessfulAuthorization(string user)
            {
                MainForm.AccountId = data.Rows[0][0].ToString();
                MainForm.UserName = data.Rows[0][2] + " " + data.Rows[0][3].ToString().Substring(0, 1) + ".";
                if (data.Rows[0][4] != DBNull.Value)
                    MainForm.UserName += data.Rows[0][4].ToString().Substring(0, 1) + ".";
                
                switch (user)
                {
                    case "customer": MainForm.CustomerId = data.Rows[0][1].ToString(); break;
                    case "employee": MainForm.EmployeeId = data.Rows[0][1].ToString(); break;
                }

                MainForm.CreateUserFile(login, password);
                GoToBackForm();
            }
        }

        private void KeyPressValidate(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 1 && e.KeyChar <= 31) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 33 && e.KeyChar <= 38) || (e.KeyChar >= 40 && e.KeyChar <= 126)  || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void goToClear_Click(object sender, EventArgs e)
        {
            loginBox.Text = Empty;
            passwordBox.Text = Empty;
        }
    }
}
