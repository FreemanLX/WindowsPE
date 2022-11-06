namespace WindowsPE
{
    partial class ApplicationLetter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applicationName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.applicationName.ForeColor = System.Drawing.Color.White;
            this.applicationName.Location = new System.Drawing.Point(0, 5);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(18, 19);
            this.applicationName.TabIndex = 2;
            this.applicationName.Text = "A";
            this.applicationName.Click += new System.EventHandler(this.applicationName_Click);
            // 
            // ApplicationLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.applicationName);
            this.Name = "ApplicationLetter";
            this.Size = new System.Drawing.Size(351, 35);
            this.Load += new System.EventHandler(this.Application_Letter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applicationName;
    }
}
