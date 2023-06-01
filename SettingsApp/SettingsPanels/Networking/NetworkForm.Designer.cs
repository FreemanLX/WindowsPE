namespace WindowsPE
{
    partial class NetworkForm
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
            this.networkSettingsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.privateNetworkLayout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.activeNetworksLabel = new System.Windows.Forms.Label();
            this.titleHeader = new System.Windows.Forms.Label();
            this.bottomContainer = new System.Windows.Forms.Panel();
            this.lineDrawing = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.firewallSettings = new System.Windows.Forms.Label();
            this.filesharingSettings = new System.Windows.Forms.Label();
            this.setNetworkLabel = new System.Windows.Forms.Label();
            this.networkSettingsLayout.SuspendLayout();
            this.privateNetworkLayout.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // networkSettingsLayout
            // 
            this.networkSettingsLayout.BackColor = System.Drawing.Color.Transparent;
            this.networkSettingsLayout.ColumnCount = 1;
            this.networkSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.networkSettingsLayout.Controls.Add(this.privateNetworkLayout, 0, 1);
            this.networkSettingsLayout.Controls.Add(this.titleHeader, 0, 0);
            this.networkSettingsLayout.Controls.Add(this.bottomContainer, 0, 2);
            this.networkSettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkSettingsLayout.Location = new System.Drawing.Point(0, 0);
            this.networkSettingsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.networkSettingsLayout.Name = "networkSettingsLayout";
            this.networkSettingsLayout.RowCount = 3;
            this.networkSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.networkSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.networkSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.networkSettingsLayout.Size = new System.Drawing.Size(934, 535);
            this.networkSettingsLayout.TabIndex = 0;
            // 
            // privateNetworkLayout
            // 
            this.privateNetworkLayout.AutoScroll = true;
            this.privateNetworkLayout.Controls.Add(this.label1);
            this.privateNetworkLayout.Controls.Add(this.activeNetworksLabel);
            this.privateNetworkLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.privateNetworkLayout.Location = new System.Drawing.Point(0, 48);
            this.privateNetworkLayout.Margin = new System.Windows.Forms.Padding(0);
            this.privateNetworkLayout.Name = "privateNetworkLayout";
            this.privateNetworkLayout.Size = new System.Drawing.Size(934, 287);
            this.privateNetworkLayout.TabIndex = 0;
            this.privateNetworkLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.privateNetworkLayout_Paint);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 2);
            this.label1.TabIndex = 34;
            // 
            // activeNetworksLabel
            // 
            this.activeNetworksLabel.AutoSize = true;
            this.activeNetworksLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.activeNetworksLabel.Location = new System.Drawing.Point(26, 20);
            this.activeNetworksLabel.Name = "activeNetworksLabel";
            this.activeNetworksLabel.Size = new System.Drawing.Size(153, 17);
            this.activeNetworksLabel.TabIndex = 32;
            this.activeNetworksLabel.Text = "View your active networks";
            // 
            // titleHeader
            // 
            this.titleHeader.AutoSize = true;
            this.titleHeader.BackColor = System.Drawing.Color.White;
            this.titleHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.titleHeader.Location = new System.Drawing.Point(24, 24);
            this.titleHeader.Margin = new System.Windows.Forms.Padding(24, 24, 3, 0);
            this.titleHeader.Name = "titleHeader";
            this.titleHeader.Size = new System.Drawing.Size(242, 24);
            this.titleHeader.TabIndex = 31;
            this.titleHeader.Text = "Network and Sharing Center";
            // 
            // bottomContainer
            // 
            this.bottomContainer.Controls.Add(this.lineDrawing);
            this.bottomContainer.Controls.Add(this.optionsLabel);
            this.bottomContainer.Controls.Add(this.firewallSettings);
            this.bottomContainer.Controls.Add(this.filesharingSettings);
            this.bottomContainer.Controls.Add(this.setNetworkLabel);
            this.bottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomContainer.Location = new System.Drawing.Point(3, 338);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(928, 194);
            this.bottomContainer.TabIndex = 32;
            // 
            // lineDrawing
            // 
            this.lineDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineDrawing.Location = new System.Drawing.Point(205, 30);
            this.lineDrawing.Name = "lineDrawing";
            this.lineDrawing.Size = new System.Drawing.Size(500, 2);
            this.lineDrawing.TabIndex = 33;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.optionsLabel.Location = new System.Drawing.Point(26, 20);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(173, 17);
            this.optionsLabel.TabIndex = 39;
            this.optionsLabel.Text = "Change your network settings";
            // 
            // firewallSettings
            // 
            this.firewallSettings.AutoSize = true;
            this.firewallSettings.BackColor = System.Drawing.Color.Transparent;
            this.firewallSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firewallSettings.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firewallSettings.Location = new System.Drawing.Point(26, 106);
            this.firewallSettings.Name = "firewallSettings";
            this.firewallSettings.Size = new System.Drawing.Size(141, 17);
            this.firewallSettings.TabIndex = 38;
            this.firewallSettings.Text = "Change firewall settings";
            this.firewallSettings.Click += new System.EventHandler(this.firewallSettings_Click);
            // 
            // filesharingSettings
            // 
            this.filesharingSettings.AutoSize = true;
            this.filesharingSettings.BackColor = System.Drawing.Color.Transparent;
            this.filesharingSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesharingSettings.ForeColor = System.Drawing.SystemColors.Highlight;
            this.filesharingSettings.Location = new System.Drawing.Point(26, 79);
            this.filesharingSettings.Name = "filesharingSettings";
            this.filesharingSettings.Size = new System.Drawing.Size(158, 17);
            this.filesharingSettings.TabIndex = 37;
            this.filesharingSettings.Text = "Change filesharing settings";
            this.filesharingSettings.Click += new System.EventHandler(this.filesharingSettings_Click);
            // 
            // setNetworkLabel
            // 
            this.setNetworkLabel.AutoSize = true;
            this.setNetworkLabel.BackColor = System.Drawing.Color.Transparent;
            this.setNetworkLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNetworkLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.setNetworkLabel.Location = new System.Drawing.Point(26, 52);
            this.setNetworkLabel.Name = "setNetworkLabel";
            this.setNetworkLabel.Size = new System.Drawing.Size(263, 17);
            this.setNetworkLabel.TabIndex = 36;
            this.setNetworkLabel.Text = "Setup a new connection or change ip address";
            this.setNetworkLabel.Click += new System.EventHandler(this.setNetworkLabel_Click);
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.networkSettingsLayout);
            this.Name = "NetworkForm";
            this.Size = new System.Drawing.Size(934, 535);
            this.Load += new System.EventHandler(this.networking_Load);
            this.networkSettingsLayout.ResumeLayout(false);
            this.networkSettingsLayout.PerformLayout();
            this.privateNetworkLayout.ResumeLayout(false);
            this.privateNetworkLayout.PerformLayout();
            this.bottomContainer.ResumeLayout(false);
            this.bottomContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel networkSettingsLayout;
        private System.Windows.Forms.Panel privateNetworkLayout;
        private System.Windows.Forms.Label activeNetworksLabel;
        private System.Windows.Forms.Label titleHeader;
        private System.Windows.Forms.Panel bottomContainer;
        private System.Windows.Forms.Label firewallSettings;
        private System.Windows.Forms.Label filesharingSettings;
        private System.Windows.Forms.Label setNetworkLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label lineDrawing;
        private System.Windows.Forms.Label label1;
    }
}
