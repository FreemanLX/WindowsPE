namespace WindowsPE
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
            this.GeneralSettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.networkBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.personalizationBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BoxBar = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralSettingsPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.BoxBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralSettingsPanel
            // 
            this.GeneralSettingsPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GeneralSettingsPanel.ColumnCount = 1;
            this.GeneralSettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GeneralSettingsPanel.Controls.Add(this.networkBtn, 0, 1);
            this.GeneralSettingsPanel.Controls.Add(this.displayBtn, 0, 0);
            this.GeneralSettingsPanel.Controls.Add(this.personalizationBtn, 0, 2);
            this.GeneralSettingsPanel.Controls.Add(this.aboutBtn, 0, 5);
            this.GeneralSettingsPanel.Controls.Add(this.button1, 0, 3);
            this.GeneralSettingsPanel.Controls.Add(this.button2, 0, 4);
            this.GeneralSettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.GeneralSettingsPanel.Name = "GeneralSettingsPanel";
            this.GeneralSettingsPanel.RowCount = 7;
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GeneralSettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GeneralSettingsPanel.Size = new System.Drawing.Size(187, 549);
            this.GeneralSettingsPanel.TabIndex = 0;
            // 
            // networkBtn
            // 
            this.networkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkBtn.FlatAppearance.BorderSize = 0;
            this.networkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.networkBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkBtn.ForeColor = System.Drawing.Color.White;
            this.networkBtn.Location = new System.Drawing.Point(3, 53);
            this.networkBtn.Name = "networkBtn";
            this.networkBtn.Size = new System.Drawing.Size(181, 44);
            this.networkBtn.TabIndex = 1;
            this.networkBtn.Text = "Networking";
            this.networkBtn.UseVisualStyleBackColor = true;
            this.networkBtn.Click += new System.EventHandler(this.NetworkClick);
            // 
            // displayBtn
            // 
            this.displayBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBtn.FlatAppearance.BorderSize = 0;
            this.displayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.ForeColor = System.Drawing.Color.White;
            this.displayBtn.Location = new System.Drawing.Point(3, 3);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(181, 44);
            this.displayBtn.TabIndex = 0;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.DisplayClick);
            // 
            // personalizationBtn
            // 
            this.personalizationBtn.FlatAppearance.BorderSize = 0;
            this.personalizationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalizationBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.personalizationBtn.ForeColor = System.Drawing.Color.White;
            this.personalizationBtn.Location = new System.Drawing.Point(3, 103);
            this.personalizationBtn.Name = "personalizationBtn";
            this.personalizationBtn.Size = new System.Drawing.Size(181, 44);
            this.personalizationBtn.TabIndex = 4;
            this.personalizationBtn.Text = "Theme";
            this.personalizationBtn.UseVisualStyleBackColor = true;
            this.personalizationBtn.Click += new System.EventHandler(this.personalizationBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Location = new System.Drawing.Point(3, 253);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(181, 44);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Firewall";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "File sharing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.White;
            this.SettingsPanel.ColumnCount = 2;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Controls.Add(this.GeneralSettingsPanel, 0, 0);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 33);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 1;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 555F));
            this.SettingsPanel.Size = new System.Drawing.Size(1219, 523);
            this.SettingsPanel.TabIndex = 0;
            this.SettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsPanel_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BoxBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SettingsPanel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1225, 559);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BoxBar
            // 
            this.BoxBar.BackColor = System.Drawing.Color.White;
            this.BoxBar.ColumnCount = 3;
            this.BoxBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BoxBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BoxBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BoxBar.Controls.Add(this.button5, 1, 0);
            this.BoxBar.Controls.Add(this.button6, 2, 0);
            this.BoxBar.Controls.Add(this.label1, 0, 0);
            this.BoxBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxBar.Location = new System.Drawing.Point(3, 3);
            this.BoxBar.Name = "BoxBar";
            this.BoxBar.RowCount = 1;
            this.BoxBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BoxBar.Size = new System.Drawing.Size(1219, 24);
            this.BoxBar.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1142, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 18);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(1182, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 18);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ExitClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1225, 559);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.GeneralSettingsPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.BoxBar.ResumeLayout(false);
            this.BoxBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GeneralSettingsPanel;
        private System.Windows.Forms.Button networkBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel BoxBar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personalizationBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}