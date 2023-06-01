namespace WindowsPE.Settings.Networking.ChangeNetworkPanels
{
    partial class SetIPAdress
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
            this.ipAddressContainerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.interfaceText = new System.Windows.Forms.Label();
            this.ipAddressContainerLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipAddressContainerLayout
            // 
            this.ipAddressContainerLayout.ColumnCount = 1;
            this.ipAddressContainerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ipAddressContainerLayout.Controls.Add(this.headerPanel, 0, 0);
            this.ipAddressContainerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipAddressContainerLayout.Location = new System.Drawing.Point(0, 0);
            this.ipAddressContainerLayout.Name = "ipAddressContainerLayout";
            this.ipAddressContainerLayout.RowCount = 3;
            this.ipAddressContainerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ipAddressContainerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ipAddressContainerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ipAddressContainerLayout.Size = new System.Drawing.Size(578, 325);
            this.ipAddressContainerLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.interfaceText);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(578, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // interfaceText
            // 
            this.interfaceText.AutoSize = true;
            this.interfaceText.BackColor = System.Drawing.Color.Transparent;
            this.interfaceText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interfaceText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.interfaceText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.interfaceText.Location = new System.Drawing.Point(14, 16);
            this.interfaceText.Name = "interfaceText";
            this.interfaceText.Size = new System.Drawing.Size(475, 19);
            this.interfaceText.TabIndex = 16;
            this.interfaceText.Text = "You can get IP settings assigned automatically or you can just insert manually";
            // 
            // SetIPAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ipAddressContainerLayout);
            this.Name = "SetIPAdress";
            this.Size = new System.Drawing.Size(578, 325);
            this.Load += new System.EventHandler(this.SetIPAdress_Load);
            this.ipAddressContainerLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ipAddressContainerLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label interfaceText;
    }
}
