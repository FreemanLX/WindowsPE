namespace SettingsApp.SettingsPanels.Networking
{
    partial class NetworkObject
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
            this.networkTypeLabel = new System.Windows.Forms.Label();
            this.networkDNS = new System.Windows.Forms.Label();
            this.accessTypeLabel = new System.Windows.Forms.Label();
            this.verticalLine = new System.Windows.Forms.Label();
            this.connectionTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // networkTypeLabel
            // 
            this.networkTypeLabel.AutoSize = true;
            this.networkTypeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.networkTypeLabel.Location = new System.Drawing.Point(17, 42);
            this.networkTypeLabel.Name = "networkTypeLabel";
            this.networkTypeLabel.Size = new System.Drawing.Size(90, 15);
            this.networkTypeLabel.TabIndex = 39;
            this.networkTypeLabel.Text = "Private Network";
            // 
            // networkDNS
            // 
            this.networkDNS.AutoSize = true;
            this.networkDNS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkDNS.Location = new System.Drawing.Point(17, 16);
            this.networkDNS.Name = "networkDNS";
            this.networkDNS.Size = new System.Drawing.Size(106, 17);
            this.networkDNS.TabIndex = 38;
            this.networkDNS.Text = "%networkDNS%";
            // 
            // accessTypeLabel
            // 
            this.accessTypeLabel.AutoSize = true;
            this.accessTypeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.accessTypeLabel.Location = new System.Drawing.Point(314, 18);
            this.accessTypeLabel.Name = "accessTypeLabel";
            this.accessTypeLabel.Size = new System.Drawing.Size(135, 15);
            this.accessTypeLabel.TabIndex = 40;
            this.accessTypeLabel.Text = "Access Type: %internet%";
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.Color.Transparent;
            this.verticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine.Location = new System.Drawing.Point(299, 15);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(2, 45);
            this.verticalLine.TabIndex = 41;
            this.verticalLine.Text = "label1";
            // 
            // connectionTypeLabel
            // 
            this.connectionTypeLabel.AutoSize = true;
            this.connectionTypeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.connectionTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectionTypeLabel.Location = new System.Drawing.Point(314, 42);
            this.connectionTypeLabel.Name = "connectionTypeLabel";
            this.connectionTypeLabel.Size = new System.Drawing.Size(122, 15);
            this.connectionTypeLabel.TabIndex = 42;
            this.connectionTypeLabel.Text = "Connections: Ethernet";
            // 
            // NetworkObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.connectionTypeLabel);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.accessTypeLabel);
            this.Controls.Add(this.networkTypeLabel);
            this.Controls.Add(this.networkDNS);
            this.Name = "NetworkObject";
            this.Size = new System.Drawing.Size(482, 72);
            this.Load += new System.EventHandler(this.NetworkObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label networkTypeLabel;
        private System.Windows.Forms.Label networkDNS;
        private System.Windows.Forms.Label accessTypeLabel;
        private System.Windows.Forms.Label verticalLine;
        private System.Windows.Forms.Label connectionTypeLabel;
    }
}
