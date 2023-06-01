namespace WindowsPE.Settings.ShareWizard
{
    partial class ShareWizard_Name
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
            this.nameShare = new System.Windows.Forms.TextBox();
            this.shareLocationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.localPathtoShare = new System.Windows.Forms.TextBox();
            this.uncPathtoShare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameShare
            // 
            this.nameShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameShare.Location = new System.Drawing.Point(91, 19);
            this.nameShare.Name = "nameShare";
            this.nameShare.Size = new System.Drawing.Size(100, 20);
            this.nameShare.TabIndex = 0;
            this.nameShare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shareLocationLabel
            // 
            this.shareLocationLabel.AutoSize = true;
            this.shareLocationLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.shareLocationLabel.Location = new System.Drawing.Point(14, 20);
            this.shareLocationLabel.Name = "shareLocationLabel";
            this.shareLocationLabel.Size = new System.Drawing.Size(71, 15);
            this.shareLocationLabel.TabIndex = 2;
            this.shareLocationLabel.Text = "Share name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local path to share:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label3.Location = new System.Drawing.Point(14, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "UNC path:";
            // 
            // localPathtoShare
            // 
            this.localPathtoShare.BackColor = System.Drawing.Color.White;
            this.localPathtoShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localPathtoShare.Location = new System.Drawing.Point(17, 186);
            this.localPathtoShare.Name = "localPathtoShare";
            this.localPathtoShare.ReadOnly = true;
            this.localPathtoShare.Size = new System.Drawing.Size(381, 20);
            this.localPathtoShare.TabIndex = 6;
            // 
            // uncPathtoShare
            // 
            this.uncPathtoShare.BackColor = System.Drawing.Color.White;
            this.uncPathtoShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uncPathtoShare.Location = new System.Drawing.Point(17, 263);
            this.uncPathtoShare.Name = "uncPathtoShare";
            this.uncPathtoShare.ReadOnly = true;
            this.uncPathtoShare.Size = new System.Drawing.Size(381, 20);
            this.uncPathtoShare.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(14, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "If the folder doesn\'t exist, it will be created.";
            // 
            // ShareWizard_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uncPathtoShare);
            this.Controls.Add(this.localPathtoShare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shareLocationLabel);
            this.Controls.Add(this.nameShare);
            this.Name = "ShareWizard_Name";
            this.Size = new System.Drawing.Size(422, 304);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameShare;
        private System.Windows.Forms.Label shareLocationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localPathtoShare;
        private System.Windows.Forms.TextBox uncPathtoShare;
        private System.Windows.Forms.Label label1;
    }
}
