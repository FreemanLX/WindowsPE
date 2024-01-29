namespace SettingsApp
{
    partial class backup
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
            this.sideContainer = new System.Windows.Forms.Panel();
            this.securityLabel = new System.Windows.Forms.Label();
            this.networkLabel = new System.Windows.Forms.Label();
            this.personalizationLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.sideContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideContainer
            // 
            this.sideContainer.BackColor = System.Drawing.Color.Transparent;
            this.sideContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideContainer.Controls.Add(this.securityLabel);
            this.sideContainer.Controls.Add(this.networkLabel);
            this.sideContainer.Controls.Add(this.personalizationLabel);
            this.sideContainer.Controls.Add(this.homeLabel);
            this.sideContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideContainer.Location = new System.Drawing.Point(0, 0);
            this.sideContainer.Margin = new System.Windows.Forms.Padding(0);
            this.sideContainer.Name = "sideContainer";
            this.sideContainer.Size = new System.Drawing.Size(800, 450);
            this.sideContainer.TabIndex = 1;
            // 
            // securityLabel
            // 
            this.securityLabel.AutoSize = true;
            this.securityLabel.BackColor = System.Drawing.Color.Transparent;
            this.securityLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.securityLabel.ForeColor = System.Drawing.Color.Black;
            this.securityLabel.Location = new System.Drawing.Point(12, 129);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(53, 17);
            this.securityLabel.TabIndex = 4;
            this.securityLabel.Text = "Security";
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.networkLabel.BackColor = System.Drawing.Color.Transparent;
            this.networkLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.networkLabel.ForeColor = System.Drawing.Color.Black;
            this.networkLabel.Location = new System.Drawing.Point(12, 69);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(173, 17);
            this.networkLabel.TabIndex = 3;
            this.networkLabel.Text = "Network and Sharing Center";
            // 
            // personalizationLabel
            // 
            this.personalizationLabel.AutoSize = true;
            this.personalizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.personalizationLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.personalizationLabel.ForeColor = System.Drawing.Color.Black;
            this.personalizationLabel.Location = new System.Drawing.Point(12, 99);
            this.personalizationLabel.Name = "personalizationLabel";
            this.personalizationLabel.Size = new System.Drawing.Size(196, 17);
            this.personalizationLabel.TabIndex = 2;
            this.personalizationLabel.Text = "Appearence and Personalization";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.homeLabel.ForeColor = System.Drawing.Color.Black;
            this.homeLabel.Location = new System.Drawing.Point(12, 22);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(125, 17);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Control Panel Home";
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideContainer);
            this.Name = "backup";
            this.Text = "backup";
            this.sideContainer.ResumeLayout(false);
            this.sideContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideContainer;
        private System.Windows.Forms.Label securityLabel;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label personalizationLabel;
        private System.Windows.Forms.Label homeLabel;
    }
}