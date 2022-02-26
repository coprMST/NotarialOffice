using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotarialOffice
{
    public partial class CreateAccountForm : Form
    {
        private int x = 0;
        private int y = 0;
        
        public CreateAccountForm()
        {
            InitializeComponent();
            SetRoundedShape(goToRegistration, 45);
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
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
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
            string email = emailBox.Text;
            string phone = phoneBox.Text;
            string fio = fioBox.Text.Trim();
            string dob = dobBox.Text;
            string firstPassword = firstPasswordBox.Text;
            string secondPassword = secondPasswordBox.Text;

            if (String.IsNullOrEmpty(email))
                MessageBox.Show("Для регистрации введите электронную почту", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!Regex.IsMatch(email, ".+[@].+[.].+"))
                MessageBox.Show("Для регистрации введите корректно электронную почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (String.IsNullOrEmpty(phone))
                MessageBox.Show("Для регистрации введите номер телефона", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(phone, out long test) || phone.Length < 11)
                MessageBox.Show("Для регистрации введите корректно номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (String.IsNullOrEmpty(fio))
                MessageBox.Show("Для регистрации введите фамилию, имя и отчество (при наличии)", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (fio.Split(new char[] { ' ' }).Length < 2 || fio.Split(new char[] { ' ' }).Length > 3 || fio.Length < 3)
                MessageBox.Show("Для регистрации введите корректно фамилию, имя и отчество (при наличии)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (String.IsNullOrEmpty(dob))
                MessageBox.Show("Для регистрации введите дату рождения", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!DateTime.TryParse(dob, out DateTime dt))
                MessageBox.Show("Для регистрации введите корректно дату рождения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((dt.AddYears(18) - DateTime.Now).TotalDays > 0)
                MessageBox.Show("Для регистрации Вы должны быть совершеннолетим", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (String.IsNullOrEmpty(firstPassword) && String.IsNullOrEmpty(secondPassword))
                MessageBox.Show("Для регистрации введите пароль(-и)", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (firstPassword.Length < 8 || secondPassword.Length < 8)
                MessageBox.Show("Для регистрации введите пароль минимум из 8 символов", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (firstPassword != secondPassword)
                MessageBox.Show("Для регистрации введите одинаковые пароли в соответствующих полях", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] temp_fio = fio.Split(new char[] { ' ' });
                string lastName = temp_fio[0];
                string firstName = temp_fio[1];
                string middleName = "NULL";
                if (temp_fio.Length == 3)
                    middleName = temp_fio[2];

                try
                {
                    DataTable dataTable = MainForm.GetData($"exec [dbo].[CheckPhoneAndEmail] '{phone}', '{email}'");

                    if (dataTable.Rows[0][0].ToString() == "True")
                    {
                        MessageBox.Show("Вы ввели существующий номер телефона и/или электронную почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataTable = MainForm.GetData($"exec [dbo].[AddNewCustomer] '{lastName}', '{firstName}', {middleName}, '{dob}', {phone}, '{email}', '{firstPassword}'");
                        if (dataTable.Rows.Count != 0)
                        {
                            MessageBox.Show("Вы были успешно зарегистрированы\nСейчас вы перенаправитесь на главную страницу", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm.AccountID = dataTable.Rows[0][0].ToString();
                            MainForm.CustomerID = dataTable.Rows[1][0].ToString();
                            MainForm.UserName = lastName + " " + firstName.Substring(0, 1) + ".";
                            if (middleName != "NULL")
                                MainForm.UserName += middleName.Substring(0, 1) + ".";

                            Form mainForm = new MainForm();
                            this.Close();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось завершить регистрацию\nПопробуйте позже", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось установить соединение с базой данных\nПопробуйте позже или восстановите резервную копию необходимой базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goToAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form authorizationForm = new AuthorizationForm();
            this.Close();
            authorizationForm.Show();
        }
    }
}
