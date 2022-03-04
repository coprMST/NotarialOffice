using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace NotarialOffice
{
    public partial class CreateAccountForm : Form
    {
        private int _x;
        private int _y;
        
        public CreateAccountForm()
        {
            InitializeComponent();
            SetRoundedShape(goToRegistration, 45);
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
            Form authorizationForm = new AuthorizationForm();
            this.Close();
            authorizationForm.Show();
        }

        private async void goToCheckPassword_Click(object sender, EventArgs e)
        {
            goToCheckPassword.Enabled = false;
            firstPasswordBox.UseSystemPasswordChar = false;
            secondPasswordBox.UseSystemPasswordChar = false;
            await Task.Delay(2000);
            firstPasswordBox.UseSystemPasswordChar = true;
            secondPasswordBox.UseSystemPasswordChar = true;
            goToCheckPassword.Enabled = true;
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

        private void emailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 1 && e.KeyChar <= 31) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 33 && e.KeyChar <= 38) || (e.KeyChar >= 40 && e.KeyChar <= 126) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void fioBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 1 && e.KeyChar <= 31) || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 45 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space) { }
            else e.Handled = true;
        }

        private void goToRegistration_Click(object sender, EventArgs e)
        {
            var email = emailBox.Text;
            var phone = phoneBox.Text;
            var fio = fioBox.Text.Trim();
            var dob = dobBox.Text;
            var topPassword = firstPasswordBox.Text;
            var bottomPassword = secondPasswordBox.Text;
            
            if (IsNullOrEmpty(email))
                MessageBox.Show(@"Для регистрации введите электронную почту", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!Regex.IsMatch(email, ".+[@].+[.].+"))
                MessageBox.Show(@"Для регистрации введите корректно электронную почту", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IsNullOrEmpty(phone))
                MessageBox.Show(@"Для регистрации введите номер телефона", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(phone, out _) || phone.Length < 11)
                MessageBox.Show(@"Для регистрации введите корректно номер телефона", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IsNullOrEmpty(fio))
                MessageBox.Show(@"Для регистрации введите фамилию, имя и отчество (при наличии)", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (fio.Split(' ').Length < 2 || fio.Split(' ').Length > 3 || fio.Length < 3)
                MessageBox.Show(@"Для регистрации введите корректно фамилию, имя и отчество (при наличии)", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IsNullOrEmpty(dob))
                MessageBox.Show(@"Для регистрации введите дату рождения", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!DateTime.TryParse(dob, out var date))
                MessageBox.Show(@"Для регистрации введите коррекtтно дату рождения", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((date.AddYears(18) - DateTime.Today).TotalDays >= 0)
                MessageBox.Show(@"Для регистрации Вы должны быть совершеннолетим", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IsNullOrEmpty(topPassword) && IsNullOrEmpty(bottomPassword))
                MessageBox.Show(@"Для регистрации введите пароль(-и)", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (topPassword != null && (topPassword.Length < 8 || bottomPassword.Length < 8))
                MessageBox.Show(@"Для регистрации введите пароль минимум из 8 символов", @"Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (topPassword != bottomPassword)
                MessageBox.Show(@"Для регистрации введите одинаковые пароли в соответствующих полях", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var tempFio = fio.Split(' ');
                var lastName = tempFio[0];
                var firstName = tempFio[1];
                var middleName = "NULL";
                if (tempFio.Length == 3)
                    middleName = tempFio[2];

                try
                {
                    var dataTable = MainForm.GetData($"exec [dbo].[CheckPhoneAndEmail] '{phone}', '{email}'");
                    if (dataTable.Rows[0][0].ToString() == "True")
                    {
                        MessageBox.Show(@"Вы ввели существующий номер телефона и/или электронную почту", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataTable = MainForm.GetData($"exec [dbo].[AddNewCustomer] '{lastName}', '{firstName}', {middleName}, '{dob}', {phone}, '{email}', '{topPassword}'");
                        if (dataTable.Rows.Count != 0)
                        {
                            MessageBox.Show(@"Вы были успешно зарегистрированы
Сейчас вы перенаправитесь на главную страницу", @"Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm.AccountId = dataTable.Rows[0][0].ToString();
                            MainForm.CustomerId = dataTable.Rows[1][0].ToString();
                            MainForm.UserName = lastName + " " + firstName.Substring(0, 1) + ".";
                            if (middleName != "NULL")
                                MainForm.UserName += middleName.Substring(0, 1) + ".";

                            Form mainForm = new MainForm();
                            this.Close();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show(@"Не удалось завершить регистрацию
Попробуйте позже", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show(@"Не удалось установить соединение с базой данных
Попробуйте позже или восстановите резервную копию необходимой базы данных", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goToAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form authorizationForm = new AuthorizationForm();
            Close();
            authorizationForm.Show();
        }
    }
}
