namespace WindowsPE
{
    partial class ApplicationStartIcon
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
            this.panelLabelContainer = new System.Windows.Forms.Panel();
            this.applicationName = new System.Windows.Forms.Label();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLabelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelLabelContainer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPicture, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLabelContainer
            // 
            this.panelLabelContainer.Controls.Add(this.applicationName);
            this.panelLabelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabelContainer.Location = new System.Drawing.Point(51, 3);
            this.panelLabelContainer.Name = "panelLabelContainer";
            this.panelLabelContainer.Size = new System.Drawing.Size(297, 37);
            this.panelLabelContainer.TabIndex = 0;
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.applicationName.ForeColor = System.Drawing.Color.White;
            this.applicationName.Location = new System.Drawing.Point(3, 9);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(81, 19);
            this.applicationName.TabIndex = 3;
            this.applicationName.Text = "LoadingText";
            this.applicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.DarkRed;
            this.iconPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPicture.Location = new System.Drawing.Point(3, 3);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(42, 37);
            this.iconPicture.TabIndex = 2;
            this.iconPicture.TabStop = false;
            // 
            // ApplicationStartIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ApplicationStartIcon";
            this.Size = new System.Drawing.Size(351, 43);
            this.Load += new System.EventHandler(this.ApplicationStartIcon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLabelContainer.ResumeLayout(false);
            this.panelLabelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLabelContainer;
        private System.Windows.Forms.Label applicationName;
        private System.Windows.Forms.PictureBox iconPicture;
    }
}
