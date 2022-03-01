
namespace NotarialOffice
{
    partial class Documents
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
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.goToSortDocumentAZ = new FontAwesome.Sharp.IconButton();
            this.goToSortDocumentZA = new FontAwesome.Sharp.IconButton();
            this.goToSortDocumentTypeZA = new FontAwesome.Sharp.IconButton();
            this.goToSortDocumentTypeAZ = new FontAwesome.Sharp.IconButton();
            this.setNullFiltration = new System.Windows.Forms.LinkLabel();
            this.setNullSeacher = new System.Windows.Forms.LinkLabel();
            this.filtrationBox = new System.Windows.Forms.ComboBox();
            this.seacherPanel = new System.Windows.Forms.Panel();
            this.seacher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.sortPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrationPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.servicesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.seacherPanel.SuspendLayout();
            this.workPanel.SuspendLayout();
            this.sortPanel.SuspendLayout();
            this.filtrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // goToSortDocumentAZ
            // 
            this.goToSortDocumentAZ.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.goToSortDocumentAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSortDocumentAZ.FlatAppearance.BorderSize = 0;
            this.goToSortDocumentAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSortDocumentAZ.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToSortDocumentAZ.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentAZ.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.goToSortDocumentAZ.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentAZ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSortDocumentAZ.IconSize = 40;
            this.goToSortDocumentAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentAZ.Location = new System.Drawing.Point(26, 28);
            this.goToSortDocumentAZ.Name = "goToSortDocumentAZ";
            this.goToSortDocumentAZ.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.goToSortDocumentAZ.Size = new System.Drawing.Size(71, 61);
            this.goToSortDocumentAZ.TabIndex = 5;
            this.goToSortDocumentAZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentAZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToSortDocumentAZ, "Сортировать по документам от А до Я");
            this.goToSortDocumentAZ.UseVisualStyleBackColor = false;
            this.goToSortDocumentAZ.Click += new System.EventHandler(this.DataSort);
            // 
            // goToSortDocumentZA
            // 
            this.goToSortDocumentZA.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.goToSortDocumentZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSortDocumentZA.FlatAppearance.BorderSize = 0;
            this.goToSortDocumentZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSortDocumentZA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToSortDocumentZA.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentZA.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
            this.goToSortDocumentZA.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentZA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSortDocumentZA.IconSize = 40;
            this.goToSortDocumentZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentZA.Location = new System.Drawing.Point(103, 28);
            this.goToSortDocumentZA.Name = "goToSortDocumentZA";
            this.goToSortDocumentZA.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.goToSortDocumentZA.Size = new System.Drawing.Size(71, 61);
            this.goToSortDocumentZA.TabIndex = 6;
            this.goToSortDocumentZA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentZA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToSortDocumentZA, "Сортировать по документам от Я до А");
            this.goToSortDocumentZA.UseVisualStyleBackColor = false;
            this.goToSortDocumentZA.Click += new System.EventHandler(this.DataSort);
            // 
            // goToSortDocumentTypeZA
            // 
            this.goToSortDocumentTypeZA.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.goToSortDocumentTypeZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSortDocumentTypeZA.FlatAppearance.BorderSize = 0;
            this.goToSortDocumentTypeZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSortDocumentTypeZA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToSortDocumentTypeZA.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentTypeZA.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
            this.goToSortDocumentTypeZA.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentTypeZA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSortDocumentTypeZA.IconSize = 40;
            this.goToSortDocumentTypeZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentTypeZA.Location = new System.Drawing.Point(308, 28);
            this.goToSortDocumentTypeZA.Name = "goToSortDocumentTypeZA";
            this.goToSortDocumentTypeZA.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.goToSortDocumentTypeZA.Size = new System.Drawing.Size(71, 61);
            this.goToSortDocumentTypeZA.TabIndex = 8;
            this.goToSortDocumentTypeZA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentTypeZA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToSortDocumentTypeZA, "Сортировать по типу документов от Я до А");
            this.goToSortDocumentTypeZA.UseVisualStyleBackColor = false;
            this.goToSortDocumentTypeZA.Click += new System.EventHandler(this.DataSort);
            // 
            // goToSortDocumentTypeAZ
            // 
            this.goToSortDocumentTypeAZ.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.goToSortDocumentTypeAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSortDocumentTypeAZ.FlatAppearance.BorderSize = 0;
            this.goToSortDocumentTypeAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSortDocumentTypeAZ.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToSortDocumentTypeAZ.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentTypeAZ.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.goToSortDocumentTypeAZ.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSortDocumentTypeAZ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSortDocumentTypeAZ.IconSize = 40;
            this.goToSortDocumentTypeAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentTypeAZ.Location = new System.Drawing.Point(231, 28);
            this.goToSortDocumentTypeAZ.Name = "goToSortDocumentTypeAZ";
            this.goToSortDocumentTypeAZ.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.goToSortDocumentTypeAZ.Size = new System.Drawing.Size(71, 61);
            this.goToSortDocumentTypeAZ.TabIndex = 7;
            this.goToSortDocumentTypeAZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSortDocumentTypeAZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToSortDocumentTypeAZ, "Сортировать по типу документов от А до Я");
            this.goToSortDocumentTypeAZ.UseVisualStyleBackColor = false;
            this.goToSortDocumentTypeAZ.Click += new System.EventHandler(this.DataSort);
            // 
            // setNullFiltration
            // 
            this.setNullFiltration.AutoSize = true;
            this.setNullFiltration.DisabledLinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.setNullFiltration.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.setNullFiltration.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.setNullFiltration.Location = new System.Drawing.Point(245, 11);
            this.setNullFiltration.Name = "setNullFiltration";
            this.setNullFiltration.Size = new System.Drawing.Size(88, 21);
            this.setNullFiltration.TabIndex = 4;
            this.setNullFiltration.TabStop = true;
            this.setNullFiltration.Text = "Сбросить";
            this.mainToolTip.SetToolTip(this.setNullFiltration, "Сбросить выбранный фильтр");
            this.setNullFiltration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setNullFiltration_LinkClicked);
            // 
            // setNullSeacher
            // 
            this.setNullSeacher.AutoSize = true;
            this.setNullSeacher.DisabledLinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.setNullSeacher.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.setNullSeacher.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.setNullSeacher.Location = new System.Drawing.Point(305, 11);
            this.setNullSeacher.Name = "setNullSeacher";
            this.setNullSeacher.Size = new System.Drawing.Size(88, 21);
            this.setNullSeacher.TabIndex = 2;
            this.setNullSeacher.TabStop = true;
            this.setNullSeacher.Text = "Сбросить";
            this.mainToolTip.SetToolTip(this.setNullSeacher, "Сбросить введенную поисковую информацию");
            this.setNullSeacher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setNullSeacher_LinkClicked);
            // 
            // filtrationBox
            // 
            this.filtrationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtrationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrationBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.filtrationBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.filtrationBox.FormattingEnabled = true;
            this.filtrationBox.Items.AddRange(new object[] {"По названию типа документа", "По названию документа"});
            this.filtrationBox.Location = new System.Drawing.Point(13, 36);
            this.filtrationBox.Name = "filtrationBox";
            this.filtrationBox.Size = new System.Drawing.Size(320, 33);
            this.filtrationBox.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.filtrationBox, "Выбрать фильтрацию для услуг");
            this.filtrationBox.SelectedIndexChanged += new System.EventHandler(this.filtrationBox_SelectedIndexChanged);
            // 
            // seacherPanel
            // 
            this.seacherPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.seacherPanel.Controls.Add(this.setNullSeacher);
            this.seacherPanel.Controls.Add(this.seacher);
            this.seacherPanel.Controls.Add(this.label5);
            this.seacherPanel.Location = new System.Drawing.Point(12, 12);
            this.seacherPanel.Name = "seacherPanel";
            this.seacherPanel.Size = new System.Drawing.Size(412, 87);
            this.seacherPanel.TabIndex = 33;
            this.mainToolTip.SetToolTip(this.seacherPanel, "Поиск введенной информации");
            // 
            // seacher
            // 
            this.seacher.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.seacher.Location = new System.Drawing.Point(13, 36);
            this.seacher.Name = "seacher";
            this.seacher.Size = new System.Drawing.Size(380, 33);
            this.seacher.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.seacher, "Поиск услуг по введенной информации");
            this.seacher.TextChanged += new System.EventHandler(this.seacher_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Поисковик";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workPanel
            // 
            this.workPanel.Controls.Add(this.infoLabel);
            this.workPanel.Controls.Add(this.sortPanel);
            this.workPanel.Controls.Add(this.filtrationPanel);
            this.workPanel.Controls.Add(this.seacherPanel);
            this.workPanel.Controls.Add(this.servicesPanel);
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 0);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(800, 650);
            this.workPanel.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.infoLabel.Location = new System.Drawing.Point(160, 300);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(468, 47);
            this.infoLabel.TabIndex = 37;
            this.infoLabel.Text = "Результатов не найдено.\r\n";
            this.infoLabel.Visible = false;
            // 
            // sortPanel
            // 
            this.sortPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.sortPanel.Controls.Add(this.goToSortDocumentTypeZA);
            this.sortPanel.Controls.Add(this.goToSortDocumentAZ);
            this.sortPanel.Controls.Add(this.goToSortDocumentZA);
            this.sortPanel.Controls.Add(this.label2);
            this.sortPanel.Controls.Add(this.goToSortDocumentTypeAZ);
            this.sortPanel.Controls.Add(this.label1);
            this.sortPanel.Location = new System.Drawing.Point(188, 107);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(412, 97);
            this.sortPanel.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label2.Location = new System.Drawing.Point(228, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "По типу документов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label1.Location = new System.Drawing.Point(39, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "По документам";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filtrationPanel
            // 
            this.filtrationPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.filtrationPanel.Controls.Add(this.setNullFiltration);
            this.filtrationPanel.Controls.Add(this.filtrationBox);
            this.filtrationPanel.Controls.Add(this.label3);
            this.filtrationPanel.Location = new System.Drawing.Point(442, 12);
            this.filtrationPanel.Name = "filtrationPanel";
            this.filtrationPanel.Size = new System.Drawing.Size(346, 87);
            this.filtrationPanel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Фильтр поиска";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servicesPanel
            // 
            this.servicesPanel.AutoScroll = true;
            this.servicesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.servicesPanel.Location = new System.Drawing.Point(25, 218);
            this.servicesPanel.Name = "servicesPanel";
            this.servicesPanel.Size = new System.Drawing.Size(750, 420);
            this.servicesPanel.TabIndex = 1;
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.workPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents";
            this.seacherPanel.ResumeLayout(false);
            this.seacherPanel.PerformLayout();
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.sortPanel.ResumeLayout(false);
            this.sortPanel.PerformLayout();
            this.filtrationPanel.ResumeLayout(false);
            this.filtrationPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label infoLabel;

        private System.Windows.Forms.LinkLabel setNullFiltration;
        private System.Windows.Forms.LinkLabel setNullSeacher;

        #endregion

        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.FlowLayoutPanel servicesPanel;
        private FontAwesome.Sharp.IconButton goToSortDocumentZA;
        private FontAwesome.Sharp.IconButton goToSortDocumentAZ;
        private System.Windows.Forms.ComboBox filtrationBox;
        private System.Windows.Forms.TextBox seacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton goToSortDocumentTypeZA;
        private FontAwesome.Sharp.IconButton goToSortDocumentTypeAZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel seacherPanel;
        private System.Windows.Forms.Panel filtrationPanel;
        private System.Windows.Forms.Panel sortPanel;
    }
}