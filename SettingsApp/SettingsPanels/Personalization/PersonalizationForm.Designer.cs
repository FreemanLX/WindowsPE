namespace WindowsPE
{
    partial class PersonalizationForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.BackgroundFitComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BackgroundPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.browseButton);
            this.panel2.Controls.Add(this.BackgroundFitComboBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BackgroundPreview);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 535);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Browse to the picture or video to make it your desktop background.";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.browseButton.Location = new System.Drawing.Point(315, 140);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(88, 32);
            this.browseButton.TabIndex = 21;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.ChangeBackgroundButton_Click);
            // 
            // BackgroundFitComboBox
            // 
            this.BackgroundFitComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundFitComboBox.FormattingEnabled = true;
            this.BackgroundFitComboBox.Items.AddRange(new object[] {
            "Stretch",
            "Fill",
            "Fit",
            "Tile",
            "Center"});
            this.BackgroundFitComboBox.Location = new System.Drawing.Point(315, 246);
            this.BackgroundFitComboBox.Name = "BackgroundFitComboBox";
            this.BackgroundFitComboBox.Size = new System.Drawing.Size(211, 29);
            this.BackgroundFitComboBox.TabIndex = 20;
            this.BackgroundFitComboBox.Text = "Stretch";
            this.BackgroundFitComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedFit_IndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label8.Location = new System.Drawing.Point(311, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Choose a fit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label7.Location = new System.Drawing.Point(311, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Choose your picture";
            // 
            // BackgroundPreview
            // 
            this.BackgroundPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundPreview.Location = new System.Drawing.Point(29, 107);
            this.BackgroundPreview.Name = "BackgroundPreview";
            this.BackgroundPreview.Size = new System.Drawing.Size(265, 177);
            this.BackgroundPreview.TabIndex = 16;
            this.BackgroundPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a desktop background";
            // 
            // PersonalizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "PersonalizationForm";
            this.Size = new System.Drawing.Size(934, 535);
            this.Load += new System.EventHandler(this.PersonalizationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackgroundPreview;
        private System.Windows.Forms.ComboBox BackgroundFitComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
    }
}
