namespace WindowsPE.Settings
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.containerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerFwdBtn = new System.Windows.Forms.Button();
            this.headerBackBtn = new System.Windows.Forms.Button();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.containerLayout.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerLayout
            // 
            this.containerLayout.BackColor = System.Drawing.Color.Transparent;
            this.containerLayout.ColumnCount = 1;
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerLayout.Controls.Add(this.SettingsPanel, 0, 1);
            this.containerLayout.Controls.Add(this.headerLayout, 0, 0);
            this.containerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerLayout.Location = new System.Drawing.Point(0, 0);
            this.containerLayout.Name = "containerLayout";
            this.containerLayout.RowCount = 2;
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerLayout.Size = new System.Drawing.Size(1048, 749);
            this.containerLayout.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPanel.BackColor = System.Drawing.Color.White;
            this.SettingsPanel.ColumnCount = 1;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsPanel.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 41);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 1;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Size = new System.Drawing.Size(1048, 708);
            this.SettingsPanel.TabIndex = 3;
            // 
            // headerLayout
            // 
            this.headerLayout.BackColor = System.Drawing.Color.White;
            this.headerLayout.ColumnCount = 3;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerLayout.Controls.Add(this.headerFwdBtn, 0, 0);
            this.headerLayout.Controls.Add(this.headerBackBtn, 1, 0);
            this.headerLayout.Controls.Add(this.entryTextBox, 2, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(3, 3);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(1042, 35);
            this.headerLayout.TabIndex = 4;
            // 
            // headerFwdBtn
            // 
            this.headerFwdBtn.BackColor = System.Drawing.Color.White;
            this.headerFwdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerFwdBtn.BackgroundImage")));
            this.headerFwdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.headerFwdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerFwdBtn.FlatAppearance.BorderSize = 0;
            this.headerFwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerFwdBtn.ForeColor = System.Drawing.Color.Black;
            this.headerFwdBtn.Location = new System.Drawing.Point(3, 3);
            this.headerFwdBtn.Name = "headerFwdBtn";
            this.headerFwdBtn.Size = new System.Drawing.Size(34, 29);
            this.headerFwdBtn.TabIndex = 4;
            this.headerFwdBtn.UseVisualStyleBackColor = false;
            this.headerFwdBtn.Click += new System.EventHandler(this.headerFwdBtn_Click);
            // 
            // headerBackBtn
            // 
            this.headerBackBtn.BackColor = System.Drawing.Color.White;
            this.headerBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerBackBtn.BackgroundImage")));
            this.headerBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.headerBackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerBackBtn.FlatAppearance.BorderSize = 0;
            this.headerBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerBackBtn.ForeColor = System.Drawing.Color.Black;
            this.headerBackBtn.Location = new System.Drawing.Point(43, 3);
            this.headerBackBtn.Name = "headerBackBtn";
            this.headerBackBtn.Size = new System.Drawing.Size(34, 29);
            this.headerBackBtn.TabIndex = 3;
            this.headerBackBtn.UseVisualStyleBackColor = false;
            this.headerBackBtn.Click += new System.EventHandler(this.headerBackBtn_Click);
            // 
            // entryTextBox
            // 
            this.entryTextBox.BackColor = System.Drawing.Color.White;
            this.entryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.entryTextBox.Location = new System.Drawing.Point(83, 3);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(956, 29);
            this.entryTextBox.TabIndex = 5;
            this.entryTextBox.Text = "Control Panel";
            this.entryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryTextBox_KeyDown);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 749);
            this.Controls.Add(this.containerLayout);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.containerLayout.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerLayout;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Button headerBackBtn;
        private System.Windows.Forms.Button headerFwdBtn;
        private System.Windows.Forms.TextBox entryTextBox;
    }
}