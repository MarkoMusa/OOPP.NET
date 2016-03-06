namespace Zadatak_02
{
    partial class Z01_Main
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
            this.btnOpen150x150 = new System.Windows.Forms.Button();
            this.btnRedFormOpen = new System.Windows.Forms.Button();
            this.btnControlFalseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen150x150
            // 
            this.btnOpen150x150.Location = new System.Drawing.Point(65, 27);
            this.btnOpen150x150.Name = "btnOpen150x150";
            this.btnOpen150x150.Size = new System.Drawing.Size(115, 23);
            this.btnOpen150x150.TabIndex = 0;
            this.btnOpen150x150.Text = "150x150";
            this.btnOpen150x150.UseVisualStyleBackColor = true;
            this.btnOpen150x150.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRedFormOpen
            // 
            this.btnRedFormOpen.Location = new System.Drawing.Point(65, 56);
            this.btnRedFormOpen.Name = "btnRedFormOpen";
            this.btnRedFormOpen.Size = new System.Drawing.Size(115, 23);
            this.btnRedFormOpen.TabIndex = 1;
            this.btnRedFormOpen.Text = "Open Red Form";
            this.btnRedFormOpen.UseVisualStyleBackColor = true;
            this.btnRedFormOpen.Click += new System.EventHandler(this.btnRedFormOpen_Click);
            // 
            // btnControlFalseForm
            // 
            this.btnControlFalseForm.Location = new System.Drawing.Point(65, 85);
            this.btnControlFalseForm.Name = "btnControlFalseForm";
            this.btnControlFalseForm.Size = new System.Drawing.Size(115, 23);
            this.btnControlFalseForm.TabIndex = 2;
            this.btnControlFalseForm.Text = "Non Control Form";
            this.btnControlFalseForm.UseVisualStyleBackColor = true;
            this.btnControlFalseForm.Click += new System.EventHandler(this.btnControlFalseForm_Click);
            // 
            // Z01_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnControlFalseForm);
            this.Controls.Add(this.btnRedFormOpen);
            this.Controls.Add(this.btnOpen150x150);
            this.Name = "Z01_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen150x150;
        private System.Windows.Forms.Button btnRedFormOpen;
        private System.Windows.Forms.Button btnControlFalseForm;
    }
}

