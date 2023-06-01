namespace WindowsPE.Settings.Firewall.AddNewRule
{
    partial class NewRulePort
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.protocolComboBox = new System.Windows.Forms.ComboBox();
            this.localPortComboBox = new System.Windows.Forms.ComboBox();
            this.localPortTextBox = new System.Windows.Forms.TextBox();
            this.remotePortTextBox = new System.Windows.Forms.TextBox();
            this.remotePortComboBox = new System.Windows.Forms.ComboBox();
            this.protocolTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(15, 19);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(311, 19);
            this.InfoText.TabIndex = 11;
            this.InfoText.Text = "To which ports and protocols does this rule apply?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Protocol type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Local port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Remote port:";
            // 
            // protocolComboBox
            // 
            this.protocolComboBox.FormattingEnabled = true;
            this.protocolComboBox.Location = new System.Drawing.Point(129, 55);
            this.protocolComboBox.Name = "protocolComboBox";
            this.protocolComboBox.Size = new System.Drawing.Size(121, 21);
            this.protocolComboBox.TabIndex = 16;
            this.protocolComboBox.Text = "TCP";
            this.protocolComboBox.SelectedIndexChanged += new System.EventHandler(this.protocolComboBox_SelectedIndexChanged);
            // 
            // localPortComboBox
            // 
            this.localPortComboBox.FormattingEnabled = true;
            this.localPortComboBox.Items.AddRange(new object[] {
            "All Ports",
            "Specific ports"});
            this.localPortComboBox.Location = new System.Drawing.Point(129, 105);
            this.localPortComboBox.Name = "localPortComboBox";
            this.localPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.localPortComboBox.TabIndex = 17;
            this.localPortComboBox.Text = "All Ports";
            this.localPortComboBox.SelectedIndexChanged += new System.EventHandler(this.localPortComboBox_SelectedIndexChanged);
            // 
            // localPortTextBox
            // 
            this.localPortTextBox.Enabled = false;
            this.localPortTextBox.Location = new System.Drawing.Point(129, 132);
            this.localPortTextBox.Name = "localPortTextBox";
            this.localPortTextBox.Size = new System.Drawing.Size(121, 20);
            this.localPortTextBox.TabIndex = 19;
            this.localPortTextBox.TextChanged += new System.EventHandler(this.localPortTextBox_TextChanged);
            // 
            // remotePortTextBox
            // 
            this.remotePortTextBox.Enabled = false;
            this.remotePortTextBox.Location = new System.Drawing.Point(129, 195);
            this.remotePortTextBox.Name = "remotePortTextBox";
            this.remotePortTextBox.Size = new System.Drawing.Size(121, 20);
            this.remotePortTextBox.TabIndex = 20;
            this.remotePortTextBox.TextChanged += new System.EventHandler(this.remotePortTextBox_TextChanged);
            // 
            // remotePortComboBox
            // 
            this.remotePortComboBox.FormattingEnabled = true;
            this.remotePortComboBox.Items.AddRange(new object[] {
            "All Ports",
            "Specific ports"});
            this.remotePortComboBox.Location = new System.Drawing.Point(129, 168);
            this.remotePortComboBox.Name = "remotePortComboBox";
            this.remotePortComboBox.Size = new System.Drawing.Size(121, 21);
            this.remotePortComboBox.TabIndex = 21;
            this.remotePortComboBox.Text = "All Ports";
            this.remotePortComboBox.SelectedIndexChanged += new System.EventHandler(this.remotePortComboBox_SelectedIndexChanged);
            // 
            // protocolTypeComboBox
            // 
            this.protocolTypeComboBox.FormattingEnabled = true;
            this.protocolTypeComboBox.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "ICMP"});
            this.protocolTypeComboBox.Location = new System.Drawing.Point(129, 55);
            this.protocolTypeComboBox.Name = "protocolTypeComboBox";
            this.protocolTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.protocolTypeComboBox.TabIndex = 16;
            this.protocolTypeComboBox.Text = "TCP";
            // 
            // NewRulePort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.remotePortComboBox);
            this.Controls.Add(this.remotePortTextBox);
            this.Controls.Add(this.localPortTextBox);
            this.Controls.Add(this.localPortComboBox);
            this.Controls.Add(this.protocolComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoText);
            this.Name = "NewRulePort";
            this.Size = new System.Drawing.Size(470, 290);
            this.Load += new System.EventHandler(this.NewRulePort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox protocolComboBox;
        private System.Windows.Forms.ComboBox localPortComboBox;
        private System.Windows.Forms.TextBox localPortTextBox;
        private System.Windows.Forms.TextBox remotePortTextBox;
        private System.Windows.Forms.ComboBox remotePortComboBox;
        private System.Windows.Forms.ComboBox protocolTypeComboBox;
    }
}
