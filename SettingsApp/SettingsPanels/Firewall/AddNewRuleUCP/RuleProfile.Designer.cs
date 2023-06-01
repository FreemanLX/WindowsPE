namespace WindowsPE.Settings.Firewall.AddNewRule
{
    partial class RuleProfile
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
            this.InfoText = new System.Windows.Forms.Label();
            this.privateCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publicCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(15, 16);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(172, 19);
            this.InfoText.TabIndex = 12;
            this.InfoText.Text = "When does this rule apply?";
            // 
            // privateCheckBox
            // 
            this.privateCheckBox.AutoSize = true;
            this.privateCheckBox.Checked = true;
            this.privateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.privateCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateCheckBox.Location = new System.Drawing.Point(19, 51);
            this.privateCheckBox.Name = "privateCheckBox";
            this.privateCheckBox.Size = new System.Drawing.Size(61, 17);
            this.privateCheckBox.TabIndex = 13;
            this.privateCheckBox.Text = "Private";
            this.privateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Applies when a computer is connected to local network, such as work or home place" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Applies when a computer is connected to public network location.";
            // 
            // publicCheckBox
            // 
            this.publicCheckBox.AutoSize = true;
            this.publicCheckBox.Checked = true;
            this.publicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.publicCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicCheckBox.Location = new System.Drawing.Point(19, 105);
            this.publicCheckBox.Name = "publicCheckBox";
            this.publicCheckBox.Size = new System.Drawing.Size(56, 17);
            this.publicCheckBox.TabIndex = 17;
            this.publicCheckBox.Text = "Public";
            this.publicCheckBox.UseVisualStyleBackColor = true;
            // 
            // RuleProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.publicCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateCheckBox);
            this.Controls.Add(this.InfoText);
            this.Name = "RuleProfile";
            this.Size = new System.Drawing.Size(470, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.CheckBox privateCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox publicCheckBox;
    }
}
