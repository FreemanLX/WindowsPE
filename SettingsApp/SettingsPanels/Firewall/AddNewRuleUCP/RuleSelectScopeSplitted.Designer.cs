namespace WindowsPE.Settings.Firewall.AddNewRule
{
    partial class RuleSelectScopeSplitted
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
            this.radioSpecifiedIPAddress = new System.Windows.Forms.RadioButton();
            this.radioIPAddress = new System.Windows.Forms.RadioButton();
            this.InfoText = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioSpecifiedIPAddress
            // 
            this.radioSpecifiedIPAddress.AutoSize = true;
            this.radioSpecifiedIPAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioSpecifiedIPAddress.Location = new System.Drawing.Point(15, 73);
            this.radioSpecifiedIPAddress.Name = "radioSpecifiedIPAddress";
            this.radioSpecifiedIPAddress.Size = new System.Drawing.Size(120, 19);
            this.radioSpecifiedIPAddress.TabIndex = 38;
            this.radioSpecifiedIPAddress.TabStop = true;
            this.radioSpecifiedIPAddress.Text = "These IP adresses:";
            this.radioSpecifiedIPAddress.UseVisualStyleBackColor = true;
            this.radioSpecifiedIPAddress.CheckedChanged += new System.EventHandler(this.radioSpecifiedIPAddress_CheckedChanged);
            // 
            // radioIPAddress
            // 
            this.radioIPAddress.AutoSize = true;
            this.radioIPAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioIPAddress.Location = new System.Drawing.Point(15, 48);
            this.radioIPAddress.Name = "radioIPAddress";
            this.radioIPAddress.Size = new System.Drawing.Size(106, 19);
            this.radioIPAddress.TabIndex = 37;
            this.radioIPAddress.TabStop = true;
            this.radioIPAddress.Text = "Any IP address:";
            this.radioIPAddress.UseVisualStyleBackColor = true;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(12, 9);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(309, 17);
            this.InfoText.TabIndex = 40;
            this.InfoText.Text = "Which local IP addresses does this rules apply to?\r\n";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Enabled = false;
            this.ipAddressTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressTextBox.Location = new System.Drawing.Point(16, 98);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(305, 22);
            this.ipAddressTextBox.TabIndex = 41;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.ipAddressTextBox_TextChanged);
            // 
            // RuleSelectScopeSplitted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.radioSpecifiedIPAddress);
            this.Controls.Add(this.radioIPAddress);
            this.Name = "RuleSelectScopeSplitted";
            this.Size = new System.Drawing.Size(348, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioSpecifiedIPAddress;
        private System.Windows.Forms.RadioButton radioIPAddress;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.TextBox ipAddressTextBox;
    }
}
