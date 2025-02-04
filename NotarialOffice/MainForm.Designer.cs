﻿
namespace NotarialOffice
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.goToExitApp = new FontAwesome.Sharp.IconButton();
            this.goToMaximizedApp = new FontAwesome.Sharp.IconButton();
            this.goToLogIn = new FontAwesome.Sharp.IconButton();
            this.goToLogOut = new FontAwesome.Sharp.IconButton();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.goToInfo = new FontAwesome.Sharp.IconButton();
            this.goToDocuments = new FontAwesome.Sharp.IconButton();
            this.goToCreateMeeting = new FontAwesome.Sharp.IconButton();
            this.goToSettings = new FontAwesome.Sharp.IconButton();
            this.goToMyMeetings = new FontAwesome.Sharp.IconButton();
            this.goToAdminMeetings = new FontAwesome.Sharp.IconButton();
            this.goToCustomers = new FontAwesome.Sharp.IconButton();
            this.goToEmployees = new FontAwesome.Sharp.IconButton();
            this.logInPanel = new System.Windows.Forms.Panel();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.workPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.logInPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.goToExitApp.Location = new System.Drawing.Point(940, 0);
            this.goToExitApp.Name = "goToExitApp";
            this.goToExitApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToExitApp.Size = new System.Drawing.Size(60, 50);
            this.goToExitApp.TabIndex = 24;
            this.goToExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToExitApp, "Выйти из приложения");
            this.goToExitApp.UseVisualStyleBackColor = true;
            this.goToExitApp.Click += new System.EventHandler(this.goToExitApp_Click);
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
            this.goToMaximizedApp.Location = new System.Drawing.Point(880, 0);
            this.goToMaximizedApp.Name = "goToMaximizedApp";
            this.goToMaximizedApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToMaximizedApp.Size = new System.Drawing.Size(60, 50);
            this.goToMaximizedApp.TabIndex = 26;
            this.goToMaximizedApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToMaximizedApp, "Свернуть приложение");
            this.goToMaximizedApp.UseVisualStyleBackColor = true;
            this.goToMaximizedApp.Click += new System.EventHandler(this.goToMaximizedApp_Click);
            // 
            // goToLogIn
            // 
            this.goToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToLogIn.FlatAppearance.BorderSize = 0;
            this.goToLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToLogIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.goToLogIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToLogIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLogIn.IconSize = 32;
            this.goToLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogIn.Location = new System.Drawing.Point(680, 0);
            this.goToLogIn.Name = "goToLogIn";
            this.goToLogIn.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToLogIn.Size = new System.Drawing.Size(200, 50);
            this.goToLogIn.TabIndex = 100;
            this.goToLogIn.Text = "Войти";
            this.goToLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToLogIn, "Перейти на страницу авторизации");
            this.goToLogIn.UseVisualStyleBackColor = true;
            this.goToLogIn.Click += new System.EventHandler(this.goToLogIn_Click);
            // 
            // goToLogOut
            // 
            this.goToLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToLogOut.FlatAppearance.BorderSize = 0;
            this.goToLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.goToLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLogOut.IconSize = 32;
            this.goToLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogOut.Location = new System.Drawing.Point(213, 0);
            this.goToLogOut.Name = "goToLogOut";
            this.goToLogOut.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToLogOut.Size = new System.Drawing.Size(200, 50);
            this.goToLogOut.TabIndex = 101;
            this.goToLogOut.Text = "ВЫЙТИ";
            this.goToLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToLogOut, "Выйти из аккаунта");
            this.goToLogOut.UseVisualStyleBackColor = true;
            this.goToLogOut.Click += new System.EventHandler(this.goToLogOut_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(2, 0);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(198, 126);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 2;
            this.mainLogo.TabStop = false;
            this.mainToolTip.SetToolTip(this.mainLogo, "Открыть страницу основной информации");
            this.mainLogo.Click += new System.EventHandler(this.goToInfo_Click);
            // 
            // goToInfo
            // 
            this.goToInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToInfo.FlatAppearance.BorderSize = 0;
            this.goToInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToInfo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.goToInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToInfo.IconSize = 32;
            this.goToInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToInfo.Location = new System.Drawing.Point(2, 126);
            this.goToInfo.Name = "goToInfo";
            this.goToInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToInfo.Size = new System.Drawing.Size(198, 60);
            this.goToInfo.TabIndex = 6;
            this.goToInfo.Text = "Информация";
            this.goToInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToInfo, "Открыть страницу основной информации");
            this.goToInfo.UseVisualStyleBackColor = true;
            this.goToInfo.Click += new System.EventHandler(this.goToInfo_Click);
            // 
            // goToDocuments
            // 
            this.goToDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToDocuments.FlatAppearance.BorderSize = 0;
            this.goToDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToDocuments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToDocuments.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.goToDocuments.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToDocuments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToDocuments.IconSize = 32;
            this.goToDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToDocuments.Location = new System.Drawing.Point(2, 186);
            this.goToDocuments.Name = "goToDocuments";
            this.goToDocuments.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToDocuments.Size = new System.Drawing.Size(198, 60);
            this.goToDocuments.TabIndex = 7;
            this.goToDocuments.Text = "Документы";
            this.goToDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToDocuments, "Открыть страницу документов");
            this.goToDocuments.UseVisualStyleBackColor = true;
            this.goToDocuments.Click += new System.EventHandler(this.goToDocuments_Click);
            // 
            // goToCreateMeeting
            // 
            this.goToCreateMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCreateMeeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToCreateMeeting.FlatAppearance.BorderSize = 0;
            this.goToCreateMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToCreateMeeting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToCreateMeeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToCreateMeeting.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            this.goToCreateMeeting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToCreateMeeting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToCreateMeeting.IconSize = 32;
            this.goToCreateMeeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCreateMeeting.Location = new System.Drawing.Point(2, 246);
            this.goToCreateMeeting.Name = "goToCreateMeeting";
            this.goToCreateMeeting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToCreateMeeting.Size = new System.Drawing.Size(198, 60);
            this.goToCreateMeeting.TabIndex = 8;
            this.goToCreateMeeting.Text = "Записаться \r\nна встречу";
            this.goToCreateMeeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCreateMeeting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToCreateMeeting, "Открыть страницу записи на встречу с нотариусом");
            this.goToCreateMeeting.UseVisualStyleBackColor = true;
            this.goToCreateMeeting.Visible = false;
            this.goToCreateMeeting.Click += new System.EventHandler(this.goToMyDocuments_Click);
            // 
            // goToSettings
            // 
            this.goToSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToSettings.FlatAppearance.BorderSize = 0;
            this.goToSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.goToSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSettings.IconSize = 32;
            this.goToSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSettings.Location = new System.Drawing.Point(2, 588);
            this.goToSettings.Name = "goToSettings";
            this.goToSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToSettings.Size = new System.Drawing.Size(198, 60);
            this.goToSettings.TabIndex = 104;
            this.goToSettings.Text = "Настройки";
            this.goToSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToSettings, "Открыть меню настроек приложения");
            this.goToSettings.UseVisualStyleBackColor = true;
            this.goToSettings.Click += new System.EventHandler(this.goToSettings_Click);
            // 
            // goToMyMeetings
            // 
            this.goToMyMeetings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToMyMeetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToMyMeetings.FlatAppearance.BorderSize = 0;
            this.goToMyMeetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToMyMeetings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToMyMeetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToMyMeetings.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.goToMyMeetings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToMyMeetings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToMyMeetings.IconSize = 32;
            this.goToMyMeetings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToMyMeetings.Location = new System.Drawing.Point(2, 306);
            this.goToMyMeetings.Name = "goToMyMeetings";
            this.goToMyMeetings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToMyMeetings.Size = new System.Drawing.Size(198, 60);
            this.goToMyMeetings.TabIndex = 111;
            this.goToMyMeetings.Text = "Мои встречи";
            this.goToMyMeetings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToMyMeetings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToMyMeetings, "Открыть страницу моих встреч");
            this.goToMyMeetings.UseVisualStyleBackColor = true;
            this.goToMyMeetings.Visible = false;
            this.goToMyMeetings.Click += new System.EventHandler(this.goToMyMeetings_Click);
            // 
            // goToAdminMeetings
            // 
            this.goToAdminMeetings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToAdminMeetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToAdminMeetings.FlatAppearance.BorderSize = 0;
            this.goToAdminMeetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToAdminMeetings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToAdminMeetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToAdminMeetings.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.goToAdminMeetings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToAdminMeetings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToAdminMeetings.IconSize = 32;
            this.goToAdminMeetings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToAdminMeetings.Location = new System.Drawing.Point(2, 366);
            this.goToAdminMeetings.Name = "goToAdminMeetings";
            this.goToAdminMeetings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToAdminMeetings.Size = new System.Drawing.Size(198, 60);
            this.goToAdminMeetings.TabIndex = 112;
            this.goToAdminMeetings.Text = "Встречи";
            this.goToAdminMeetings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToAdminMeetings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToAdminMeetings, "Открыть страницу встреч с клиентами");
            this.goToAdminMeetings.UseVisualStyleBackColor = true;
            this.goToAdminMeetings.Visible = false;
            this.goToAdminMeetings.Click += new System.EventHandler(this.goToAdminMeetings_Click);
            // 
            // goToCustomers
            // 
            this.goToCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToCustomers.FlatAppearance.BorderSize = 0;
            this.goToCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToCustomers.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.goToCustomers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToCustomers.IconSize = 32;
            this.goToCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCustomers.Location = new System.Drawing.Point(2, 426);
            this.goToCustomers.Name = "goToCustomers";
            this.goToCustomers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToCustomers.Size = new System.Drawing.Size(198, 60);
            this.goToCustomers.TabIndex = 113;
            this.goToCustomers.Text = "Клиенты";
            this.goToCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToCustomers, "Открыть страницу клиентов");
            this.goToCustomers.UseVisualStyleBackColor = true;
            this.goToCustomers.Visible = false;
            this.goToCustomers.Click += new System.EventHandler(this.goToCustomers_Click);
            // 
            // goToEmployees
            // 
            this.goToEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToEmployees.FlatAppearance.BorderSize = 0;
            this.goToEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToEmployees.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToEmployees.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.goToEmployees.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.goToEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToEmployees.IconSize = 32;
            this.goToEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToEmployees.Location = new System.Drawing.Point(2, 486);
            this.goToEmployees.Name = "goToEmployees";
            this.goToEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToEmployees.Size = new System.Drawing.Size(198, 60);
            this.goToEmployees.TabIndex = 114;
            this.goToEmployees.Text = "Сотрудники";
            this.goToEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToEmployees, "Открыть страницу сотрудников");
            this.goToEmployees.UseVisualStyleBackColor = true;
            this.goToEmployees.Visible = false;
            this.goToEmployees.Click += new System.EventHandler(this.goToEmployees_Click);
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.myNameLabel);
            this.logInPanel.Controls.Add(this.label4);
            this.logInPanel.Controls.Add(this.goToLogOut);
            this.logInPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logInPanel.Location = new System.Drawing.Point(267, 0);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(413, 50);
            this.logInPanel.TabIndex = 102;
            this.logInPanel.Visible = false;
            this.logInPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.logInPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.myNameLabel.Location = new System.Drawing.Point(3, 23);
            this.myNameLabel.MaximumSize = new System.Drawing.Size(200, 24);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(129, 24);
            this.myNameLabel.TabIndex = 4;
            this.myNameLabel.Text = "Иванов И.И.";
            this.myNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.myNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "С возвращением,";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.logoLabel.Location = new System.Drawing.Point(12, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(283, 32);
            this.logoLabel.TabIndex = 5;
            this.logoLabel.Text = "Нотариальные услуги";
            this.logoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.logoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.headerPanel.Controls.Add(this.logoLabel);
            this.headerPanel.Controls.Add(this.logInPanel);
            this.headerPanel.Controls.Add(this.goToLogIn);
            this.headerPanel.Controls.Add(this.goToMaximizedApp);
            this.headerPanel.Controls.Add(this.goToExitApp);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 50);
            this.headerPanel.TabIndex = 10;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(200)))), ((int)(((byte)(172)))));
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(200, 50);
            this.workPanel.Name = "workPanel";
            this.workPanel.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.workPanel.Size = new System.Drawing.Size(800, 650);
            this.workPanel.TabIndex = 12;
            this.workPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))));
            this.menuPanel.Controls.Add(this.goToEmployees);
            this.menuPanel.Controls.Add(this.goToCustomers);
            this.menuPanel.Controls.Add(this.goToAdminMeetings);
            this.menuPanel.Controls.Add(this.goToMyMeetings);
            this.menuPanel.Controls.Add(this.goToSettings);
            this.menuPanel.Controls.Add(this.goToCreateMeeting);
            this.menuPanel.Controls.Add(this.goToDocuments);
            this.menuPanel.Controls.Add(this.goToInfo);
            this.menuPanel.Controls.Add(this.mainLogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 50);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.menuPanel.Size = new System.Drawing.Size(200, 650);
            this.menuPanel.TabIndex = 11;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private FontAwesome.Sharp.IconButton goToExitApp;
        private FontAwesome.Sharp.IconButton goToMaximizedApp;
        private FontAwesome.Sharp.IconButton goToLogIn;
        private System.Windows.Forms.Panel logInPanel;
        private FontAwesome.Sharp.IconButton goToLogOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.PictureBox mainLogo;
        private FontAwesome.Sharp.IconButton goToInfo;
        private FontAwesome.Sharp.IconButton goToDocuments;
        private FontAwesome.Sharp.IconButton goToCreateMeeting;
        private FontAwesome.Sharp.IconButton goToSettings;
        private FontAwesome.Sharp.IconButton goToMyMeetings;
        private FontAwesome.Sharp.IconButton goToAdminMeetings;
        private FontAwesome.Sharp.IconButton goToCustomers;
        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton goToEmployees;

        #endregion

        private System.Windows.Forms.ToolTip mainToolTip;
    }
}

