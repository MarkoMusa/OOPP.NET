namespace Zadatak05
{
    partial class frmZ05
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
            this.btnShowHideInTaskbar = new System.Windows.Forms.Button();
            this.btnTopToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowHideInTaskbar
            // 
            this.btnShowHideInTaskbar.Location = new System.Drawing.Point(23, 12);
            this.btnShowHideInTaskbar.Name = "btnShowHideInTaskbar";
            this.btnShowHideInTaskbar.Size = new System.Drawing.Size(157, 23);
            this.btnShowHideInTaskbar.TabIndex = 0;
            this.btnShowHideInTaskbar.Text = "Hide From Taskbar";
            this.btnShowHideInTaskbar.UseVisualStyleBackColor = true;
            this.btnShowHideInTaskbar.Click += new System.EventHandler(this.btnShowHideInTaskbar_Click);
            // 
            // btnTopToggle
            // 
            this.btnTopToggle.Location = new System.Drawing.Point(23, 41);
            this.btnTopToggle.Name = "btnTopToggle";
            this.btnTopToggle.Size = new System.Drawing.Size(157, 24);
            this.btnTopToggle.TabIndex = 1;
            this.btnTopToggle.Text = "Show on top";
            this.btnTopToggle.UseVisualStyleBackColor = true;
            this.btnTopToggle.Click += new System.EventHandler(this.btnTopToggle_Click);
            // 
            // frmZ05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTopToggle);
            this.Controls.Add(this.btnShowHideInTaskbar);
            this.Name = "frmZ05";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowHideInTaskbar;
        private System.Windows.Forms.Button btnTopToggle;
    }
}

