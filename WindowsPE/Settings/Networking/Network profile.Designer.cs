namespace WindowsPE.Settings.Networking
{
    partial class Network_profile
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
            this.ethernetAdapterLabel = new System.Windows.Forms.Label();
            this.physicalAddressLabel = new System.Windows.Forms.Label();
            this.dhcpLabel = new System.Windows.Forms.Label();
            this.gatewayLabel = new System.Windows.Forms.Label();
            this.dnsServersLabel = new System.Windows.Forms.Label();
            this.ipAddressesLabel = new System.Windows.Forms.Label();
            this.subnetMaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ethernetAdapterLabel
            // 
            this.ethernetAdapterLabel.AutoSize = true;
            this.ethernetAdapterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.ethernetAdapterLabel.Location = new System.Drawing.Point(0, 11);
            this.ethernetAdapterLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ethernetAdapterLabel.Name = "ethernetAdapterLabel";
            this.ethernetAdapterLabel.Size = new System.Drawing.Size(151, 25);
            this.ethernetAdapterLabel.TabIndex = 14;
            this.ethernetAdapterLabel.Text = "Ethernet adapter: ";
            // 
            // physicalAddressLabel
            // 
            this.physicalAddressLabel.AutoSize = true;
            this.physicalAddressLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.physicalAddressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.physicalAddressLabel.Location = new System.Drawing.Point(3, 56);
            this.physicalAddressLabel.Name = "physicalAddressLabel";
            this.physicalAddressLabel.Size = new System.Drawing.Size(117, 19);
            this.physicalAddressLabel.TabIndex = 15;
            this.physicalAddressLabel.Text = "Physical Address: ";
            // 
            // dhcpLabel
            // 
            this.dhcpLabel.AutoSize = true;
            this.dhcpLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.dhcpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dhcpLabel.Location = new System.Drawing.Point(3, 86);
            this.dhcpLabel.Name = "dhcpLabel";
            this.dhcpLabel.Size = new System.Drawing.Size(105, 19);
            this.dhcpLabel.TabIndex = 16;
            this.dhcpLabel.Text = "DHCP Enabled: ";
            // 
            // gatewayLabel
            // 
            this.gatewayLabel.AutoSize = true;
            this.gatewayLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.gatewayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gatewayLabel.Location = new System.Drawing.Point(5, 146);
            this.gatewayLabel.Name = "gatewayLabel";
            this.gatewayLabel.Size = new System.Drawing.Size(78, 19);
            this.gatewayLabel.TabIndex = 17;
            this.gatewayLabel.Text = "IP Gateway:";
            // 
            // dnsServersLabel
            // 
            this.dnsServersLabel.AutoSize = true;
            this.dnsServersLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.dnsServersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dnsServersLabel.Location = new System.Drawing.Point(3, 206);
            this.dnsServersLabel.Name = "dnsServersLabel";
            this.dnsServersLabel.Size = new System.Drawing.Size(88, 19);
            this.dnsServersLabel.TabIndex = 18;
            this.dnsServersLabel.Text = "DNS Servers:";
            // 
            // ipAddressesLabel
            // 
            this.ipAddressesLabel.AutoSize = true;
            this.ipAddressesLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.ipAddressesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ipAddressesLabel.Location = new System.Drawing.Point(5, 116);
            this.ipAddressesLabel.Name = "ipAddressesLabel";
            this.ipAddressesLabel.Size = new System.Drawing.Size(76, 19);
            this.ipAddressesLabel.TabIndex = 19;
            this.ipAddressesLabel.Text = "IP Address:";
            // 
            // subnetMaskLabel
            // 
            this.subnetMaskLabel.AutoSize = true;
            this.subnetMaskLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.subnetMaskLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subnetMaskLabel.Location = new System.Drawing.Point(3, 176);
            this.subnetMaskLabel.Name = "subnetMaskLabel";
            this.subnetMaskLabel.Size = new System.Drawing.Size(95, 19);
            this.subnetMaskLabel.TabIndex = 20;
            this.subnetMaskLabel.Text = "Subnet mask: ";
            // 
            // Network_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subnetMaskLabel);
            this.Controls.Add(this.ipAddressesLabel);
            this.Controls.Add(this.dnsServersLabel);
            this.Controls.Add(this.gatewayLabel);
            this.Controls.Add(this.dhcpLabel);
            this.Controls.Add(this.physicalAddressLabel);
            this.Controls.Add(this.ethernetAdapterLabel);
            this.Name = "Network_profile";
            this.Size = new System.Drawing.Size(634, 274);
            this.Load += new System.EventHandler(this.Network_profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ethernetAdapterLabel;
        private System.Windows.Forms.Label physicalAddressLabel;
        private System.Windows.Forms.Label dhcpLabel;
        private System.Windows.Forms.Label gatewayLabel;
        private System.Windows.Forms.Label dnsServersLabel;
        private System.Windows.Forms.Label ipAddressesLabel;
        private System.Windows.Forms.Label subnetMaskLabel;
    }
}
