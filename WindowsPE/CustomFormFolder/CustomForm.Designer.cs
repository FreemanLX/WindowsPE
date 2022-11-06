namespace WindowsPE
{
    partial class CustomForm
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

        public override string Text
        {
            get
            {
               return "FORM";
            }
            set
            {
                Title.Text = value;
            }
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formContainer = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TitleHeaderPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.FormStatePanel = new System.Windows.Forms.Panel();
            this.ControlsContainer = new System.Windows.Forms.Panel();
            this.formContainer.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.TitleHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.formContainer.ColumnCount = 1;
            this.formContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formContainer.Controls.Add(this.headerLayout, 0, 0);
            this.formContainer.Controls.Add(this.ControlsContainer, 0, 1);
            this.formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainer.Location = new System.Drawing.Point(0, 0);
            this.formContainer.Name = "formContainer";
            this.formContainer.RowCount = 2;
            this.formContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.formContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formContainer.Size = new System.Drawing.Size(800, 450);
            this.formContainer.TabIndex = 0;
            // 
            // headerLayout
            // 
            this.headerLayout.ColumnCount = 2;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.headerLayout.Controls.Add(this.TitleHeaderPanel, 0, 0);
            this.headerLayout.Controls.Add(this.FormStatePanel, 1, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(3, 3);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(794, 44);
            this.headerLayout.TabIndex = 0;
            // 
            // TitleHeaderPanel
            // 
            this.TitleHeaderPanel.Controls.Add(this.Title);
            this.TitleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleHeaderPanel.Name = "TitleHeaderPanel";
            this.TitleHeaderPanel.Size = new System.Drawing.Size(704, 44);
            this.TitleHeaderPanel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.Title.Location = new System.Drawing.Point(23, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(68, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Form";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormStatePanel
            // 
            this.FormStatePanel.Location = new System.Drawing.Point(704, 0);
            this.FormStatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormStatePanel.Name = "FormStatePanel";
            this.FormStatePanel.Size = new System.Drawing.Size(90, 44);
            this.FormStatePanel.TabIndex = 1;
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsContainer.Location = new System.Drawing.Point(0, 50);
            this.ControlsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ControlsContainer.Name = "ControlsContainer";
            this.ControlsContainer.Size = new System.Drawing.Size(800, 400);
            this.ControlsContainer.TabIndex = 1;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomForm";
            this.Load += new System.EventHandler(this.CustomForm_Load);
            this.formContainer.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.TitleHeaderPanel.ResumeLayout(false);
            this.TitleHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formContainer;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Panel TitleHeaderPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel ControlsContainer;
        private System.Windows.Forms.Panel FormStatePanel;
    }
}