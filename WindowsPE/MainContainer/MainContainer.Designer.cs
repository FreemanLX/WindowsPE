namespace WindowsPE.MainContainer
{
    partial class MainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            this.ActivityList = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startPictureBox = new System.Windows.Forms.PictureBox();
            this.EthernetPictureBox = new System.Windows.Forms.PictureBox();
            this.TaskbarContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ContainerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FormContainer = new System.Windows.Forms.Panel();
            this.ActivityList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EthernetPictureBox)).BeginInit();
            this.ContainerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivityList
            // 
            this.ActivityList.BackColor = System.Drawing.Color.Black;
            this.ActivityList.Controls.Add(this.tableLayoutPanel1);
            this.ActivityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivityList.Location = new System.Drawing.Point(0, 679);
            this.ActivityList.Margin = new System.Windows.Forms.Padding(0);
            this.ActivityList.Name = "ActivityList";
            this.ActivityList.Size = new System.Drawing.Size(1008, 50);
            this.ActivityList.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.startPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EthernetPictureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TaskbarContainer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 50);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // startPictureBox
            // 
            this.startPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.startPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startPictureBox.BackgroundImage")));
            this.startPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPictureBox.Location = new System.Drawing.Point(0, 0);
            this.startPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.startPictureBox.Name = "startPictureBox";
            this.startPictureBox.Size = new System.Drawing.Size(60, 50);
            this.startPictureBox.TabIndex = 11;
            this.startPictureBox.TabStop = false;
            this.startPictureBox.Click += new System.EventHandler(this.startPictureBox_Click);
            this.startPictureBox.MouseLeave += new System.EventHandler(this.startPictureBox_MouseLeave);
            this.startPictureBox.MouseHover += new System.EventHandler(this.startPictureBox_MouseHover);
            // 
            // EthernetPictureBox
            // 
            this.EthernetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EthernetPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EthernetPictureBox.BackgroundImage")));
            this.EthernetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EthernetPictureBox.Location = new System.Drawing.Point(951, 3);
            this.EthernetPictureBox.Name = "EthernetPictureBox";
            this.EthernetPictureBox.Size = new System.Drawing.Size(54, 43);
            this.EthernetPictureBox.TabIndex = 10;
            this.EthernetPictureBox.TabStop = false;
            this.EthernetPictureBox.MouseLeave += new System.EventHandler(this.EthernetPictureBox_MouseLeave);
            this.EthernetPictureBox.MouseHover += new System.EventHandler(this.EthernetPictureBox_MouseHover);
            // 
            // TaskbarContainer
            // 
            this.TaskbarContainer.ColumnCount = 1;
            this.TaskbarContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TaskbarContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskbarContainer.Location = new System.Drawing.Point(63, 3);
            this.TaskbarContainer.Name = "TaskbarContainer";
            this.TaskbarContainer.RowCount = 1;
            this.TaskbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TaskbarContainer.Size = new System.Drawing.Size(882, 44);
            this.TaskbarContainer.TabIndex = 12;
            // 
            // ContainerLayout
            // 
            this.ContainerLayout.BackColor = System.Drawing.Color.Transparent;
            this.ContainerLayout.ColumnCount = 1;
            this.ContainerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContainerLayout.Controls.Add(this.ActivityList, 0, 1);
            this.ContainerLayout.Controls.Add(this.FormContainer, 0, 0);
            this.ContainerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerLayout.Location = new System.Drawing.Point(0, 0);
            this.ContainerLayout.Name = "ContainerLayout";
            this.ContainerLayout.RowCount = 2;
            this.ContainerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContainerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ContainerLayout.Size = new System.Drawing.Size(1008, 729);
            this.ContainerLayout.TabIndex = 18;
            // 
            // FormContainer
            // 
            this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer.Location = new System.Drawing.Point(0, 0);
            this.FormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(1008, 679);
            this.FormContainer.TabIndex = 18;
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ContainerLayout);
            this.Name = "MainContainer";
            this.Text = "MainContainer";
            this.Load += new System.EventHandler(this.MainContainer_Load);
            this.ActivityList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EthernetPictureBox)).EndInit();
            this.ContainerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ActivityList;
        private System.Windows.Forms.PictureBox EthernetPictureBox;
        private System.Windows.Forms.TableLayoutPanel ContainerLayout;
        private System.Windows.Forms.Panel FormContainer;
        private System.Windows.Forms.PictureBox startPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel TaskbarContainer;
    }
}