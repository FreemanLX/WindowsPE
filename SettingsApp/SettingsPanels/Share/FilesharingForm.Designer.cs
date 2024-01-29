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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileSharingLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fileSharingNameLayout = new System.Windows.Forms.Panel();
            this.filesharingNameLabel = new System.Windows.Forms.Label();
            this.filesharingContainer = new System.Windows.Forms.TableLayoutPanel();
            this.shareData = new System.Windows.Forms.DataGridView();
            this.optionLayout = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Share = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSharingLayout.SuspendLayout();
            this.fileSharingNameLayout.SuspendLayout();
            this.filesharingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareData)).BeginInit();
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
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.22327F));
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.77672F));
            this.fileSharingLayout.Size = new System.Drawing.Size(693, 558);
            this.fileSharingLayout.TabIndex = 0;
            // 
            // fileSharingNameLayout
            // 
            this.fileSharingNameLayout.Controls.Add(this.filesharingNameLabel);
            this.fileSharingNameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSharingNameLayout.Location = new System.Drawing.Point(0, 0);
            this.fileSharingNameLayout.Margin = new System.Windows.Forms.Padding(0);
            this.fileSharingNameLayout.Name = "fileSharingNameLayout";
            this.fileSharingNameLayout.Size = new System.Drawing.Size(693, 75);
            this.fileSharingNameLayout.TabIndex = 0;
            // 
            // filesharingNameLabel
            // 
            this.filesharingNameLabel.AutoSize = true;
            this.filesharingNameLabel.BackColor = System.Drawing.Color.White;
            this.filesharingNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.filesharingNameLabel.ForeColor = System.Drawing.Color.Black;
            this.filesharingNameLabel.Location = new System.Drawing.Point(23, 23);
            this.filesharingNameLabel.Name = "filesharingNameLabel";
            this.filesharingNameLabel.Size = new System.Drawing.Size(105, 25);
            this.filesharingNameLabel.TabIndex = 3;
            this.filesharingNameLabel.Text = "File Sharing";
            // 
            // filesharingContainer
            // 
            this.filesharingContainer.ColumnCount = 2;
            this.filesharingContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.filesharingContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.filesharingContainer.Controls.Add(this.shareData, 0, 0);
            this.filesharingContainer.Controls.Add(this.optionLayout, 1, 0);
            this.filesharingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesharingContainer.Location = new System.Drawing.Point(0, 75);
            this.filesharingContainer.Margin = new System.Windows.Forms.Padding(0);
            this.filesharingContainer.Name = "filesharingContainer";
            this.filesharingContainer.RowCount = 1;
            this.filesharingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filesharingContainer.Size = new System.Drawing.Size(693, 416);
            this.filesharingContainer.TabIndex = 24;
            // 
            // shareData
            // 
            this.shareData.AllowUserToAddRows = false;
            this.shareData.AllowUserToDeleteRows = false;
            this.shareData.AllowUserToResizeRows = false;
            this.shareData.BackgroundColor = System.Drawing.Color.White;
            this.shareData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.shareData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.shareData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shareData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.shareData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Share,
            this.LocalPath,
            this.Protocol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shareData.DefaultCellStyle = dataGridViewCellStyle8;
            this.shareData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.shareData.GridColor = System.Drawing.Color.White;
            this.shareData.Location = new System.Drawing.Point(28, 3);
            this.shareData.Margin = new System.Windows.Forms.Padding(28, 3, 10, 3);
            this.shareData.MultiSelect = false;
            this.shareData.Name = "shareData";
            this.shareData.ReadOnly = true;
            this.shareData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shareData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.shareData.RowHeadersVisible = false;
            this.shareData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.shareData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shareData.ShowCellErrors = false;
            this.shareData.ShowCellToolTips = false;
            this.shareData.ShowEditingIcon = false;
            this.shareData.ShowRowErrors = false;
            this.shareData.Size = new System.Drawing.Size(447, 410);
            this.shareData.TabIndex = 9;
            // 
            // optionLayout
            // 
            this.optionLayout.Controls.Add(this.label3);
            this.optionLayout.Controls.Add(this.label2);
            this.optionLayout.Controls.Add(this.label1);
            this.optionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionLayout.Location = new System.Drawing.Point(488, 0);
            this.optionLayout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.optionLayout.Name = "optionLayout";
            this.optionLayout.Size = new System.Drawing.Size(202, 416);
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
            // Share
            // 
            this.Share.HeaderText = "Share Name";
            this.Share.Name = "Share";
            this.Share.ReadOnly = true;
            this.Share.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Share.Width = 150;
            // 
            // LocalPath
            // 
            this.LocalPath.HeaderText = "Folder Path";
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.ReadOnly = true;
            this.LocalPath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalPath.Width = 150;
            // 
            // Protocol
            // 
            this.Protocol.HeaderText = "Type";
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FilesharingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 558);
            this.Controls.Add(this.fileSharingLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilesharingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Sharing Wizard";
            this.Load += new System.EventHandler(this.FilesharingForm_Load);
            this.fileSharingLayout.ResumeLayout(false);
            this.fileSharingNameLayout.ResumeLayout(false);
            this.fileSharingNameLayout.PerformLayout();
            this.filesharingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shareData)).EndInit();
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
        private System.Windows.Forms.DataGridView shareData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Share;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
    }
}
