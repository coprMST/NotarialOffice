using System.ComponentModel;

namespace NotarialOffice
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataSource = new System.Windows.Forms.TextBox();
            this.goToSavegoToSave = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(174, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Фамилия";
            // 
            // dataSource
            // 
            this.dataSource.BackColor = System.Drawing.SystemColors.Window;
            this.dataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dataSource.Location = new System.Drawing.Point(86, 145);
            this.dataSource.MaxLength = 64;
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(284, 31);
            this.dataSource.TabIndex = 26;
            this.dataSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goToSavegoToSave
            // 
            this.goToSavegoToSave.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (184)))), ((int) (((byte) (134)))));
            this.goToSavegoToSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSavegoToSave.FlatAppearance.BorderSize = 0;
            this.goToSavegoToSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSavegoToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.goToSavegoToSave.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSavegoToSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.goToSavegoToSave.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSavegoToSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSavegoToSave.IconSize = 32;
            this.goToSavegoToSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSavegoToSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.goToSavegoToSave.Location = new System.Drawing.Point(71, 465);
            this.goToSavegoToSave.Name = "goToSavegoToSave";
            this.goToSavegoToSave.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToSavegoToSave.Size = new System.Drawing.Size(299, 60);
            this.goToSavegoToSave.TabIndex = 25;
            this.goToSavegoToSave.Text = "Сохранить настройки";
            this.goToSavegoToSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSavegoToSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToSavegoToSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(196, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox1.Location = new System.Drawing.Point(86, 224);
            this.textBox1.MaxLength = 64;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 31);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(176, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Отчество";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox2.Location = new System.Drawing.Point(86, 302);
            this.textBox2.MaxLength = 64;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 31);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(153, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(165, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "00.00.0000";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.ClientSize = new System.Drawing.Size(450, 650);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSource);
            this.Controls.Add(this.goToSavegoToSave);
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataSource;
        private FontAwesome.Sharp.IconButton goToSavegoToSave;

        #endregion
    }
}