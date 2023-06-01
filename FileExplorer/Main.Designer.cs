namespace WindowsPE
{
    partial class File_explorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_explorer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new System.Windows.Forms.TableLayoutPanel();
            this.tableHeaderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.TextBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableContentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ContentGrid = new System.Windows.Forms.DataGridView();
            this.IconGrd = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameGrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeGrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTreeView = new System.Windows.Forms.TreeView();
            this.fileImageTreeList = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header.SuspendLayout();
            this.tableHeaderLayout.SuspendLayout();
            this.tableContentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.ColumnCount = 1;
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.Controls.Add(this.tableHeaderLayout, 0, 0);
            this.Header.Controls.Add(this.tableContentLayout, 0, 1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.RowCount = 2;
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Header.Size = new System.Drawing.Size(1008, 729);
            this.Header.TabIndex = 2;
            // 
            // tableHeaderLayout
            // 
            this.tableHeaderLayout.AutoSize = true;
            this.tableHeaderLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableHeaderLayout.BackColor = System.Drawing.Color.White;
            this.tableHeaderLayout.ColumnCount = 4;
            this.tableHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableHeaderLayout.Controls.Add(this.button2, 1, 0);
            this.tableHeaderLayout.Controls.Add(this.Location, 2, 0);
            this.tableHeaderLayout.Controls.Add(this.SearchBar, 3, 0);
            this.tableHeaderLayout.Controls.Add(this.button1, 0, 0);
            this.tableHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableHeaderLayout.Location = new System.Drawing.Point(3, 3);
            this.tableHeaderLayout.Name = "tableHeaderLayout";
            this.tableHeaderLayout.RowCount = 1;
            this.tableHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHeaderLayout.Size = new System.Drawing.Size(1002, 34);
            this.tableHeaderLayout.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(43, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 28);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.White;
            this.Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.Location.ForeColor = System.Drawing.Color.Black;
            this.Location.Location = new System.Drawing.Point(83, 3);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(628, 29);
            this.Location.TabIndex = 0;
            this.Location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.White;
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.SearchBar.ForeColor = System.Drawing.Color.Black;
            this.SearchBar.Location = new System.Drawing.Point(717, 3);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(282, 29);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.Text = "Search";
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Click);
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBar_KeyPress);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // tableContentLayout
            // 
            this.tableContentLayout.ColumnCount = 2;
            this.tableContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.95808F));
            this.tableContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.04192F));
            this.tableContentLayout.Controls.Add(this.ContentGrid, 1, 0);
            this.tableContentLayout.Controls.Add(this.fileTreeView, 0, 0);
            this.tableContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContentLayout.Location = new System.Drawing.Point(3, 43);
            this.tableContentLayout.Name = "tableContentLayout";
            this.tableContentLayout.RowCount = 1;
            this.tableContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContentLayout.Size = new System.Drawing.Size(1002, 683);
            this.tableContentLayout.TabIndex = 1;
            // 
            // ContentGrid
            // 
            this.ContentGrid.AllowUserToAddRows = false;
            this.ContentGrid.AllowUserToDeleteRows = false;
            this.ContentGrid.AllowUserToResizeColumns = false;
            this.ContentGrid.AllowUserToResizeRows = false;
            this.ContentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContentGrid.BackgroundColor = System.Drawing.Color.White;
            this.ContentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ContentGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconGrd,
            this.NameGrd,
            this.DateGrd,
            this.SizeGrd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ContentGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ContentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ContentGrid.GridColor = System.Drawing.Color.White;
            this.ContentGrid.Location = new System.Drawing.Point(212, 3);
            this.ContentGrid.Name = "ContentGrid";
            this.ContentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ContentGrid.RowHeadersVisible = false;
            this.ContentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContentGrid.ShowCellErrors = false;
            this.ContentGrid.ShowCellToolTips = false;
            this.ContentGrid.ShowEditingIcon = false;
            this.ContentGrid.ShowRowErrors = false;
            this.ContentGrid.Size = new System.Drawing.Size(787, 677);
            this.ContentGrid.TabIndex = 7;
            this.ContentGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContentGrid_CellMouseDoubleClick);
            this.ContentGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContentGrid_CellMouseDown);
            this.ContentGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContentGrid_MouseClick);
            // 
            // IconGrd
            // 
            this.IconGrd.FillWeight = 8F;
            this.IconGrd.HeaderText = "";
            this.IconGrd.Name = "IconGrd";
            this.IconGrd.ReadOnly = true;
            this.IconGrd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IconGrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NameGrd
            // 
            this.NameGrd.HeaderText = "Name";
            this.NameGrd.Name = "NameGrd";
            this.NameGrd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateGrd
            // 
            this.DateGrd.HeaderText = "Date Modified";
            this.DateGrd.Name = "DateGrd";
            this.DateGrd.ReadOnly = true;
            // 
            // SizeGrd
            // 
            this.SizeGrd.HeaderText = "Size";
            this.SizeGrd.Name = "SizeGrd";
            this.SizeGrd.ReadOnly = true;
            // 
            // fileTreeView
            // 
            this.fileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTreeView.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.fileTreeView.FullRowSelect = true;
            this.fileTreeView.ImageIndex = 0;
            this.fileTreeView.ImageList = this.fileImageTreeList;
            this.fileTreeView.Location = new System.Drawing.Point(3, 3);
            this.fileTreeView.Name = "fileTreeView";
            this.fileTreeView.SelectedImageIndex = 0;
            this.fileTreeView.ShowLines = false;
            this.fileTreeView.Size = new System.Drawing.Size(203, 677);
            this.fileTreeView.TabIndex = 8;
            this.fileTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // fileImageTreeList
            // 
            this.fileImageTreeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileImageTreeList.ImageStream")));
            this.fileImageTreeList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileImageTreeList.Images.SetKeyName(0, "Display001-4.png");
            this.fileImageTreeList.Images.SetKeyName(1, "DD011-4.png");
            this.fileImageTreeList.Images.SetKeyName(2, "Disc008-4.png");
            this.fileImageTreeList.Images.SetKeyName(3, "DD012-4.png");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 240;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Modified";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 241;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 240;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 241;
            // 
            // File_explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "File_explorer";
            this.Text = "Computer";
            this.Load += new System.EventHandler(this.File_explorer_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.tableHeaderLayout.ResumeLayout(false);
            this.tableHeaderLayout.PerformLayout();
            this.tableContentLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Header;
        private System.Windows.Forms.TableLayoutPanel tableHeaderLayout;
        private System.Windows.Forms.Button button2;
        private new System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableContentLayout;
        public System.Windows.Forms.DataGridView ContentGrid;
        private System.Windows.Forms.TreeView fileTreeView;
        private System.Windows.Forms.DataGridViewImageColumn IconGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeGrd;
        private System.Windows.Forms.ImageList fileImageTreeList;
    }
}