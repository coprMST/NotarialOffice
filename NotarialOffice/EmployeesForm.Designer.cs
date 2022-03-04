﻿using System.ComponentModel;

namespace NotarialOffice
{
    partial class EmployeesForm
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.goToDelete = new FontAwesome.Sharp.IconButton();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.seacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.employeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 47);
            this.label2.TabIndex = 121;
            this.label2.Text = "Данные сотрудников";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seacherPanel
            // 
            this.seacherPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (190)))), ((int) (((byte) (157)))));
            this.seacherPanel.Controls.Add(this.setNullSeacher);
            this.seacherPanel.Controls.Add(this.seacher);
            this.seacherPanel.Controls.Add(this.label5);
            this.seacherPanel.Location = new System.Drawing.Point(18, 79);
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
            this.mainToolTip.SetToolTip(this.seacher, "Поиск сотрудников по введенной информации");
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
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (184)))), ((int) (((byte) (134)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(507, 89);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(281, 77);
            this.iconButton1.TabIndex = 119;
            this.iconButton1.Text = "Перевести сотрудника\r\nв группу клиентов";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.iconButton1, "Перевести сотрудника в группу клиентов с подтверждением");
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.GoToMove);
            // 
            // mainToolTip
            // 
            this.mainToolTip.BackColor = System.Drawing.Color.Black;
            this.mainToolTip.ForeColor = System.Drawing.Color.White;
            // 
            // goToDelete
            // 
            this.goToDelete.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (184)))), ((int) (((byte) (134)))));
            this.goToDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToDelete.FlatAppearance.BorderSize = 0;
            this.goToDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToDelete.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToDelete.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.goToDelete.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToDelete.IconSize = 32;
            this.goToDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToDelete.Location = new System.Drawing.Point(554, 23);
            this.goToDelete.Name = "goToDelete";
            this.goToDelete.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToDelete.Size = new System.Drawing.Size(234, 60);
            this.goToDelete.TabIndex = 118;
            this.goToDelete.Text = "Удалить сотрудника";
            this.goToDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToDelete, "Удалить сотрудника из системы с подтверждением");
            this.goToDelete.UseVisualStyleBackColor = false;
            this.goToDelete.Click += new System.EventHandler(this.goToDelete_Click);
            // 
            // employeesTable
            // 
            this.employeesTable.AllowUserToAddRows = false;
            this.employeesTable.AllowUserToDeleteRows = false;
            this.employeesTable.AllowUserToResizeColumns = false;
            this.employeesTable.AllowUserToResizeRows = false;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Location = new System.Drawing.Point(18, 179);
            this.employeesTable.MultiSelect = false;
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.ReadOnly = true;
            this.employeesTable.RowHeadersVisible = false;
            this.employeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesTable.Size = new System.Drawing.Size(770, 459);
            this.employeesTable.TabIndex = 117;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seacherPanel);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.goToDelete);
            this.Controls.Add(this.employeesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.seacherPanel.ResumeLayout(false);
            this.seacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.employeesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel seacherPanel;
        private System.Windows.Forms.LinkLabel setNullSeacher;
        private System.Windows.Forms.TextBox seacher;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ToolTip mainToolTip;
        private FontAwesome.Sharp.IconButton goToDelete;
        private System.Windows.Forms.DataGridView employeesTable;

        #endregion
    }
}