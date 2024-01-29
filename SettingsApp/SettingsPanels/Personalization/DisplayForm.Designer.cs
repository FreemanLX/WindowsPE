namespace WindowsPE.Settings
{
    partial class DisplayForm
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
            this.displaySettingsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayHeaderLayout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayResPanel = new System.Windows.Forms.Panel();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.displayResNameLabel = new System.Windows.Forms.Label();
            this.displayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.displayContainerPanel = new System.Windows.Forms.Panel();
            this.displaysFormContainers = new System.Windows.Forms.TableLayoutPanel();
            this.displayButtonsPanel = new System.Windows.Forms.Panel();
            this.DisplayBtnLayout = new System.Windows.Forms.Panel();
            this.detectBtn = new System.Windows.Forms.Button();
            this.identifyBtn = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.displaySettingsLayout.SuspendLayout();
            this.DisplayHeaderLayout.SuspendLayout();
            this.DisplayResPanel.SuspendLayout();
            this.displayLayout.SuspendLayout();
            this.displayContainerPanel.SuspendLayout();
            this.displayButtonsPanel.SuspendLayout();
            this.DisplayBtnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaySettingsLayout
            // 
            this.displaySettingsLayout.ColumnCount = 1;
            this.displaySettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.displaySettingsLayout.Controls.Add(this.DisplayHeaderLayout, 0, 0);
            this.displaySettingsLayout.Controls.Add(this.DisplayResPanel, 0, 2);
            this.displaySettingsLayout.Controls.Add(this.displayLayout, 0, 1);
            this.displaySettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaySettingsLayout.Location = new System.Drawing.Point(0, 0);
            this.displaySettingsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.displaySettingsLayout.Name = "displaySettingsLayout";
            this.displaySettingsLayout.RowCount = 3;
            this.displaySettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.displaySettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.displaySettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.displaySettingsLayout.Size = new System.Drawing.Size(934, 535);
            this.displaySettingsLayout.TabIndex = 0;
            // 
            // DisplayHeaderLayout
            // 
            this.DisplayHeaderLayout.Controls.Add(this.label1);
            this.DisplayHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayHeaderLayout.Location = new System.Drawing.Point(0, 0);
            this.DisplayHeaderLayout.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayHeaderLayout.Name = "DisplayHeaderLayout";
            this.DisplayHeaderLayout.Size = new System.Drawing.Size(934, 70);
            this.DisplayHeaderLayout.TabIndex = 0;
            this.DisplayHeaderLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayHeaderLayout_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display settings";
            // 
            // DisplayResPanel
            // 
            this.DisplayResPanel.Controls.Add(this.ResolutionComboBox);
            this.DisplayResPanel.Controls.Add(this.displayResNameLabel);
            this.DisplayResPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayResPanel.Location = new System.Drawing.Point(0, 435);
            this.DisplayResPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayResPanel.Name = "DisplayResPanel";
            this.DisplayResPanel.Size = new System.Drawing.Size(934, 100);
            this.DisplayResPanel.TabIndex = 13;
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.Location = new System.Drawing.Point(32, 56);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(220, 29);
            this.ResolutionComboBox.TabIndex = 12;
            this.ResolutionComboBox.Text = "%combo%";
            this.ResolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionComboBox_SelectedIndexChanged);
            // 
            // displayResNameLabel
            // 
            this.displayResNameLabel.AutoSize = true;
            this.displayResNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.displayResNameLabel.Location = new System.Drawing.Point(28, 13);
            this.displayResNameLabel.Name = "displayResNameLabel";
            this.displayResNameLabel.Size = new System.Drawing.Size(160, 28);
            this.displayResNameLabel.TabIndex = 11;
            this.displayResNameLabel.Text = "Display resolution";
            // 
            // displayLayout
            // 
            this.displayLayout.ColumnCount = 1;
            this.displayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.displayLayout.Controls.Add(this.displayContainerPanel, 0, 0);
            this.displayLayout.Controls.Add(this.displayButtonsPanel, 0, 1);
            this.displayLayout.Location = new System.Drawing.Point(3, 73);
            this.displayLayout.Name = "displayLayout";
            this.displayLayout.RowCount = 2;
            this.displayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.displayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayLayout.Size = new System.Drawing.Size(928, 359);
            this.displayLayout.TabIndex = 14;
            // 
            // displayContainerPanel
            // 
            this.displayContainerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.displayContainerPanel.Controls.Add(this.displaysFormContainers);
            this.displayContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayContainerPanel.Location = new System.Drawing.Point(30, 3);
            this.displayContainerPanel.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.displayContainerPanel.Name = "displayContainerPanel";
            this.displayContainerPanel.Size = new System.Drawing.Size(868, 263);
            this.displayContainerPanel.TabIndex = 0;
            // 
            // displaysFormContainers
            // 
            this.displaysFormContainers.ColumnCount = 2;
            this.displaysFormContainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displaysFormContainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displaysFormContainers.Location = new System.Drawing.Point(42, 0);
            this.displaysFormContainers.Margin = new System.Windows.Forms.Padding(0);
            this.displaysFormContainers.Name = "displaysFormContainers";
            this.displaysFormContainers.RowCount = 2;
            this.displaysFormContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displaysFormContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displaysFormContainers.Size = new System.Drawing.Size(765, 263);
            this.displaysFormContainers.TabIndex = 0;
            // 
            // displayButtonsPanel
            // 
            this.displayButtonsPanel.Controls.Add(this.DisplayBtnLayout);
            this.displayButtonsPanel.Controls.Add(this.browseButton);
            this.displayButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayButtonsPanel.Location = new System.Drawing.Point(3, 272);
            this.displayButtonsPanel.Name = "displayButtonsPanel";
            this.displayButtonsPanel.Size = new System.Drawing.Size(922, 44);
            this.displayButtonsPanel.TabIndex = 1;
            // 
            // DisplayBtnLayout
            // 
            this.DisplayBtnLayout.Controls.Add(this.detectBtn);
            this.DisplayBtnLayout.Controls.Add(this.identifyBtn);
            this.DisplayBtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayBtnLayout.Location = new System.Drawing.Point(0, 0);
            this.DisplayBtnLayout.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayBtnLayout.Name = "DisplayBtnLayout";
            this.DisplayBtnLayout.Size = new System.Drawing.Size(922, 44);
            this.DisplayBtnLayout.TabIndex = 23;
            // 
            // detectBtn
            // 
            this.detectBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.detectBtn.FlatAppearance.BorderSize = 0;
            this.detectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectBtn.ForeColor = System.Drawing.Color.Black;
            this.detectBtn.Location = new System.Drawing.Point(120, 7);
            this.detectBtn.Name = "detectBtn";
            this.detectBtn.Size = new System.Drawing.Size(88, 32);
            this.detectBtn.TabIndex = 23;
            this.detectBtn.Text = "Detect";
            this.detectBtn.UseVisualStyleBackColor = false;
            // 
            // identifyBtn
            // 
            this.identifyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.identifyBtn.FlatAppearance.BorderSize = 0;
            this.identifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.identifyBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyBtn.ForeColor = System.Drawing.Color.Black;
            this.identifyBtn.Location = new System.Drawing.Point(26, 7);
            this.identifyBtn.Name = "identifyBtn";
            this.identifyBtn.Size = new System.Drawing.Size(88, 32);
            this.identifyBtn.TabIndex = 22;
            this.identifyBtn.Text = "Identify";
            this.identifyBtn.UseVisualStyleBackColor = false;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(720, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(99, 34);
            this.browseButton.TabIndex = 22;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.displaySettingsLayout);
            this.Name = "DisplayForm";
            this.Size = new System.Drawing.Size(934, 535);
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.displaySettingsLayout.ResumeLayout(false);
            this.DisplayHeaderLayout.ResumeLayout(false);
            this.DisplayHeaderLayout.PerformLayout();
            this.DisplayResPanel.ResumeLayout(false);
            this.DisplayResPanel.PerformLayout();
            this.displayLayout.ResumeLayout(false);
            this.displayContainerPanel.ResumeLayout(false);
            this.displayButtonsPanel.ResumeLayout(false);
            this.DisplayBtnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel displaySettingsLayout;
        private System.Windows.Forms.Panel DisplayHeaderLayout;
        private System.Windows.Forms.Panel DisplayResPanel;
        private System.Windows.Forms.ComboBox ResolutionComboBox;
        private System.Windows.Forms.Label displayResNameLabel;
        private System.Windows.Forms.TableLayoutPanel displayLayout;
        private System.Windows.Forms.Panel displayContainerPanel;
        private System.Windows.Forms.Panel displayButtonsPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Panel DisplayBtnLayout;
        private System.Windows.Forms.Button detectBtn;
        private System.Windows.Forms.Button identifyBtn;
        private System.Windows.Forms.TableLayoutPanel displaysFormContainers;
        private System.Windows.Forms.Label label1;
    }
}
