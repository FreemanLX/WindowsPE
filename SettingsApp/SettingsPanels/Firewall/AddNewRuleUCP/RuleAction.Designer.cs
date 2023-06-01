namespace WindowsPE.Settings.Firewall.AddNewRule
{
    partial class RuleAction
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBlockConnection = new System.Windows.Forms.RadioButton();
            this.radioAllowConnection = new System.Windows.Forms.RadioButton();
            this.InfoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Blocks all the connections for the specified rule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "This includes all types of connections.";
            // 
            // radioBlockConnection
            // 
            this.radioBlockConnection.AutoSize = true;
            this.radioBlockConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioBlockConnection.Location = new System.Drawing.Point(16, 133);
            this.radioBlockConnection.Name = "radioBlockConnection";
            this.radioBlockConnection.Size = new System.Drawing.Size(137, 19);
            this.radioBlockConnection.TabIndex = 17;
            this.radioBlockConnection.TabStop = true;
            this.radioBlockConnection.Text = "Block the connection";
            this.radioBlockConnection.UseVisualStyleBackColor = true;
            // 
            // radioAllowConnection
            // 
            this.radioAllowConnection.AutoSize = true;
            this.radioAllowConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioAllowConnection.Location = new System.Drawing.Point(16, 64);
            this.radioAllowConnection.Name = "radioAllowConnection";
            this.radioAllowConnection.Size = new System.Drawing.Size(138, 19);
            this.radioAllowConnection.TabIndex = 16;
            this.radioAllowConnection.TabStop = true;
            this.radioAllowConnection.Text = "Allow the connection";
            this.radioAllowConnection.UseVisualStyleBackColor = true;
            this.radioAllowConnection.CheckedChanged += new System.EventHandler(this.radioAllowConnection_CheckedChanged);
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(14, 17);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(315, 19);
            this.InfoText.TabIndex = 22;
            this.InfoText.Text = "What action should be taken for the specified rule?\r\n";
            // 
            // RuleAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBlockConnection);
            this.Controls.Add(this.radioAllowConnection);
            this.Name = "RuleAction";
            this.Size = new System.Drawing.Size(470, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBlockConnection;
        private System.Windows.Forms.RadioButton radioAllowConnection;
        private System.Windows.Forms.Label InfoText;
    }
}
