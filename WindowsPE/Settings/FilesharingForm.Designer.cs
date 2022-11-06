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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileSharingLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fileSharingNameLayout = new System.Windows.Forms.Panel();
            this.filesharingNameLabel = new System.Windows.Forms.Label();
            this.shareData = new System.Windows.Forms.DataGridView();
            this.Share = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newShareBtn = new System.Windows.Forms.Button();
            this.fileSharingLayout.SuspendLayout();
            this.fileSharingNameLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSharingLayout
            // 
            this.fileSharingLayout.ColumnCount = 1;
            this.fileSharingLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileSharingLayout.Controls.Add(this.fileSharingNameLayout, 0, 0);
            this.fileSharingLayout.Controls.Add(this.shareData, 0, 1);
            this.fileSharingLayout.Controls.Add(this.panel1, 0, 2);
            this.fileSharingLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSharingLayout.Location = new System.Drawing.Point(0, 0);
            this.fileSharingLayout.Name = "fileSharingLayout";
            this.fileSharingLayout.RowCount = 3;
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileSharingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.fileSharingLayout.Size = new System.Drawing.Size(934, 535);
            this.fileSharingLayout.TabIndex = 0;
            // 
            // fileSharingNameLayout
            // 
            this.fileSharingNameLayout.Controls.Add(this.filesharingNameLabel);
            this.fileSharingNameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSharingNameLayout.Location = new System.Drawing.Point(3, 3);
            this.fileSharingNameLayout.Name = "fileSharingNameLayout";
            this.fileSharingNameLayout.Size = new System.Drawing.Size(928, 69);
            this.fileSharingNameLayout.TabIndex = 0;
            this.fileSharingNameLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.fileSharingNameLayout_Paint);
            // 
            // filesharingNameLabel
            // 
            this.filesharingNameLabel.AutoSize = true;
            this.filesharingNameLabel.BackColor = System.Drawing.Color.White;
            this.filesharingNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesharingNameLabel.ForeColor = System.Drawing.Color.Black;
            this.filesharingNameLabel.Location = new System.Drawing.Point(22, 17);
            this.filesharingNameLabel.Name = "filesharingNameLabel";
            this.filesharingNameLabel.Size = new System.Drawing.Size(94, 37);
            this.filesharingNameLabel.TabIndex = 3;
            this.filesharingNameLabel.Text = "Shares";
            // 
            // shareData
            // 
            this.shareData.AllowUserToAddRows = false;
            this.shareData.AllowUserToDeleteRows = false;
            this.shareData.AllowUserToResizeColumns = false;
            this.shareData.AllowUserToResizeRows = false;
            this.shareData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shareData.BackgroundColor = System.Drawing.Color.White;
            this.shareData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shareData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shareData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shareData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Share,
            this.LocalPath,
            this.Protocol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shareData.DefaultCellStyle = dataGridViewCellStyle2;
            this.shareData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.shareData.GridColor = System.Drawing.Color.White;
            this.shareData.Location = new System.Drawing.Point(28, 78);
            this.shareData.Margin = new System.Windows.Forms.Padding(28, 3, 10, 3);
            this.shareData.MultiSelect = false;
            this.shareData.Name = "shareData";
            this.shareData.ReadOnly = true;
            this.shareData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shareData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.shareData.RowHeadersVisible = false;
            this.shareData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shareData.ShowCellErrors = false;
            this.shareData.ShowCellToolTips = false;
            this.shareData.ShowEditingIcon = false;
            this.shareData.ShowRowErrors = false;
            this.shareData.Size = new System.Drawing.Size(896, 404);
            this.shareData.TabIndex = 1;
            this.shareData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shareData_CellContentClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.newShareBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 44);
            this.panel1.TabIndex = 2;
            // 
            // newShareBtn
            // 
            this.newShareBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newShareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newShareBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newShareBtn.ForeColor = System.Drawing.Color.White;
            this.newShareBtn.Location = new System.Drawing.Point(25, 7);
            this.newShareBtn.Name = "newShareBtn";
            this.newShareBtn.Size = new System.Drawing.Size(99, 34);
            this.newShareBtn.TabIndex = 23;
            this.newShareBtn.Text = "New share";
            this.newShareBtn.UseVisualStyleBackColor = false;
            this.newShareBtn.Click += new System.EventHandler(this.newShareBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.shareData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fileSharingLayout;
        private System.Windows.Forms.Panel fileSharingNameLayout;
        private System.Windows.Forms.Label filesharingNameLabel;
        private System.Windows.Forms.DataGridView shareData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newShareBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Share;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
    }
}
