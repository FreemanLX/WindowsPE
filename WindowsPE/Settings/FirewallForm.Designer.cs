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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firewallNameLabel = new System.Windows.Forms.Label();
            this.firewallContent = new System.Windows.Forms.TableLayoutPanel();
            this.outboundRules = new System.Windows.Forms.TableLayoutPanel();
            this.dataOutboundFirewall = new System.Windows.Forms.DataGridView();
            this.NameD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnabledD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoteAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemotePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outboundTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.inboundRules = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inboundTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.firewallContent.SuspendLayout();
            this.outboundRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutboundFirewall)).BeginInit();
            this.outboundTitle.SuspendLayout();
            this.inboundRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.firewallContent, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.firewallNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 69);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // firewallNameLabel
            // 
            this.firewallNameLabel.AutoSize = true;
            this.firewallNameLabel.BackColor = System.Drawing.Color.White;
            this.firewallNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firewallNameLabel.ForeColor = System.Drawing.Color.Black;
            this.firewallNameLabel.Location = new System.Drawing.Point(22, 17);
            this.firewallNameLabel.Name = "firewallNameLabel";
            this.firewallNameLabel.Size = new System.Drawing.Size(104, 37);
            this.firewallNameLabel.TabIndex = 4;
            this.firewallNameLabel.Text = "Firewall";
            // 
            // firewallContent
            // 
            this.firewallContent.ColumnCount = 1;
            this.firewallContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.firewallContent.Controls.Add(this.outboundRules, 0, 1);
            this.firewallContent.Controls.Add(this.inboundRules, 0, 0);
            this.firewallContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firewallContent.Location = new System.Drawing.Point(3, 78);
            this.firewallContent.Name = "firewallContent";
            this.firewallContent.RowCount = 2;
            this.firewallContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.firewallContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.firewallContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.firewallContent.Size = new System.Drawing.Size(928, 454);
            this.firewallContent.TabIndex = 0;
            // 
            // outboundRules
            // 
            this.outboundRules.ColumnCount = 1;
            this.outboundRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outboundRules.Controls.Add(this.dataOutboundFirewall, 0, 1);
            this.outboundRules.Controls.Add(this.outboundTitle, 0, 0);
            this.outboundRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outboundRules.Location = new System.Drawing.Point(3, 230);
            this.outboundRules.Name = "outboundRules";
            this.outboundRules.RowCount = 2;
            this.outboundRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.outboundRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outboundRules.Size = new System.Drawing.Size(922, 221);
            this.outboundRules.TabIndex = 2;
            // 
            // dataOutboundFirewall
            // 
            this.dataOutboundFirewall.AllowUserToAddRows = false;
            this.dataOutboundFirewall.AllowUserToDeleteRows = false;
            this.dataOutboundFirewall.AllowUserToResizeColumns = false;
            this.dataOutboundFirewall.AllowUserToResizeRows = false;
            this.dataOutboundFirewall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOutboundFirewall.BackgroundColor = System.Drawing.Color.White;
            this.dataOutboundFirewall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOutboundFirewall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOutboundFirewall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutboundFirewall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameD,
            this.Profile,
            this.EnabledD,
            this.Action,
            this.Program,
            this.LocalAddress,
            this.RemoteAddress,
            this._Protocol,
            this.LocalPort,
            this.RemotePort});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOutboundFirewall.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataOutboundFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOutboundFirewall.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataOutboundFirewall.GridColor = System.Drawing.Color.White;
            this.dataOutboundFirewall.Location = new System.Drawing.Point(28, 43);
            this.dataOutboundFirewall.Margin = new System.Windows.Forms.Padding(28, 3, 10, 3);
            this.dataOutboundFirewall.MultiSelect = false;
            this.dataOutboundFirewall.Name = "dataOutboundFirewall";
            this.dataOutboundFirewall.ReadOnly = true;
            this.dataOutboundFirewall.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOutboundFirewall.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataOutboundFirewall.RowHeadersVisible = false;
            this.dataOutboundFirewall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOutboundFirewall.ShowCellErrors = false;
            this.dataOutboundFirewall.ShowCellToolTips = false;
            this.dataOutboundFirewall.ShowEditingIcon = false;
            this.dataOutboundFirewall.ShowRowErrors = false;
            this.dataOutboundFirewall.Size = new System.Drawing.Size(884, 175);
            this.dataOutboundFirewall.TabIndex = 2;
            // 
            // Name
            // 
            this.NameD.HeaderText = "Name";
            this.NameD.Name = "Name";
            this.NameD.ReadOnly = true;
            // 
            // Profile
            // 
            this.Profile.HeaderText = "Profile";
            this.Profile.Name = "Profile";
            this.Profile.ReadOnly = true;
            // 
            // Enabled
            // 
            this.EnabledD.HeaderText = "Enabled";
            this.EnabledD.Name = "Enabled";
            this.EnabledD.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // Program
            // 
            this.Program.HeaderText = "Program";
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            // 
            // LocalAddress
            // 
            this.LocalAddress.HeaderText = "Local Address";
            this.LocalAddress.Name = "LocalAddress";
            this.LocalAddress.ReadOnly = true;
            // 
            // RemoteAddress
            // 
            this.RemoteAddress.HeaderText = "Remote Address";
            this.RemoteAddress.Name = "RemoteAddress";
            this.RemoteAddress.ReadOnly = true;
            // 
            // _Protocol
            // 
            this._Protocol.HeaderText = "Protocol";
            this._Protocol.Name = "_Protocol";
            this._Protocol.ReadOnly = true;
            // 
            // LocalPort
            // 
            this.LocalPort.HeaderText = "Local Port";
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.ReadOnly = true;
            // 
            // RemotePort
            // 
            this.RemotePort.HeaderText = "Remote Port";
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.ReadOnly = true;
            // 
            // outboundTitle
            // 
            this.outboundTitle.Controls.Add(this.label2);
            this.outboundTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outboundTitle.Location = new System.Drawing.Point(0, 0);
            this.outboundTitle.Margin = new System.Windows.Forms.Padding(0);
            this.outboundTitle.Name = "outboundTitle";
            this.outboundTitle.Size = new System.Drawing.Size(922, 40);
            this.outboundTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Outbound rules";
            // 
            // inboundRules
            // 
            this.inboundRules.ColumnCount = 1;
            this.inboundRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inboundRules.Controls.Add(this.dataGridView2, 0, 1);
            this.inboundRules.Controls.Add(this.panel2, 0, 0);
            this.inboundRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboundRules.Location = new System.Drawing.Point(3, 3);
            this.inboundRules.Name = "inboundRules";
            this.inboundRules.RowCount = 2;
            this.inboundRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inboundRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inboundRules.Size = new System.Drawing.Size(922, 221);
            this.inboundRules.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(28, 43);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(28, 3, 10, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(884, 175);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Profile";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Enabled";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Action";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Program";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Local Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Remote Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Protocol";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Local Port";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Remote Port";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inboundTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 40);
            this.panel2.TabIndex = 0;
            // 
            // inboundTitle
            // 
            this.inboundTitle.AutoSize = true;
            this.inboundTitle.BackColor = System.Drawing.Color.White;
            this.inboundTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.inboundTitle.ForeColor = System.Drawing.Color.Black;
            this.inboundTitle.Location = new System.Drawing.Point(22, 10);
            this.inboundTitle.Name = "inboundTitle";
            this.inboundTitle.Size = new System.Drawing.Size(105, 21);
            this.inboundTitle.TabIndex = 6;
            this.inboundTitle.Text = "Inbound rules";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.firewallContent.ResumeLayout(false);
            this.outboundRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutboundFirewall)).EndInit();
            this.outboundTitle.ResumeLayout(false);
            this.outboundTitle.PerformLayout();
            this.inboundRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label firewallNameLabel;
        private System.Windows.Forms.TableLayoutPanel firewallContent;
        private System.Windows.Forms.TableLayoutPanel outboundRules;
        private System.Windows.Forms.TableLayoutPanel inboundRules;
        private System.Windows.Forms.Panel outboundTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label inboundTitle;
        private System.Windows.Forms.DataGridView dataOutboundFirewall;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnabledD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemoteAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemotePort;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnabledA;
    }
}
