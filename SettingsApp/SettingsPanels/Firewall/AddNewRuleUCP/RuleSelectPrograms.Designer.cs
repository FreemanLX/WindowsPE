namespace WindowsPE.Settings.Firewall.AddNewRule
{
    partial class RuleSelectPrograms
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
            this.InfoText = new System.Windows.Forms.Label();
            this.radioAllPrograms = new System.Windows.Forms.RadioButton();
            this.radioSpecificProgram = new System.Windows.Forms.RadioButton();
            this.programPath = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoText.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoText.Location = new System.Drawing.Point(15, 19);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(363, 19);
            this.InfoText.TabIndex = 9;
            this.InfoText.Text = "Does this rule apply to all programs or a specific program?";
            // 
            // radioAllPrograms
            // 
            this.radioAllPrograms.AutoSize = true;
            this.radioAllPrograms.Checked = true;
            this.radioAllPrograms.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioAllPrograms.Location = new System.Drawing.Point(19, 56);
            this.radioAllPrograms.Name = "radioAllPrograms";
            this.radioAllPrograms.Size = new System.Drawing.Size(93, 19);
            this.radioAllPrograms.TabIndex = 10;
            this.radioAllPrograms.TabStop = true;
            this.radioAllPrograms.Text = "All programs";
            this.radioAllPrograms.UseVisualStyleBackColor = true;
            // 
            // radioSpecificProgram
            // 
            this.radioSpecificProgram.AutoSize = true;
            this.radioSpecificProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioSpecificProgram.Location = new System.Drawing.Point(19, 125);
            this.radioSpecificProgram.Name = "radioSpecificProgram";
            this.radioSpecificProgram.Size = new System.Drawing.Size(116, 19);
            this.radioSpecificProgram.TabIndex = 11;
            this.radioSpecificProgram.TabStop = true;
            this.radioSpecificProgram.Text = "Specific program";
            this.radioSpecificProgram.UseVisualStyleBackColor = true;
            this.radioSpecificProgram.CheckedChanged += new System.EventHandler(this.radioSpecificProgram_CheckedChanged);
            // 
            // programPath
            // 
            this.programPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.programPath.Enabled = false;
            this.programPath.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.programPath.Location = new System.Drawing.Point(21, 148);
            this.programPath.Name = "programPath";
            this.programPath.Size = new System.Drawing.Size(357, 22);
            this.programPath.TabIndex = 12;
            this.programPath.TextChanged += new System.EventHandler(this.programPath_TextChanged);
            // 
            // browseBtn
            // 
            this.browseBtn.Enabled = false;
            this.browseBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.browseBtn.Location = new System.Drawing.Point(384, 148);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 13;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rule applies to all programs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rule applies to the selected program\r\nExample:  %systemroot%\\path\\program.exe\r\n  " +
    "                X:\\path\\program.exe";
            // 
            // RuleSelectPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.programPath);
            this.Controls.Add(this.radioSpecificProgram);
            this.Controls.Add(this.radioAllPrograms);
            this.Controls.Add(this.InfoText);
            this.Name = "RuleSelectPrograms";
            this.Size = new System.Drawing.Size(470, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.RadioButton radioAllPrograms;
        private System.Windows.Forms.RadioButton radioSpecificProgram;
        private System.Windows.Forms.TextBox programPath;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
