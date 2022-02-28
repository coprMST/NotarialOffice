
namespace NotarialOffice
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.goToBack = new FontAwesome.Sharp.IconButton();
            this.logoLabel = new System.Windows.Forms.Label();
            this.goToMaximizedApp = new FontAwesome.Sharp.IconButton();
            this.goToExitApp = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.goToCreateAccount = new System.Windows.Forms.LinkLabel();
            this.goToCheckPassword = new FontAwesome.Sharp.IconButton();
            this.goToClear = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.goToLogIn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.headerPanel.Controls.Add(this.goToBack);
            this.headerPanel.Controls.Add(this.logoLabel);
            this.headerPanel.Controls.Add(this.goToMaximizedApp);
            this.headerPanel.Controls.Add(this.goToExitApp);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(600, 50);
            this.headerPanel.TabIndex = 11;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // goToBack
            // 
            this.goToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.goToBack.FlatAppearance.BorderSize = 0;
            this.goToBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToBack.ForeColor = System.Drawing.Color.White;
            this.goToBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.goToBack.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (227)))), ((int) (((byte) (252)))));
            this.goToBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToBack.IconSize = 32;
            this.goToBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToBack.Location = new System.Drawing.Point(0, 0);
            this.goToBack.Name = "goToBack";
            this.goToBack.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToBack.Size = new System.Drawing.Size(60, 50);
            this.goToBack.TabIndex = 7;
            this.goToBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToBack, "Перейти на основную страницу");
            this.goToBack.UseVisualStyleBackColor = true;
            this.goToBack.Click += new System.EventHandler(this.goToBack_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (227)))), ((int) (((byte) (252)))));
            this.logoLabel.Location = new System.Drawing.Point(66, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(309, 32);
            this.logoLabel.TabIndex = 5;
            this.logoLabel.Text = "Нотариальная контора";
            this.logoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.logoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // goToMaximizedApp
            // 
            this.goToMaximizedApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToMaximizedApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToMaximizedApp.FlatAppearance.BorderSize = 0;
            this.goToMaximizedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToMaximizedApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToMaximizedApp.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (227)))), ((int) (((byte) (252)))));
            this.goToMaximizedApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.goToMaximizedApp.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (227)))), ((int) (((byte) (252)))));
            this.goToMaximizedApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToMaximizedApp.IconSize = 32;
            this.goToMaximizedApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToMaximizedApp.Location = new System.Drawing.Point(480, 0);
            this.goToMaximizedApp.Name = "goToMaximizedApp";
            this.goToMaximizedApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToMaximizedApp.Size = new System.Drawing.Size(60, 50);
            this.goToMaximizedApp.TabIndex = 8;
            this.goToMaximizedApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToMaximizedApp, "Свернуть приложение");
            this.goToMaximizedApp.UseVisualStyleBackColor = true;
            this.goToMaximizedApp.Click += new System.EventHandler(this.goToMaximizedApp_Click);
            // 
            // goToExitApp
            // 
            this.goToExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToExitApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToExitApp.FlatAppearance.BorderSize = 0;
            this.goToExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToExitApp.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (227)))), ((int) (((byte) (252)))));
            this.goToExitApp.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.goToExitApp.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (227)))), ((int) (((byte) (252)))));
            this.goToExitApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToExitApp.IconSize = 32;
            this.goToExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToExitApp.Location = new System.Drawing.Point(540, 0);
            this.goToExitApp.Name = "goToExitApp";
            this.goToExitApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToExitApp.Size = new System.Drawing.Size(60, 50);
            this.goToExitApp.TabIndex = 9;
            this.goToExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToExitApp, "Выйти из приложения");
            this.goToExitApp.UseVisualStyleBackColor = true;
            this.goToExitApp.Click += new System.EventHandler(this.goToExitApp_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.goToCreateAccount);
            this.mainPanel.Controls.Add(this.goToCheckPassword);
            this.mainPanel.Controls.Add(this.goToClear);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.goToLogIn);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.passwordBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.loginBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.mainPanel.Size = new System.Drawing.Size(600, 650);
            this.mainPanel.TabIndex = 12;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // goToCreateAccount
            // 
            this.goToCreateAccount.AutoSize = true;
            this.goToCreateAccount.DisabledLinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToCreateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToCreateAccount.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToCreateAccount.Location = new System.Drawing.Point(190, 395);
            this.goToCreateAccount.Name = "goToCreateAccount";
            this.goToCreateAccount.Size = new System.Drawing.Size(223, 21);
            this.goToCreateAccount.TabIndex = 4;
            this.goToCreateAccount.TabStop = true;
            this.goToCreateAccount.Text = "Нет аккаунта? Создайте!";
            this.mainToolTip.SetToolTip(this.goToCreateAccount, "Создать новый аккаунт клиента");
            this.goToCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToCreateAccount_LinkClicked);
            // 
            // goToCheckPassword
            // 
            this.goToCheckPassword.BackColor = System.Drawing.Color.Transparent;
            this.goToCheckPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCheckPassword.FlatAppearance.BorderSize = 0;
            this.goToCheckPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToCheckPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToCheckPassword.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToCheckPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.goToCheckPassword.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToCheckPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToCheckPassword.IconSize = 32;
            this.goToCheckPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCheckPassword.Location = new System.Drawing.Point(414, 357);
            this.goToCheckPassword.Name = "goToCheckPassword";
            this.goToCheckPassword.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.goToCheckPassword.Size = new System.Drawing.Size(41, 35);
            this.goToCheckPassword.TabIndex = 3;
            this.goToCheckPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCheckPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToCheckPassword, "Временно показать пароль");
            this.goToCheckPassword.UseVisualStyleBackColor = false;
            this.goToCheckPassword.Click += new System.EventHandler(this.goToCheckPassword_Click);
            // 
            // goToClear
            // 
            this.goToClear.BackColor = System.Drawing.Color.Transparent;
            this.goToClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToClear.FlatAppearance.BorderSize = 0;
            this.goToClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToClear.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToClear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.goToClear.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToClear.IconSize = 32;
            this.goToClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToClear.Location = new System.Drawing.Point(212, 505);
            this.goToClear.Name = "goToClear";
            this.goToClear.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToClear.Size = new System.Drawing.Size(174, 60);
            this.goToClear.TabIndex = 6;
            this.goToClear.Text = "Очистить";
            this.goToClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToClear, "Очистить содержимое полей");
            this.goToClear.UseVisualStyleBackColor = false;
            this.goToClear.Click += new System.EventHandler(this.goToClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // goToLogIn
            // 
            this.goToLogIn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (185)))), ((int) (((byte) (142)))));
            this.goToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogIn.FlatAppearance.BorderSize = 0;
            this.goToLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogIn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToLogIn.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToLogIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.goToLogIn.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToLogIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLogIn.IconSize = 32;
            this.goToLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogIn.Location = new System.Drawing.Point(180, 432);
            this.goToLogIn.Name = "goToLogIn";
            this.goToLogIn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToLogIn.Size = new System.Drawing.Size(243, 60);
            this.goToLogIn.TabIndex = 5;
            this.goToLogIn.Text = "Авторизоваться";
            this.goToLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToLogIn, "Авторизоваться в системе");
            this.goToLogIn.UseVisualStyleBackColor = false;
            this.goToLogIn.Click += new System.EventHandler(this.goToLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label2.Location = new System.Drawing.Point(255, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Пароль";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.passwordBox.Location = new System.Drawing.Point(186, 357);
            this.passwordBox.MaxLength = 64;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(228, 35);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.passwordBox, "Поле для ввода пароля");
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label1.Location = new System.Drawing.Point(214, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Почта/Телефон";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.SystemColors.Window;
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.loginBox.Location = new System.Drawing.Point(186, 281);
            this.loginBox.MaxLength = 800;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(228, 35);
            this.loginBox.TabIndex = 1;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.loginBox, "Поле для ввода номера телефона или электронной почты");
            this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidate);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private FontAwesome.Sharp.IconButton goToBack;
        private System.Windows.Forms.Label logoLabel;
        private FontAwesome.Sharp.IconButton goToMaximizedApp;
        private FontAwesome.Sharp.IconButton goToExitApp;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconButton goToCheckPassword;
        private FontAwesome.Sharp.IconButton goToClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton goToLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.LinkLabel goToCreateAccount;
    }
}