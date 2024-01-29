namespace WindowsPE.Settings
{
    partial class Default_form
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
            this.controlItemContainer = new System.Windows.Forms.Panel();
            this.controlPanelLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.controlPanelLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlItemContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // controlItemContainer
            // 
            this.controlItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlItemContainer.Location = new System.Drawing.Point(0, 48);
            this.controlItemContainer.Margin = new System.Windows.Forms.Padding(0);
            this.controlItemContainer.Name = "controlItemContainer";
            this.controlItemContainer.Size = new System.Drawing.Size(934, 487);
            this.controlItemContainer.TabIndex = 0;
            // 
            // controlPanelLabel
            // 
            this.controlPanelLabel.AutoSize = true;
            this.controlPanelLabel.BackColor = System.Drawing.Color.White;
            this.controlPanelLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.controlPanelLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.controlPanelLabel.Location = new System.Drawing.Point(24, 24);
            this.controlPanelLabel.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.controlPanelLabel.Name = "controlPanelLabel";
            this.controlPanelLabel.Size = new System.Drawing.Size(252, 24);
            this.controlPanelLabel.TabIndex = 2;
            this.controlPanelLabel.Text = "Adjust your computer\'s settings";
            // 
            // Default_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Default_form";
            this.Size = new System.Drawing.Size(934, 535);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel controlItemContainer;
        private System.Windows.Forms.Label controlPanelLabel;
    }
}
