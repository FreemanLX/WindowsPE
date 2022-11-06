namespace WindowsPE
{
    partial class Startmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startmenu));
            this.startMenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.FileExplorer = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Power = new System.Windows.Forms.PictureBox();
            this.ApplicationsContext = new WindowsPE.CustomPanel();
            this.startMenuLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.SuspendLayout();
            // 
            // startMenuLayout
            // 
            this.startMenuLayout.BackColor = System.Drawing.Color.Transparent;
            this.startMenuLayout.ColumnCount = 2;
            this.startMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.startMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startMenuLayout.Controls.Add(this.panel1, 0, 0);
            this.startMenuLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.startMenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startMenuLayout.Location = new System.Drawing.Point(0, 0);
            this.startMenuLayout.Name = "startMenuLayout";
            this.startMenuLayout.RowCount = 1;
            this.startMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startMenuLayout.Size = new System.Drawing.Size(384, 661);
            this.startMenuLayout.TabIndex = 0;
            this.startMenuLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.startMenuLayout_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 661);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FileExplorer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Settings, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Power, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(50, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.searchText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ApplicationsContext, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 655);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // searchText
            // 
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic);
            this.searchText.Location = new System.Drawing.Point(3, 620);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(322, 32);
            this.searchText.TabIndex = 3;
            this.searchText.Text = "What do you want to search?";
            this.searchText.Click += new System.EventHandler(this.searchText_Click);
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // FileExplorer
            // 
            this.FileExplorer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FileExplorer.BackgroundImage")));
            this.FileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.Location = new System.Drawing.Point(3, 584);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(44, 34);
            this.FileExplorer.TabIndex = 6;
            this.FileExplorer.TabStop = false;
            this.FileExplorer.Click += new System.EventHandler(this.FileExplorer_Click_1);
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(3, 544);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(44, 34);
            this.Settings.TabIndex = 5;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click_1);
            // 
            // Power
            // 
            this.Power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Power.BackgroundImage")));
            this.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Power.Location = new System.Drawing.Point(3, 624);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(44, 34);
            this.Power.TabIndex = 4;
            this.Power.TabStop = false;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // ApplicationsContext
            // 
            this.ApplicationsContext.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationsContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplicationsContext.Location = new System.Drawing.Point(0, 0);
            this.ApplicationsContext.Margin = new System.Windows.Forms.Padding(0);
            this.ApplicationsContext.Name = "ApplicationsContext";
            this.ApplicationsContext.Size = new System.Drawing.Size(328, 617);
            this.ApplicationsContext.TabIndex = 2;
            // 
            // Startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.startMenuLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Startmenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Startmenu";
            this.Load += new System.EventHandler(this.Startmenu_Load);
            this.startMenuLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel startMenuLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox FileExplorer;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.PictureBox Power;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomPanel ApplicationsContext;
        private System.Windows.Forms.TextBox searchText;
    }
}