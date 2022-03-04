using System.ComponentModel;

namespace NotarialOffice
{
    partial class MeetingDates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.seacherPanel = new System.Windows.Forms.Panel();
            this.setNullSeacher = new System.Windows.Forms.LinkLabel();
            this.seacher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.seacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.customersTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 47);
            this.label2.TabIndex = 121;
            this.label2.Text = "Данные записей клиентов на встречу";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seacherPanel
            // 
            this.seacherPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.seacherPanel.Controls.Add(this.setNullSeacher);
            this.seacherPanel.Controls.Add(this.seacher);
            this.seacherPanel.Controls.Add(this.label5);
            this.seacherPanel.Location = new System.Drawing.Point(15, 78);
            this.seacherPanel.Name = "seacherPanel";
            this.seacherPanel.Size = new System.Drawing.Size(420, 87);
            this.seacherPanel.TabIndex = 120;
            // 
            // setNullSeacher
            // 
            this.setNullSeacher.AutoSize = true;
            this.setNullSeacher.DisabledLinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.setNullSeacher.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.setNullSeacher.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.setNullSeacher.Location = new System.Drawing.Point(320, 12);
            this.setNullSeacher.Name = "setNullSeacher";
            this.setNullSeacher.Size = new System.Drawing.Size(88, 21);
            this.setNullSeacher.TabIndex = 2;
            this.setNullSeacher.TabStop = true;
            this.setNullSeacher.Text = "Сбросить";
            this.mainToolTip.SetToolTip(this.setNullSeacher, "Сбросить введенную поисковую информацию");
            this.setNullSeacher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setNullSeacher_LinkClicked);
            // 
            // seacher
            // 
            this.seacher.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.seacher.Location = new System.Drawing.Point(13, 36);
            this.seacher.Name = "seacher";
            this.seacher.Size = new System.Drawing.Size(395, 33);
            this.seacher.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.seacher, "Поиск записей клиентов на встречу по введенной информации");
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
            // customersTable
            // 
            this.customersTable.AllowUserToAddRows = false;
            this.customersTable.AllowUserToDeleteRows = false;
            this.customersTable.AllowUserToResizeColumns = false;
            this.customersTable.AllowUserToResizeRows = false;
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Location = new System.Drawing.Point(15, 181);
            this.customersTable.MultiSelect = false;
            this.customersTable.Name = "customersTable";
            this.customersTable.ReadOnly = true;
            this.customersTable.RowHeadersVisible = false;
            this.customersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersTable.Size = new System.Drawing.Size(670, 459);
            this.customersTable.TabIndex = 117;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dateBox.Location = new System.Drawing.Point(8, 36);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(214, 33);
            this.dateBox.TabIndex = 122;
            this.dateBox.ValueChanged += new System.EventHandler(this.dateBox_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateBox);
            this.panel1.Location = new System.Drawing.Point(441, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 87);
            this.panel1.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Дата встреч";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeetingDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seacherPanel);
            this.Controls.Add(this.customersTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingDates";
            this.Text = "MeetingDates";
            this.seacherPanel.ResumeLayout(false);
            this.seacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.customersTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel seacherPanel;
        private System.Windows.Forms.LinkLabel setNullSeacher;
        private System.Windows.Forms.TextBox seacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.DataGridView customersTable;

        #endregion
    }
}