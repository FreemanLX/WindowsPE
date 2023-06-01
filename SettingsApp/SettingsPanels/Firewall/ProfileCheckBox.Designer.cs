namespace WindowsPE
{
    partial class ProfileCheckBox
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
            this.enableRadioBtn = new System.Windows.Forms.RadioButton();
            this.disableRadioBtn = new System.Windows.Forms.RadioButton();
            this.InfoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableRadioBtn
            // 
            this.enableRadioBtn.AutoSize = true;
            this.enableRadioBtn.Checked = true;
            this.enableRadioBtn.Location = new System.Drawing.Point(17, 42);
            this.enableRadioBtn.Name = "enableRadioBtn";
            this.enableRadioBtn.Size = new System.Drawing.Size(58, 17);
            this.enableRadioBtn.TabIndex = 0;
            this.enableRadioBtn.TabStop = true;
            this.enableRadioBtn.Text = "Enable";
            this.enableRadioBtn.UseVisualStyleBackColor = true;
            this.enableRadioBtn.CheckedChanged += new System.EventHandler(this.enableRadioBtn_CheckedChanged);
            // 
            // disableRadioBtn
            // 
            this.disableRadioBtn.AutoSize = true;
            this.disableRadioBtn.Location = new System.Drawing.Point(17, 65);
            this.disableRadioBtn.Name = "disableRadioBtn";
            this.disableRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.disableRadioBtn.TabIndex = 1;
            this.disableRadioBtn.Text = "Disable";
            this.disableRadioBtn.UseVisualStyleBackColor = true;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(13, 10);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(69, 19);
            this.InfoText.TabIndex = 9;
            this.InfoText.Text = "%profile%";
            // 
            // ProfileCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.disableRadioBtn);
            this.Controls.Add(this.enableRadioBtn);
            this.Name = "ProfileCheckBox";
            this.Size = new System.Drawing.Size(218, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton enableRadioBtn;
        private System.Windows.Forms.RadioButton disableRadioBtn;
        private System.Windows.Forms.Label InfoText;
    }
}
