namespace WindowsPE.Settings.Firewall.AddNewRule
{
    partial class RuleType
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
            this.inboundRadioBtn = new System.Windows.Forms.RadioButton();
            this.outboundRadioBtn = new System.Windows.Forms.RadioButton();
            this.firewallName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.InfoText.Size = new System.Drawing.Size(330, 19);
            this.InfoText.TabIndex = 10;
            this.InfoText.Text = "On which the connection this rule should be applied?";
            // 
            // inboundRadioBtn
            // 
            this.inboundRadioBtn.AutoSize = true;
            this.inboundRadioBtn.Checked = true;
            this.inboundRadioBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboundRadioBtn.Location = new System.Drawing.Point(29, 59);
            this.inboundRadioBtn.Name = "inboundRadioBtn";
            this.inboundRadioBtn.Size = new System.Drawing.Size(70, 19);
            this.inboundRadioBtn.TabIndex = 11;
            this.inboundRadioBtn.TabStop = true;
            this.inboundRadioBtn.Text = "Inbound";
            this.inboundRadioBtn.UseVisualStyleBackColor = true;
            this.inboundRadioBtn.CheckedChanged += new System.EventHandler(this.InboundRadioBtn_CheckedChanged);
            // 
            // outboundRadioBtn
            // 
            this.outboundRadioBtn.AutoSize = true;
            this.outboundRadioBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboundRadioBtn.Location = new System.Drawing.Point(29, 82);
            this.outboundRadioBtn.Name = "outboundRadioBtn";
            this.outboundRadioBtn.Size = new System.Drawing.Size(80, 19);
            this.outboundRadioBtn.TabIndex = 12;
            this.outboundRadioBtn.TabStop = true;
            this.outboundRadioBtn.Text = "Outbound";
            this.outboundRadioBtn.UseVisualStyleBackColor = true;
            this.outboundRadioBtn.CheckedChanged += new System.EventHandler(this.outboundRadioBtn_CheckedChanged);
            // 
            // firewallName
            // 
            this.firewallName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firewallName.Location = new System.Drawing.Point(29, 198);
            this.firewallName.Name = "firewallName";
            this.firewallName.Size = new System.Drawing.Size(384, 22);
            this.firewallName.TabIndex = 18;
            this.firewallName.TextChanged += new System.EventHandler(this.FirewallName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label1.Location = new System.Drawing.Point(26, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "What is the rule name?";
            // 
            // RuleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firewallName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outboundRadioBtn);
            this.Controls.Add(this.inboundRadioBtn);
            this.Controls.Add(this.InfoText);
            this.Name = "RuleType";
            this.Size = new System.Drawing.Size(470, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.RadioButton inboundRadioBtn;
        private System.Windows.Forms.RadioButton outboundRadioBtn;
        private System.Windows.Forms.TextBox firewallName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
