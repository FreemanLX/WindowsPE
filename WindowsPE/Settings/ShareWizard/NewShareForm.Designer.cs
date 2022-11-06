namespace WindowsPE.Settings
{
    partial class NewShareForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuPathLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ShareConfirmationBtn = new System.Windows.Forms.Label();
            this.shareNameBtn = new System.Windows.Forms.Label();
            this.shareLocationBtn = new System.Windows.Forms.Label();
            this.ShareWizard_Container = new System.Windows.Forms.Panel();
            this.newShareNameLayout = new System.Windows.Forms.Panel();
            this.titleNamePart = new System.Windows.Forms.Label();
            this.controlButtonsLayout = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuPathLayout.SuspendLayout();
            this.newShareNameLayout.SuspendLayout();
            this.controlButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newShareNameLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlButtonsLayout, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.menuPathLayout, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ShareWizard_Container, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 310);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menuPathLayout
            // 
            this.menuPathLayout.ColumnCount = 1;
            this.menuPathLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPathLayout.Controls.Add(this.ShareConfirmationBtn, 0, 2);
            this.menuPathLayout.Controls.Add(this.shareNameBtn, 0, 1);
            this.menuPathLayout.Controls.Add(this.shareLocationBtn, 0, 0);
            this.menuPathLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPathLayout.Location = new System.Drawing.Point(0, 0);
            this.menuPathLayout.Margin = new System.Windows.Forms.Padding(0);
            this.menuPathLayout.Name = "menuPathLayout";
            this.menuPathLayout.RowCount = 4;
            this.menuPathLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuPathLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuPathLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuPathLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPathLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuPathLayout.Size = new System.Drawing.Size(150, 310);
            this.menuPathLayout.TabIndex = 0;
            this.menuPathLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // ShareConfirmationBtn
            // 
            this.ShareConfirmationBtn.AutoSize = true;
            this.ShareConfirmationBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShareConfirmationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShareConfirmationBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.ShareConfirmationBtn.ForeColor = System.Drawing.Color.Black;
            this.ShareConfirmationBtn.Location = new System.Drawing.Point(3, 60);
            this.ShareConfirmationBtn.Name = "ShareConfirmationBtn";
            this.ShareConfirmationBtn.Size = new System.Drawing.Size(144, 30);
            this.ShareConfirmationBtn.TabIndex = 6;
            this.ShareConfirmationBtn.Text = "Confirmation";
            this.ShareConfirmationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shareNameBtn
            // 
            this.shareNameBtn.AutoSize = true;
            this.shareNameBtn.BackColor = System.Drawing.Color.Transparent;
            this.shareNameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareNameBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.shareNameBtn.ForeColor = System.Drawing.Color.Black;
            this.shareNameBtn.Location = new System.Drawing.Point(3, 30);
            this.shareNameBtn.Name = "shareNameBtn";
            this.shareNameBtn.Size = new System.Drawing.Size(144, 30);
            this.shareNameBtn.TabIndex = 4;
            this.shareNameBtn.Text = "Share Name";
            this.shareNameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shareLocationBtn
            // 
            this.shareLocationBtn.AutoSize = true;
            this.shareLocationBtn.BackColor = System.Drawing.Color.Transparent;
            this.shareLocationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareLocationBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.shareLocationBtn.ForeColor = System.Drawing.Color.Black;
            this.shareLocationBtn.Location = new System.Drawing.Point(3, 0);
            this.shareLocationBtn.Name = "shareLocationBtn";
            this.shareLocationBtn.Size = new System.Drawing.Size(144, 30);
            this.shareLocationBtn.TabIndex = 3;
            this.shareLocationBtn.Text = "Share Location";
            this.shareLocationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShareWizard_Container
            // 
            this.ShareWizard_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShareWizard_Container.Location = new System.Drawing.Point(150, 0);
            this.ShareWizard_Container.Margin = new System.Windows.Forms.Padding(0);
            this.ShareWizard_Container.Name = "ShareWizard_Container";
            this.ShareWizard_Container.Size = new System.Drawing.Size(428, 310);
            this.ShareWizard_Container.TabIndex = 1;
            // 
            // newShareNameLayout
            // 
            this.newShareNameLayout.Controls.Add(this.titleNamePart);
            this.newShareNameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newShareNameLayout.Location = new System.Drawing.Point(3, 3);
            this.newShareNameLayout.Name = "newShareNameLayout";
            this.newShareNameLayout.Size = new System.Drawing.Size(578, 69);
            this.newShareNameLayout.TabIndex = 1;
            // 
            // titleNamePart
            // 
            this.titleNamePart.AutoSize = true;
            this.titleNamePart.BackColor = System.Drawing.Color.Transparent;
            this.titleNamePart.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.titleNamePart.ForeColor = System.Drawing.Color.Black;
            this.titleNamePart.Location = new System.Drawing.Point(9, 18);
            this.titleNamePart.Name = "titleNamePart";
            this.titleNamePart.Size = new System.Drawing.Size(197, 32);
            this.titleNamePart.TabIndex = 2;
            this.titleNamePart.Text = "New share wizard";
            // 
            // controlButtonsLayout
            // 
            this.controlButtonsLayout.Controls.Add(this.cancelBtn);
            this.controlButtonsLayout.Controls.Add(this.createBtn);
            this.controlButtonsLayout.Controls.Add(this.nextBtn);
            this.controlButtonsLayout.Controls.Add(this.prevBtn);
            this.controlButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlButtonsLayout.Location = new System.Drawing.Point(3, 394);
            this.controlButtonsLayout.Name = "controlButtonsLayout";
            this.controlButtonsLayout.Size = new System.Drawing.Size(578, 44);
            this.controlButtonsLayout.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(485, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // createBtn
            // 
            this.createBtn.Enabled = false;
            this.createBtn.Location = new System.Drawing.Point(404, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(303, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next >";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Enabled = false;
            this.prevBtn.Location = new System.Drawing.Point(222, 12);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.Text = "< Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // NewShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewShareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Share Wizard";
            this.Load += new System.EventHandler(this.NewShareForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuPathLayout.ResumeLayout(false);
            this.menuPathLayout.PerformLayout();
            this.newShareNameLayout.ResumeLayout(false);
            this.newShareNameLayout.PerformLayout();
            this.controlButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel newShareNameLayout;
        private System.Windows.Forms.Label titleNamePart;
        private System.Windows.Forms.Panel controlButtonsLayout;
        private System.Windows.Forms.TableLayoutPanel menuPathLayout;
        private System.Windows.Forms.Label ShareConfirmationBtn;
        private System.Windows.Forms.Label shareNameBtn;
        private System.Windows.Forms.Label shareLocationBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Panel ShareWizard_Container;
    }
}