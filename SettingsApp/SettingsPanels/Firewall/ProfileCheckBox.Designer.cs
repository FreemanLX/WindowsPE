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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableRadioBtn
            // 
            this.enableRadioBtn.AutoSize = true;
            this.enableRadioBtn.Checked = true;
            this.enableRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableRadioBtn.Location = new System.Drawing.Point(88, 39);
            this.enableRadioBtn.Name = "enableRadioBtn";
            this.enableRadioBtn.Size = new System.Drawing.Size(213, 19);
            this.enableRadioBtn.TabIndex = 0;
            this.enableRadioBtn.TabStop = true;
            this.enableRadioBtn.Text = "Turn on Windows Defender Firewall";
            this.enableRadioBtn.UseVisualStyleBackColor = true;
            this.enableRadioBtn.CheckedChanged += new System.EventHandler(this.enableRadioBtn_CheckedChanged);
            // 
            // disableRadioBtn
            // 
            this.disableRadioBtn.AutoSize = true;
            this.disableRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.disableRadioBtn.Location = new System.Drawing.Point(88, 64);
            this.disableRadioBtn.Name = "disableRadioBtn";
            this.disableRadioBtn.Size = new System.Drawing.Size(324, 19);
            this.disableRadioBtn.TabIndex = 1;
            this.disableRadioBtn.Text = "Turn off Windows Defender Firewall (not recommended)";
            this.disableRadioBtn.UseVisualStyleBackColor = true;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InfoText.Location = new System.Drawing.Point(22, 12);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(61, 15);
            this.InfoText.TabIndex = 9;
            this.InfoText.Text = "%profile%";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 2);
            this.label2.TabIndex = 37;
            // 
            // ProfileCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.disableRadioBtn);
            this.Controls.Add(this.enableRadioBtn);
            this.Name = "ProfileCheckBox";
            this.Size = new System.Drawing.Size(700, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton enableRadioBtn;
        private System.Windows.Forms.RadioButton disableRadioBtn;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label label2;
    }
}
