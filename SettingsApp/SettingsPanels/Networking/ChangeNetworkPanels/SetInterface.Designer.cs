namespace WindowsPE.Settings.Networking.ChangeNetworkPanels
{
    partial class SetInterface
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
            this.connectionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.connectionTypeLabel = new System.Windows.Forms.Label();
            this.interfaceComboBox = new System.Windows.Forms.ComboBox();
            this.interfaceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionTypeComboBox
            // 
            this.connectionTypeComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.connectionTypeComboBox.FormattingEnabled = true;
            this.connectionTypeComboBox.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.connectionTypeComboBox.Location = new System.Drawing.Point(23, 120);
            this.connectionTypeComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.connectionTypeComboBox.Name = "connectionTypeComboBox";
            this.connectionTypeComboBox.Size = new System.Drawing.Size(284, 25);
            this.connectionTypeComboBox.TabIndex = 16;
            this.connectionTypeComboBox.Text = "IPv4";
            this.connectionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.connectionTypeComboBox_SelectedIndexChanged);
            // 
            // connectionTypeLabel
            // 
            this.connectionTypeLabel.AutoSize = true;
            this.connectionTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.connectionTypeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectionTypeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.connectionTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectionTypeLabel.Location = new System.Drawing.Point(19, 90);
            this.connectionTypeLabel.Name = "connectionTypeLabel";
            this.connectionTypeLabel.Size = new System.Drawing.Size(244, 19);
            this.connectionTypeLabel.TabIndex = 15;
            this.connectionTypeLabel.Text = "Select the connection type - IPv4 / IPv6";
            // 
            // interfaceComboBox
            // 
            this.interfaceComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.interfaceComboBox.FormattingEnabled = true;
            this.interfaceComboBox.Location = new System.Drawing.Point(23, 47);
            this.interfaceComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.interfaceComboBox.Name = "interfaceComboBox";
            this.interfaceComboBox.Size = new System.Drawing.Size(284, 25);
            this.interfaceComboBox.TabIndex = 14;
            this.interfaceComboBox.Text = "Network Interface";
            this.interfaceComboBox.SelectedIndexChanged += new System.EventHandler(this.interfaceComboBox_SelectedIndexChanged);
            // 
            // interfaceText
            // 
            this.interfaceText.AutoSize = true;
            this.interfaceText.BackColor = System.Drawing.Color.Transparent;
            this.interfaceText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interfaceText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.interfaceText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.interfaceText.Location = new System.Drawing.Point(19, 17);
            this.interfaceText.Name = "interfaceText";
            this.interfaceText.Size = new System.Drawing.Size(288, 19);
            this.interfaceText.TabIndex = 13;
            this.interfaceText.Text = "Please select accordingly the network interface";
            // 
            // SetInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.connectionTypeComboBox);
            this.Controls.Add(this.connectionTypeLabel);
            this.Controls.Add(this.interfaceComboBox);
            this.Controls.Add(this.interfaceText);
            this.Name = "SetInterface";
            this.Size = new System.Drawing.Size(578, 325);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox connectionTypeComboBox;
        private System.Windows.Forms.Label connectionTypeLabel;
        private System.Windows.Forms.ComboBox interfaceComboBox;
        private System.Windows.Forms.Label interfaceText;
    }
}
