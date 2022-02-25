
namespace NotarialOffice
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.secondPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.MaskedTextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.goToCheckPassword = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.goToRegistration = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.goToBack = new FontAwesome.Sharp.IconButton();
            this.goToMaximizedApp = new FontAwesome.Sharp.IconButton();
            this.goToExitApp = new FontAwesome.Sharp.IconButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.goToAuthorization = new System.Windows.Forms.LinkLabel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(200)))), ((int)(((byte)(172)))));
            this.mainPanel.Controls.Add(this.goToAuthorization);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.secondPasswordBox);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.firstPasswordBox);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.fioBox);
            this.mainPanel.Controls.Add(this.dobBox);
            this.mainPanel.Controls.Add(this.emailBox);
            this.mainPanel.Controls.Add(this.goToCheckPassword);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.goToRegistration);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.phoneBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.mainPanel.Size = new System.Drawing.Size(600, 650);
            this.mainPanel.TabIndex = 14;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.label7.Location = new System.Drawing.Point(200, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "Повторите пароль";
            // 
            // secondPasswordBox
            // 
            this.secondPasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.secondPasswordBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.secondPasswordBox.Location = new System.Drawing.Point(186, 443);
            this.secondPasswordBox.MaxLength = 64;
            this.secondPasswordBox.Name = "secondPasswordBox";
            this.secondPasswordBox.Size = new System.Drawing.Size(228, 35);
            this.secondPasswordBox.TabIndex = 6;
            this.secondPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.secondPasswordBox, "Поле для ввода пароля\r\n");
            this.secondPasswordBox.UseSystemPasswordChar = true;
            this.secondPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPasswordBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(195, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Электронная почта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.label6.Location = new System.Drawing.Point(253, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Пароль";
            // 
            // firstPasswordBox
            // 
            this.firstPasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstPasswordBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.firstPasswordBox.Location = new System.Drawing.Point(184, 372);
            this.firstPasswordBox.MaxLength = 64;
            this.firstPasswordBox.Name = "firstPasswordBox";
            this.firstPasswordBox.Size = new System.Drawing.Size(228, 35);
            this.firstPasswordBox.TabIndex = 5;
            this.firstPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.firstPasswordBox, "Поле для ввода пароля");
            this.firstPasswordBox.UseSystemPasswordChar = true;
            this.firstPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPasswordBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.label5.Location = new System.Drawing.Point(215, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(265, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "ФИО";
            // 
            // fioBox
            // 
            this.fioBox.BackColor = System.Drawing.SystemColors.Window;
            this.fioBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.fioBox.Location = new System.Drawing.Point(186, 230);
            this.fioBox.MaxLength = 2402;
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(228, 35);
            this.fioBox.TabIndex = 3;
            this.fioBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.fioBox, "Поле для ввода фамилии, имени и отчества");
            this.fioBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fioBox_KeyPress);
            // 
            // dobBox
            // 
            this.dobBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.dobBox.Location = new System.Drawing.Point(186, 301);
            this.dobBox.Mask = "00/00/0000";
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(226, 35);
            this.dobBox.TabIndex = 4;
            this.dobBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.dobBox, "Поле для ввода даты рождения");
            this.dobBox.ValidatingType = typeof(System.DateTime);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.emailBox.Location = new System.Drawing.Point(186, 88);
            this.emailBox.MaxLength = 800;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(228, 35);
            this.emailBox.TabIndex = 1;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.emailBox, "Поле для ввода электронной почты");
            this.emailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailBox_KeyPress);
            // 
            // goToCheckPassword
            // 
            this.goToCheckPassword.BackColor = System.Drawing.Color.Transparent;
            this.goToCheckPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCheckPassword.FlatAppearance.BorderSize = 0;
            this.goToCheckPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToCheckPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToCheckPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToCheckPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.goToCheckPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToCheckPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToCheckPassword.IconSize = 32;
            this.goToCheckPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCheckPassword.Location = new System.Drawing.Point(415, 443);
            this.goToCheckPassword.Name = "goToCheckPassword";
            this.goToCheckPassword.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.goToCheckPassword.Size = new System.Drawing.Size(41, 35);
            this.goToCheckPassword.TabIndex = 7;
            this.goToCheckPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCheckPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToCheckPassword, "Временно показать пароли");
            this.goToCheckPassword.UseVisualStyleBackColor = false;
            this.goToCheckPassword.Click += new System.EventHandler(this.goToCheckPassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // goToRegistration
            // 
            this.goToRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.goToRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToRegistration.FlatAppearance.BorderSize = 0;
            this.goToRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRegistration.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToRegistration.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.goToRegistration.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToRegistration.IconSize = 32;
            this.goToRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToRegistration.Location = new System.Drawing.Point(156, 510);
            this.goToRegistration.Name = "goToRegistration";
            this.goToRegistration.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToRegistration.Size = new System.Drawing.Size(290, 60);
            this.goToRegistration.TabIndex = 8;
            this.goToRegistration.Text = "Зарегистрироваться";
            this.goToRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToRegistration, "Зарегистрироваться в системе");
            this.goToRegistration.UseVisualStyleBackColor = false;
            this.goToRegistration.Click += new System.EventHandler(this.goToRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(208, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Номер телефона";
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.SystemColors.Window;
            this.phoneBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.phoneBox.Location = new System.Drawing.Point(186, 159);
            this.phoneBox.MaxLength = 38;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(228, 35);
            this.phoneBox.TabIndex = 2;
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.phoneBox, "Поле для ввода номера телефона");
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // goToBack
            // 
            this.goToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.goToBack.FlatAppearance.BorderSize = 0;
            this.goToBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToBack.ForeColor = System.Drawing.Color.White;
            this.goToBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.goToBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToBack.IconSize = 32;
            this.goToBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToBack.Location = new System.Drawing.Point(0, 0);
            this.goToBack.Name = "goToBack";
            this.goToBack.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToBack.Size = new System.Drawing.Size(60, 50);
            this.goToBack.TabIndex = 9;
            this.goToBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToBack, "Перейти на страницу авторизации");
            this.goToBack.UseVisualStyleBackColor = true;
            this.goToBack.Click += new System.EventHandler(this.goToBack_Click);
            // 
            // goToMaximizedApp
            // 
            this.goToMaximizedApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToMaximizedApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToMaximizedApp.FlatAppearance.BorderSize = 0;
            this.goToMaximizedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToMaximizedApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToMaximizedApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToMaximizedApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.goToMaximizedApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToMaximizedApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToMaximizedApp.IconSize = 32;
            this.goToMaximizedApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToMaximizedApp.Location = new System.Drawing.Point(480, 0);
            this.goToMaximizedApp.Name = "goToMaximizedApp";
            this.goToMaximizedApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToMaximizedApp.Size = new System.Drawing.Size(60, 50);
            this.goToMaximizedApp.TabIndex = 10;
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
            this.goToExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToExitApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToExitApp.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.goToExitApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToExitApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToExitApp.IconSize = 32;
            this.goToExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToExitApp.Location = new System.Drawing.Point(540, 0);
            this.goToExitApp.Name = "goToExitApp";
            this.goToExitApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToExitApp.Size = new System.Drawing.Size(60, 50);
            this.goToExitApp.TabIndex = 11;
            this.goToExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToExitApp, "Выйти из приложения");
            this.goToExitApp.UseVisualStyleBackColor = true;
            this.goToExitApp.Click += new System.EventHandler(this.goToExitApp_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.headerPanel.Controls.Add(this.goToBack);
            this.headerPanel.Controls.Add(this.logoLabel);
            this.headerPanel.Controls.Add(this.goToMaximizedApp);
            this.headerPanel.Controls.Add(this.goToExitApp);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(600, 50);
            this.headerPanel.TabIndex = 13;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.logoLabel.Location = new System.Drawing.Point(66, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(309, 32);
            this.logoLabel.TabIndex = 5;
            this.logoLabel.Text = "Нотариальная контора";
            this.logoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.logoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // goToAuthorization
            // 
            this.goToAuthorization.AutoSize = true;
            this.goToAuthorization.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToAuthorization.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToAuthorization.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToAuthorization.Location = new System.Drawing.Point(189, 582);
            this.goToAuthorization.Name = "goToAuthorization";
            this.goToAuthorization.Size = new System.Drawing.Size(221, 21);
            this.goToAuthorization.TabIndex = 38;
            this.goToAuthorization.TabStop = true;
            this.goToAuthorization.Text = "Вернуться к авторизации";
            this.mainToolTip.SetToolTip(this.goToAuthorization, "Перейти на авторизацию");
            this.goToAuthorization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToAuthorization_LinkClicked);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание аккаунта";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolTip mainToolTip;
        private FontAwesome.Sharp.IconButton goToCheckPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton goToRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneBox;
        private FontAwesome.Sharp.IconButton goToBack;
        private FontAwesome.Sharp.IconButton goToMaximizedApp;
        private FontAwesome.Sharp.IconButton goToExitApp;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.MaskedTextBox dobBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secondPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.LinkLabel goToAuthorization;
    }
}