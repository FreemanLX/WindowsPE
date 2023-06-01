namespace WindowsPE.Settings
{
    partial class FilesharingForm
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
            this.fileSharingLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fileSharingNameLayout = new System.Windows.Forms.Panel();
            this.filesharingNameLabel = new System.Windows.Forms.Label();
            this.filesharingContainer = new System.Windows.Forms.TableLayoutPanel();
            this.optionLayout = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSharingLayout.SuspendLayout();
            this.fileSharingNameLayout.SuspendLayout();
            this.filesharingContainer.SuspendLayout();
            this.optionLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSharingLayout
            // 
            this.fileSharingLayout.ColumnCount = 1;
            this.fileSharingLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileSharingLayout.Controls.Add(this.fileSharingNameLayout, 0, 0);
            this.fileSharingLayout.Controls.Add(this.filesharingContainer, 0, 1);
            this.fileSharingLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSharingLayout.Location = new System.Drawing.Point(0, 0);
            this.fileSharingLayout.Name = "fileSharingLayout";
            this.fileSharingLayout.RowCount = 3;
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.fileSharingLayout.Size = new System.Drawing.Size(934, 535);
            this.fileSharingLayout.TabIndex = 0;
            // 
            // fileSharingNameLayout
            // 
            this.fileSharingNameLayout.Controls.Add(this.filesharingNameLabel);
            this.fileSharingNameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSharingNameLayout.Location = new System.Drawing.Point(0, 0);
            this.fileSharingNameLayout.Margin = new System.Windows.Forms.Padding(0);
            this.fileSharingNameLayout.Name = "fileSharingNameLayout";
            this.fileSharingNameLayout.Size = new System.Drawing.Size(934, 75);
            this.fileSharingNameLayout.TabIndex = 0;
            // 
            // filesharingNameLabel
            // 
            this.filesharingNameLabel.AutoSize = true;
            this.filesharingNameLabel.BackColor = System.Drawing.Color.White;
            this.filesharingNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesharingNameLabel.ForeColor = System.Drawing.Color.Black;
            this.filesharingNameLabel.Location = new System.Drawing.Point(22, 16);
            this.filesharingNameLabel.Name = "filesharingNameLabel";
            this.filesharingNameLabel.Size = new System.Drawing.Size(152, 37);
            this.filesharingNameLabel.TabIndex = 3;
            this.filesharingNameLabel.Text = "File Sharing";
            // 
            // filesharingContainer
            // 
            this.filesharingContainer.ColumnCount = 2;
            this.filesharingContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.filesharingContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.filesharingContainer.Controls.Add(this.optionLayout, 1, 0);
            this.filesharingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesharingContainer.Location = new System.Drawing.Point(0, 75);
            this.filesharingContainer.Margin = new System.Windows.Forms.Padding(0);
            this.filesharingContainer.Name = "filesharingContainer";
            this.filesharingContainer.RowCount = 1;
            this.filesharingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filesharingContainer.Size = new System.Drawing.Size(934, 328);
            this.filesharingContainer.TabIndex = 24;
            // 
            // optionLayout
            // 
            this.optionLayout.Controls.Add(this.label3);
            this.optionLayout.Controls.Add(this.label2);
            this.optionLayout.Controls.Add(this.label1);
            this.optionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionLayout.Location = new System.Drawing.Point(656, 0);
            this.optionLayout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.optionLayout.Name = "optionLayout";
            this.optionLayout.Size = new System.Drawing.Size(275, 328);
            this.optionLayout.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enable filesharing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Refresh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new share";
            // 
            // FilesharingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fileSharingLayout);
            this.Name = "FilesharingForm";
            this.Size = new System.Drawing.Size(934, 535);
            this.Load += new System.EventHandler(this.FilesharingForm_Load);
            this.fileSharingLayout.ResumeLayout(false);
            this.fileSharingNameLayout.ResumeLayout(false);
            this.fileSharingNameLayout.PerformLayout();
            this.filesharingContainer.ResumeLayout(false);
            this.optionLayout.ResumeLayout(false);
            this.optionLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fileSharingLayout;
        private System.Windows.Forms.Panel fileSharingNameLayout;
        private System.Windows.Forms.Label filesharingNameLabel;
        private System.Windows.Forms.TableLayoutPanel filesharingContainer;
        private System.Windows.Forms.Panel optionLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
