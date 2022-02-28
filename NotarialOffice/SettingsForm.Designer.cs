using System.ComponentModel;

namespace NotarialOffice
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.goToSetSettings = new FontAwesome.Sharp.IconButton();
            this.initialCatalog = new System.Windows.Forms.TextBox();
            this.dataSource = new System.Windows.Forms.TextBox();
            this.goToSavegoToSave = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goToSetSettings
            // 
            this.goToSetSettings.BackColor = System.Drawing.Color.Transparent;
            this.goToSetSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSetSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.goToSetSettings, "goToSetSettings");
            this.goToSetSettings.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSetSettings.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.goToSetSettings.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSetSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSetSettings.IconSize = 32;
            this.goToSetSettings.Name = "goToSetSettings";
            this.mainToolTip.SetToolTip(this.goToSetSettings, resources.GetString("goToSetSettings.ToolTip"));
            this.goToSetSettings.UseVisualStyleBackColor = false;
            this.goToSetSettings.Click += new System.EventHandler(this.goToSetSettings_Click);
            // 
            // initialCatalog
            // 
            this.initialCatalog.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.initialCatalog, "initialCatalog");
            this.initialCatalog.Name = "initialCatalog";
            this.mainToolTip.SetToolTip(this.initialCatalog, resources.GetString("initialCatalog.ToolTip"));
            // 
            // dataSource
            // 
            this.dataSource.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.dataSource, "dataSource");
            this.dataSource.Name = "dataSource";
            this.mainToolTip.SetToolTip(this.dataSource, resources.GetString("dataSource.ToolTip"));
            // 
            // goToSavegoToSave
            // 
            this.goToSavegoToSave.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (184)))), ((int) (((byte) (134)))));
            this.goToSavegoToSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSavegoToSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.goToSavegoToSave, "goToSavegoToSave");
            this.goToSavegoToSave.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSavegoToSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.goToSavegoToSave.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.goToSavegoToSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSavegoToSave.IconSize = 32;
            this.goToSavegoToSave.Name = "goToSavegoToSave";
            this.mainToolTip.SetToolTip(this.goToSavegoToSave, resources.GetString("goToSavegoToSave.ToolTip"));
            this.goToSavegoToSave.UseVisualStyleBackColor = false;
            this.goToSavegoToSave.Click += new System.EventHandler(this.goToSave_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.label1.Name = "label1";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (200)))), ((int) (((byte) (172)))));
            this.Controls.Add(this.goToSetSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialCatalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSource);
            this.Controls.Add(this.goToSavegoToSave);
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (54)))), ((int) (((byte) (32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private FontAwesome.Sharp.IconButton goToSetSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initialCatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataSource;
        private FontAwesome.Sharp.IconButton goToSavegoToSave;

        private System.Windows.Forms.ToolTip mainToolTip;

        #endregion
    }
}