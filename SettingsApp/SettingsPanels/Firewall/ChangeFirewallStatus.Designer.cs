namespace WindowsPE
{
    partial class ChangeFirewallStatus
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoText = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.profileLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(13, 57);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(221, 15);
            this.InfoText.TabIndex = 8;
            this.InfoText.Text = "Please select accordingly for every profile";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.FinishBtn.Location = new System.Drawing.Point(581, 338);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(75, 23);
            this.FinishBtn.TabIndex = 10;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.Cancel_Btn.Location = new System.Drawing.Point(500, 338);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btn.TabIndex = 11;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // profileLayout
            // 
            this.profileLayout.BackColor = System.Drawing.Color.White;
            this.profileLayout.ColumnCount = 1;
            this.profileLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profileLayout.Location = new System.Drawing.Point(12, 98);
            this.profileLayout.Name = "profileLayout";
            this.profileLayout.RowCount = 2;
            this.profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.profileLayout.Size = new System.Drawing.Size(644, 224);
            this.profileLayout.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(24, 24, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customize settings for each type of network";
            // 
            // ChangeFirewallStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileLayout);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.InfoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeFirewallStatus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customize Firewall Settings";
            this.Load += new System.EventHandler(this.ChangeFirewallStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.TableLayoutPanel profileLayout;
        private System.Windows.Forms.Label label1;
    }
}