namespace WindowsPE
{
    partial class AddNewRuleFirewall
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
            this.firewallLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderText = new System.Windows.Forms.Label();
            this.bottomControls = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.firewallLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bottomControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // firewallLayout
            // 
            this.firewallLayout.ColumnCount = 1;
            this.firewallLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.firewallLayout.Controls.Add(this.panel1, 0, 0);
            this.firewallLayout.Controls.Add(this.bottomControls, 0, 2);
            this.firewallLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firewallLayout.Location = new System.Drawing.Point(0, 0);
            this.firewallLayout.Name = "firewallLayout";
            this.firewallLayout.RowCount = 3;
            this.firewallLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.firewallLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.firewallLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.firewallLayout.Size = new System.Drawing.Size(584, 441);
            this.firewallLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.HeaderText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 60);
            this.panel1.TabIndex = 0;
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.BackColor = System.Drawing.Color.Transparent;
            this.HeaderText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.HeaderText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderText.Location = new System.Drawing.Point(21, 18);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(212, 25);
            this.HeaderText.TabIndex = 7;
            this.HeaderText.Text = "Add a new rule - Firewall";
            // 
            // bottomControls
            // 
            this.bottomControls.BackColor = System.Drawing.SystemColors.Control;
            this.bottomControls.Controls.Add(this.BackBtn);
            this.bottomControls.Controls.Add(this.NextBtn);
            this.bottomControls.Controls.Add(this.CancelBtn);
            this.bottomControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomControls.Location = new System.Drawing.Point(0, 391);
            this.bottomControls.Margin = new System.Windows.Forms.Padding(0);
            this.bottomControls.Name = "bottomControls";
            this.bottomControls.Size = new System.Drawing.Size(584, 50);
            this.bottomControls.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(335, 15);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(416, 15);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next >";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(497, 15);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewRuleFirewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.firewallLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewRuleFirewall";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a new rule firewall";
            this.firewallLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bottomControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel firewallLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Panel bottomControls;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}