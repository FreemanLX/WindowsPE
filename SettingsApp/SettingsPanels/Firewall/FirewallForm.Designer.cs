namespace WindowsPE.Settings
{
    partial class FirewallForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.optionsLayout = new System.Windows.Forms.Panel();
            this.lineDrawing = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.SetFirewallStatus = new System.Windows.Forms.Label();
            this.firewallRefresh = new System.Windows.Forms.Label();
            this.firewallAddNewRule = new System.Windows.Forms.Label();
            this.firewallContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusFirewallLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.optionsLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.optionsLayout, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.firewallContainer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(24, 24, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Windows Defender Firewall";
            // 
            // optionsLayout
            // 
            this.optionsLayout.Controls.Add(this.lineDrawing);
            this.optionsLayout.Controls.Add(this.optionsLabel);
            this.optionsLayout.Controls.Add(this.SetFirewallStatus);
            this.optionsLayout.Controls.Add(this.firewallRefresh);
            this.optionsLayout.Controls.Add(this.firewallAddNewRule);
            this.optionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsLayout.Location = new System.Drawing.Point(3, 335);
            this.optionsLayout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.Size = new System.Drawing.Size(928, 200);
            this.optionsLayout.TabIndex = 2;
            // 
            // lineDrawing
            // 
            this.lineDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineDrawing.Location = new System.Drawing.Point(201, 30);
            this.lineDrawing.Name = "lineDrawing";
            this.lineDrawing.Size = new System.Drawing.Size(500, 2);
            this.lineDrawing.TabIndex = 40;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.optionsLabel.Location = new System.Drawing.Point(26, 20);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(169, 17);
            this.optionsLabel.TabIndex = 41;
            this.optionsLabel.Text = "Change your firewall settings";
            // 
            // SetFirewallStatus
            // 
            this.SetFirewallStatus.AutoSize = true;
            this.SetFirewallStatus.BackColor = System.Drawing.Color.Transparent;
            this.SetFirewallStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetFirewallStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.SetFirewallStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SetFirewallStatus.Location = new System.Drawing.Point(25, 52);
            this.SetFirewallStatus.Name = "SetFirewallStatus";
            this.SetFirewallStatus.Size = new System.Drawing.Size(202, 19);
            this.SetFirewallStatus.TabIndex = 4;
            this.SetFirewallStatus.Text = "Turn Windows Firewall on or off";
            this.SetFirewallStatus.Click += new System.EventHandler(this.SetFirewallStatus_Click_1);
            // 
            // firewallRefresh
            // 
            this.firewallRefresh.AutoSize = true;
            this.firewallRefresh.BackColor = System.Drawing.Color.Transparent;
            this.firewallRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firewallRefresh.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.firewallRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firewallRefresh.Location = new System.Drawing.Point(25, 106);
            this.firewallRefresh.Name = "firewallRefresh";
            this.firewallRefresh.Size = new System.Drawing.Size(159, 19);
            this.firewallRefresh.TabIndex = 3;
            this.firewallRefresh.Text = "Change network settings";
            // 
            // firewallAddNewRule
            // 
            this.firewallAddNewRule.AutoSize = true;
            this.firewallAddNewRule.BackColor = System.Drawing.Color.Transparent;
            this.firewallAddNewRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firewallAddNewRule.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.firewallAddNewRule.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firewallAddNewRule.Location = new System.Drawing.Point(25, 79);
            this.firewallAddNewRule.Name = "firewallAddNewRule";
            this.firewallAddNewRule.Size = new System.Drawing.Size(356, 19);
            this.firewallAddNewRule.TabIndex = 2;
            this.firewallAddNewRule.Text = "Allow a program or add a port through Windows Firewall";
            // 
            // firewallContainer
            // 
            this.firewallContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firewallContainer.Location = new System.Drawing.Point(0, 98);
            this.firewallContainer.Margin = new System.Windows.Forms.Padding(0);
            this.firewallContainer.Name = "firewallContainer";
            this.firewallContainer.Size = new System.Drawing.Size(934, 237);
            this.firewallContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statusFirewallLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 50);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 2);
            this.label2.TabIndex = 38;
            // 
            // statusFirewallLabel
            // 
            this.statusFirewallLabel.AutoSize = true;
            this.statusFirewallLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.statusFirewallLabel.Location = new System.Drawing.Point(26, 33);
            this.statusFirewallLabel.Name = "statusFirewallLabel";
            this.statusFirewallLabel.Size = new System.Drawing.Size(143, 17);
            this.statusFirewallLabel.TabIndex = 37;
            this.statusFirewallLabel.Text = "View your firewall status";
            // 
            // FirewallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FirewallForm";
            this.Size = new System.Drawing.Size(934, 535);
            this.Load += new System.EventHandler(this.FirewallForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.optionsLayout.ResumeLayout(false);
            this.optionsLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel optionsLayout;
        private System.Windows.Forms.Label SetFirewallStatus;
        private System.Windows.Forms.Label firewallRefresh;
        private System.Windows.Forms.Label firewallAddNewRule;
        private System.Windows.Forms.Panel firewallContainer;
        private System.Windows.Forms.Label lineDrawing;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusFirewallLabel;
    }
}
