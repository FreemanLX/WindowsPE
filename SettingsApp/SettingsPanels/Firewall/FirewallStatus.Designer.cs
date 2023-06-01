namespace WindowsPE.Settings.Firewall
{
    partial class FirewallStatus
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorFirewall = new System.Windows.Forms.Panel();
            this.firewallStatusContainer = new System.Windows.Forms.Panel();
            this.firewallType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.firewallStatusContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.colorFirewall, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.firewallStatusContainer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // colorFirewall
            // 
            this.colorFirewall.BackColor = System.Drawing.Color.LimeGreen;
            this.colorFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorFirewall.Location = new System.Drawing.Point(0, 0);
            this.colorFirewall.Margin = new System.Windows.Forms.Padding(0);
            this.colorFirewall.Name = "colorFirewall";
            this.colorFirewall.Size = new System.Drawing.Size(26, 40);
            this.colorFirewall.TabIndex = 0;
            // 
            // firewallStatusContainer
            // 
            this.firewallStatusContainer.Controls.Add(this.firewallType);
            this.firewallStatusContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firewallStatusContainer.Location = new System.Drawing.Point(26, 0);
            this.firewallStatusContainer.Margin = new System.Windows.Forms.Padding(0);
            this.firewallStatusContainer.Name = "firewallStatusContainer";
            this.firewallStatusContainer.Size = new System.Drawing.Size(255, 40);
            this.firewallStatusContainer.TabIndex = 1;
            // 
            // firewallType
            // 
            this.firewallType.AutoSize = true;
            this.firewallType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.firewallType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firewallType.Location = new System.Drawing.Point(14, 9);
            this.firewallType.Name = "firewallType";
            this.firewallType.Size = new System.Drawing.Size(116, 21);
            this.firewallType.TabIndex = 0;
            this.firewallType.Text = "%firewallType%";
            // 
            // FirewallStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FirewallStatus";
            this.Size = new System.Drawing.Size(671, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.firewallStatusContainer.ResumeLayout(false);
            this.firewallStatusContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel colorFirewall;
        private System.Windows.Forms.Panel firewallStatusContainer;
        private System.Windows.Forms.Label firewallType;
    }
}
