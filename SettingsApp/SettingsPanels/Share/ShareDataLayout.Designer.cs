namespace WindowsPE.Settings.ShareWizard
{
    partial class ShareDataLayout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.shareData = new System.Windows.Forms.DataGridView();
            this.Share = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTitle = new System.Windows.Forms.Label();
            this.tableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 1;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Controls.Add(this.shareData, 0, 1);
            this.tableContainer.Controls.Add(this.headerTitle, 0, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 2;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(771, 392);
            this.tableContainer.TabIndex = 0;
            // 
            // shareData
            // 
            this.shareData.AllowUserToAddRows = false;
            this.shareData.AllowUserToDeleteRows = false;
            this.shareData.AllowUserToResizeRows = false;
            this.shareData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shareData.BackgroundColor = System.Drawing.Color.White;
            this.shareData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.shareData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.shareData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shareData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shareData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Share,
            this.LocalPath,
            this.Protocol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shareData.DefaultCellStyle = dataGridViewCellStyle2;
            this.shareData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.shareData.GridColor = System.Drawing.Color.White;
            this.shareData.Location = new System.Drawing.Point(28, 53);
            this.shareData.Margin = new System.Windows.Forms.Padding(28, 3, 10, 3);
            this.shareData.MultiSelect = false;
            this.shareData.Name = "shareData";
            this.shareData.ReadOnly = true;
            this.shareData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shareData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.shareData.RowHeadersVisible = false;
            this.shareData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.shareData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shareData.ShowCellErrors = false;
            this.shareData.ShowCellToolTips = false;
            this.shareData.ShowEditingIcon = false;
            this.shareData.ShowRowErrors = false;
            this.shareData.Size = new System.Drawing.Size(733, 336);
            this.shareData.TabIndex = 8;
            // 
            // Share
            // 
            this.Share.HeaderText = "Share";
            this.Share.Name = "Share";
            this.Share.ReadOnly = true;
            this.Share.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LocalPath
            // 
            this.LocalPath.HeaderText = "Local Path";
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.ReadOnly = true;
            this.LocalPath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Protocol
            // 
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.BackColor = System.Drawing.Color.Transparent;
            this.headerTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.headerTitle.ForeColor = System.Drawing.Color.Black;
            this.headerTitle.Location = new System.Drawing.Point(27, 15);
            this.headerTitle.Margin = new System.Windows.Forms.Padding(27, 15, 0, 0);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(55, 21);
            this.headerTitle.TabIndex = 7;
            this.headerTitle.Text = "Shares";
            // 
            // ShareDataLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableContainer);
            this.DoubleBuffered = true;
            this.Name = "ShareDataLayout";
            this.Size = new System.Drawing.Size(771, 392);
            this.tableContainer.ResumeLayout(false);
            this.tableContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.DataGridView shareData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Share;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
    }
}
