namespace WindowsPE.Settings.ShareWizard
{
    partial class ShareWizard_Location
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
            this.radioVolumeBtn = new System.Windows.Forms.RadioButton();
            this.radioPathBtn = new System.Windows.Forms.RadioButton();
            this.volumeDataGrid = new System.Windows.Forms.DataGridView();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPathTextBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // radioVolumeBtn
            // 
            this.radioVolumeBtn.AutoSize = true;
            this.radioVolumeBtn.Location = new System.Drawing.Point(15, 17);
            this.radioVolumeBtn.Name = "radioVolumeBtn";
            this.radioVolumeBtn.Size = new System.Drawing.Size(109, 17);
            this.radioVolumeBtn.TabIndex = 1;
            this.radioVolumeBtn.TabStop = true;
            this.radioVolumeBtn.Text = "Select by volume:";
            this.radioVolumeBtn.UseVisualStyleBackColor = true;
            this.radioVolumeBtn.CheckedChanged += new System.EventHandler(this.radioVolumeBtn_CheckedChanged);
            // 
            // radioPathBtn
            // 
            this.radioPathBtn.AutoSize = true;
            this.radioPathBtn.Location = new System.Drawing.Point(15, 230);
            this.radioPathBtn.Name = "radioPathBtn";
            this.radioPathBtn.Size = new System.Drawing.Size(122, 17);
            this.radioPathBtn.TabIndex = 2;
            this.radioPathBtn.TabStop = true;
            this.radioPathBtn.Text = "Type a custom path:";
            this.radioPathBtn.UseVisualStyleBackColor = true;
            this.radioPathBtn.CheckedChanged += new System.EventHandler(this.radioPathBtn_CheckedChanged);
            // 
            // volumeDataGrid
            // 
            this.volumeDataGrid.AllowUserToAddRows = false;
            this.volumeDataGrid.AllowUserToDeleteRows = false;
            this.volumeDataGrid.AllowUserToResizeColumns = false;
            this.volumeDataGrid.AllowUserToResizeRows = false;
            this.volumeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.volumeDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.volumeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.volumeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.volumeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Volume,
            this.Freespace,
            this.Capacity,
            this.filesystem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.volumeDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.volumeDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.volumeDataGrid.GridColor = System.Drawing.Color.White;
            this.volumeDataGrid.Location = new System.Drawing.Point(15, 40);
            this.volumeDataGrid.MultiSelect = false;
            this.volumeDataGrid.Name = "volumeDataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.volumeDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.volumeDataGrid.RowHeadersVisible = false;
            this.volumeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.volumeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.volumeDataGrid.ShowCellErrors = false;
            this.volumeDataGrid.ShowCellToolTips = false;
            this.volumeDataGrid.ShowEditingIcon = false;
            this.volumeDataGrid.ShowRowErrors = false;
            this.volumeDataGrid.Size = new System.Drawing.Size(392, 171);
            this.volumeDataGrid.TabIndex = 3;
            this.volumeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.volumeDataGrid_CellContentClick);
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            // 
            // Freespace
            // 
            this.Freespace.HeaderText = "Free space";
            this.Freespace.Name = "Freespace";
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            // 
            // filesystem
            // 
            this.filesystem.HeaderText = "File System";
            this.filesystem.Name = "filesystem";
            // 
            // customPathTextBox
            // 
            this.customPathTextBox.Enabled = false;
            this.customPathTextBox.Location = new System.Drawing.Point(15, 253);
            this.customPathTextBox.Name = "customPathTextBox";
            this.customPathTextBox.Size = new System.Drawing.Size(311, 20);
            this.customPathTextBox.TabIndex = 4;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(332, 251);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 5;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // ShareWizard_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.customPathTextBox);
            this.Controls.Add(this.volumeDataGrid);
            this.Controls.Add(this.radioPathBtn);
            this.Controls.Add(this.radioVolumeBtn);
            this.Name = "ShareWizard_Location";
            this.Size = new System.Drawing.Size(422, 304);
            this.Load += new System.EventHandler(this.ShareWizard_Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioVolumeBtn;
        private System.Windows.Forms.RadioButton radioPathBtn;
        private System.Windows.Forms.DataGridView volumeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freespace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesystem;
        private System.Windows.Forms.TextBox customPathTextBox;
        private System.Windows.Forms.Button browseBtn;
    }
}
