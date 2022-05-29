namespace Browser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StartButton = new System.Windows.Forms.Button();
            this.EthernetPictureBox = new System.Windows.Forms.PictureBox();
            this.ActivityList = new System.Windows.Forms.Panel();
            this.labelMJS1 = new Browser.LabelMJS();
            this.metro2 = new Browser.Metro();
            this.MetroObject = new Browser.Metro();
            ((System.ComponentModel.ISupportInitialize)(this.EthernetPictureBox)).BeginInit();
            this.ActivityList.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.Transparent;
            this.StartButton.Location = new System.Drawing.Point(19, 345);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(40, 40);
            this.StartButton.TabIndex = 4;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EthernetPictureBox
            // 
            this.EthernetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EthernetPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EthernetPictureBox.BackgroundImage")));
            this.EthernetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EthernetPictureBox.Location = new System.Drawing.Point(19, 676);
            this.EthernetPictureBox.Name = "EthernetPictureBox";
            this.EthernetPictureBox.Size = new System.Drawing.Size(40, 40);
            this.EthernetPictureBox.TabIndex = 10;
            this.EthernetPictureBox.TabStop = false;
            // 
            // ActivityList
            // 
            this.ActivityList.BackColor = System.Drawing.Color.Black;
            this.ActivityList.Controls.Add(this.StartButton);
            this.ActivityList.Controls.Add(this.EthernetPictureBox);
            this.ActivityList.Location = new System.Drawing.Point(937, 1);
            this.ActivityList.Name = "ActivityList";
            this.ActivityList.Size = new System.Drawing.Size(72, 728);
            this.ActivityList.TabIndex = 15;
            this.ActivityList.Visible = false;
            // 
            // labelMJS1
            // 
            this.labelMJS1.AutoSize = true;
            this.labelMJS1.BackColor = System.Drawing.Color.Transparent;
            this.labelMJS1.DrawingDirection = Browser.LabelMJS.Angles.LeftToRight;
            this.labelMJS1.EnableGradient = false;
            this.labelMJS1.EnableShadow = true;
            this.labelMJS1.EndColor = System.Drawing.Color.White;
            this.labelMJS1.EndColorAlpha = 255;
            this.labelMJS1.Font = new System.Drawing.Font("Segoe UI Semilight", 28F);
            this.labelMJS1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMJS1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.labelMJS1.Location = new System.Drawing.Point(38, 31);
            this.labelMJS1.Name = "labelMJS1";
            this.labelMJS1.ShadowColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMJS1.ShadowOffset = 1;
            this.labelMJS1.Size = new System.Drawing.Size(98, 51);
            this.labelMJS1.StartColor = System.Drawing.Color.Red;
            this.labelMJS1.StartColorAlpha = 255;
            this.labelMJS1.TabIndex = 14;
            this.labelMJS1.Text = "Start";
            // 
            // metro2
            // 
            this.metro2.AutoScroll = true;
            this.metro2.BackColor = System.Drawing.Color.Transparent;
            this.metro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metro2.Location = new System.Drawing.Point(63, 49);
            this.metro2.Name = "metro2";
            this.metro2.Size = new System.Drawing.Size(8, 8);
            this.metro2.TabIndex = 13;
            // 
            // MetroObject
            // 
            this.MetroObject.AutoScroll = true;
            this.MetroObject.BackColor = System.Drawing.Color.Transparent;
            this.MetroObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MetroObject.Location = new System.Drawing.Point(26, 95);
            this.MetroObject.Name = "MetroObject";
            this.MetroObject.Size = new System.Drawing.Size(808, 569);
            this.MetroObject.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ActivityList);
            this.Controls.Add(this.labelMJS1);
            this.Controls.Add(this.metro2);
            this.Controls.Add(this.MetroObject);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.EthernetPictureBox)).EndInit();
            this.ActivityList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox EthernetPictureBox;
        private Metro MetroObject;
        private Metro metro2;
        private LabelMJS labelMJS1;
        private System.Windows.Forms.Panel ActivityList;
    }
}

