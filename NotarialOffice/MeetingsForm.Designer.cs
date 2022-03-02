using System.ComponentModel;

namespace NotarialOffice
{
    partial class MeetingsForm
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
            this.goToCreate = new FontAwesome.Sharp.IconButton();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.MaskedTextBox();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // goToCreate
            // 
            this.goToCreate.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (185)))), ((int) (((byte) (142)))));
            this.goToCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCreate.Enabled = false;
            this.goToCreate.FlatAppearance.BorderSize = 0;
            this.goToCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goToCreate.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToCreate.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.goToCreate.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToCreate.IconSize = 32;
            this.goToCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCreate.Location = new System.Drawing.Point(231, 475);
            this.goToCreate.Name = "goToCreate";
            this.goToCreate.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToCreate.Size = new System.Drawing.Size(319, 60);
            this.goToCreate.TabIndex = 4;
            this.goToCreate.Text = "Записаться на встречу";
            this.goToCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainToolTip.SetToolTip(this.goToCreate, "Записаться на встречу с нотариусом");
            this.goToCreate.UseVisualStyleBackColor = false;
            this.goToCreate.Click += new System.EventHandler(this.goToCreate_Click);
            // 
            // commentBox
            // 
            this.commentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentBox.Enabled = false;
            this.commentBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.commentBox.Location = new System.Drawing.Point(55, 334);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(671, 96);
            this.commentBox.TabIndex = 3;
            this.commentBox.Text = "";
            this.mainToolTip.SetToolTip(this.commentBox, "Поле для ввода комментария");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label7.Location = new System.Drawing.Point(118, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(574, 47);
            this.label7.TabIndex = 105;
            this.label7.Text = "Выберите дату и время встречи\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label8.Location = new System.Drawing.Point(70, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 30);
            this.label8.TabIndex = 106;
            this.label8.Text = "Комментарий";
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dateBox.Location = new System.Drawing.Point(266, 129);
            this.dateBox.Mask = "00/00/0000";
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(213, 39);
            this.dateBox.TabIndex = 1;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.dateBox, "Указать дату встречи");
            this.dateBox.ValidatingType = typeof(System.DateTime);
            this.dateBox.TextChanged += new System.EventHandler(this.dateBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.Enabled = false;
            this.timeBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.timeBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Items.AddRange(new object[] {"10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00"});
            this.timeBox.Location = new System.Drawing.Point(266, 206);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(213, 40);
            this.timeBox.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.timeBox, "Выбрать время встречи");
            this.timeBox.SelectedIndexChanged += new System.EventHandler(this.timeBox_SelectedIndexChanged);
            // 
            // MeetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.goToCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingsForm";
            this.Text = "MeetingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolTip mainToolTip;

        private System.Windows.Forms.ComboBox timeBox;

        private System.Windows.Forms.MaskedTextBox dateBox;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.RichTextBox commentBox;

        private FontAwesome.Sharp.IconButton goToCreate;

        #endregion
    }
}