namespace ProfilerBySSFProject
{
    partial class MainFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFRM));
            this.panelParcel = new System.Windows.Forms.Panel();
            this.picCamLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.listViewIPChannel = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelParcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParcel
            // 
            this.panelParcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(130)))));
            this.panelParcel.Controls.Add(this.picCamLeft);
            this.panelParcel.Controls.Add(this.pictureBox6);
            this.panelParcel.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelParcel.ForeColor = System.Drawing.Color.White;
            this.panelParcel.Location = new System.Drawing.Point(12, 12);
            this.panelParcel.Name = "panelParcel";
            this.panelParcel.Size = new System.Drawing.Size(757, 664);
            this.panelParcel.TabIndex = 87;
            // 
            // picCamLeft
            // 
            this.picCamLeft.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.picCamLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCamLeft.Image = ((System.Drawing.Image)(resources.GetObject("picCamLeft.Image")));
            this.picCamLeft.Location = new System.Drawing.Point(0, 0);
            this.picCamLeft.Margin = new System.Windows.Forms.Padding(4);
            this.picCamLeft.Name = "picCamLeft";
            this.picCamLeft.Size = new System.Drawing.Size(757, 664);
            this.picCamLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamLeft.TabIndex = 107;
            this.picCamLeft.TabStop = false;
            this.picCamLeft.Click += new System.EventHandler(this.picCamLeft_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(130)))));
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(325, 254);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 86;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // listViewIPChannel
            // 
            this.listViewIPChannel.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewIPChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIPChannel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.listViewIPChannel.Enabled = false;
            this.listViewIPChannel.FullRowSelect = true;
            this.listViewIPChannel.GridLines = true;
            this.listViewIPChannel.Location = new System.Drawing.Point(-259, -172);
            this.listViewIPChannel.Margin = new System.Windows.Forms.Padding(4);
            this.listViewIPChannel.MultiSelect = false;
            this.listViewIPChannel.Name = "listViewIPChannel";
            this.listViewIPChannel.Size = new System.Drawing.Size(201, 68);
            this.listViewIPChannel.TabIndex = 106;
            this.listViewIPChannel.UseCompatibleStateImageBehavior = false;
            this.listViewIPChannel.View = System.Windows.Forms.View.Details;
            this.listViewIPChannel.Visible = false;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Channel";
            this.ColumnHeader1.Width = 90;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Status";
            this.ColumnHeader2.Width = 90;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(781, 12);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(125, 103);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 108;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "click on image to shot";
            // 
            // MainFRM
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(912, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.listViewIPChannel);
            this.Controls.Add(this.panelParcel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "MainFRM";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتصال به دوربین Raster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFRM_FormClosing);
            this.Load += new System.EventHandler(this.MainFRM_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFRM_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFRM_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainFRM_DragOver);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFRM_KeyUp);
            this.panelParcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCamLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panelParcel;
        private System.Windows.Forms.ListView listViewIPChannel;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.PictureBox picCamLeft;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label1;
    }
}