using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            if (e.KeyChar != (char)Keys.Space) { }
            else e.Handled = true;
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void fioBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Space ||  e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void firstPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space) { }
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
            else if (fio.Split(new char[] { ' ' }).Length <= 1 || fio.Length < 3)
                MessageBox.Show("Для регистрации введите корректно фамилию, имя и отчество (при наличии)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (String.IsNullOrEmpty(dob))
                MessageBox.Show("Для регистрации введите дату рождения", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!DateTime.TryParse(dob, out DateTime dt))
                MessageBox.Show("Для регистрации введите корректно дату рождения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (String.IsNullOrEmpty(firstPassword) && String.IsNullOrEmpty(secondPassword))
                MessageBox.Show("Для регистрации введите пароль(-и)", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (firstPassword.Length < 8 || secondPassword.Length < 8)
                MessageBox.Show("Для регистрации введите пароль минимум из 8 символов", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (firstPassword != secondPassword)
                MessageBox.Show("Для регистрации введите одинаковые пароли в соответствующих полях", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("aaaaaaaaaaaaaaaaaaaaaaaaa", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
