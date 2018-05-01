namespace WindowsFormsApp1 {
    partial class History_Galal {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Galal));
            this.sfMap1 = new EGIS.Controls.SFMap();
            this.timeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.SlowerButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlayButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.FasterButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.zoomOut = new System.Windows.Forms.Button();
            this.speedText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.totalTimeText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.floorDropList = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.SlowerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FasterButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sfMap1
            // 
            this.sfMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMap1.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMap1.CentrePoint2D")));
            this.sfMap1.Location = new System.Drawing.Point(0, 0);
            this.sfMap1.MapBackColor = System.Drawing.SystemColors.Control;
            this.sfMap1.Name = "sfMap1";
            this.sfMap1.PanSelectMode = EGIS.Controls.PanSelectMode.Pan;
            this.sfMap1.RenderQuality = EGIS.ShapeFileLib.RenderQuality.Auto;
            this.sfMap1.Size = new System.Drawing.Size(680, 519);
            this.sfMap1.TabIndex = 0;
            this.sfMap1.UseMercatorProjection = false;
            this.sfMap1.ZoomLevel = 1D;
            this.sfMap1.ZoomToSelectedExtentWhenCtrlKeydown = false;
            // 
            // timeSlider
            // 
            this.timeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSlider.BackColor = System.Drawing.SystemColors.Control;
            this.timeSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.timeSlider.BorderRadius = 0;
            this.timeSlider.IndicatorColor = System.Drawing.Color.Cyan;
            this.timeSlider.Location = new System.Drawing.Point(220, 467);
            this.timeSlider.MaximumValue = 100;
            this.timeSlider.Name = "timeSlider";
            this.timeSlider.Size = new System.Drawing.Size(415, 30);
            this.timeSlider.TabIndex = 1;
            this.timeSlider.Value = 0;
            // 
            // SlowerButton
            // 
            this.SlowerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SlowerButton.BackColor = System.Drawing.SystemColors.Control;
            this.SlowerButton.Image = global::WindowsFormsApp1.Properties.Resources.Play_blue_icons_0007_Layer_8;
            this.SlowerButton.ImageActive = null;
            this.SlowerButton.Location = new System.Drawing.Point(48, 455);
            this.SlowerButton.Name = "SlowerButton";
            this.SlowerButton.Size = new System.Drawing.Size(42, 40);
            this.SlowerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SlowerButton.TabIndex = 2;
            this.SlowerButton.TabStop = false;
            this.SlowerButton.Zoom = 10;
            this.SlowerButton.Click += new System.EventHandler(this.SlowerButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayButton.BackColor = System.Drawing.SystemColors.Control;
            this.PlayButton.Image = global::WindowsFormsApp1.Properties.Resources.Play_blue_icons_0008_Layer_9;
            this.PlayButton.ImageActive = null;
            this.PlayButton.Location = new System.Drawing.Point(96, 455);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(42, 40);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayButton.TabIndex = 2;
            this.PlayButton.TabStop = false;
            this.PlayButton.Zoom = 10;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // FasterButton
            // 
            this.FasterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FasterButton.BackColor = System.Drawing.SystemColors.Control;
            this.FasterButton.Image = global::WindowsFormsApp1.Properties.Resources.Play_blue_icons_0006_Layer_7;
            this.FasterButton.ImageActive = null;
            this.FasterButton.Location = new System.Drawing.Point(144, 455);
            this.FasterButton.Name = "FasterButton";
            this.FasterButton.Size = new System.Drawing.Size(42, 40);
            this.FasterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FasterButton.TabIndex = 2;
            this.FasterButton.TabStop = false;
            this.FasterButton.Zoom = 10;
            this.FasterButton.Click += new System.EventHandler(this.FasterButton_Click);
            // 
            // timeText
            // 
            this.timeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeText.AutoSize = true;
            this.timeText.BackColor = System.Drawing.SystemColors.Control;
            this.timeText.Location = new System.Drawing.Point(217, 451);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(73, 13);
            this.timeText.TabIndex = 3;
            this.timeText.Text = "Running Time";
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(3, 112);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(75, 23);
            this.zoomOut.TabIndex = 5;
            this.zoomOut.Text = "Zoom Out";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // speedText
            // 
            this.speedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedText.AutoSize = true;
            this.speedText.BackColor = System.Drawing.SystemColors.Control;
            this.speedText.Location = new System.Drawing.Point(91, 434);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(38, 13);
            this.speedText.TabIndex = 3;
            this.speedText.Text = "Speed";
            // 
            // totalTimeText
            // 
            this.totalTimeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTimeText.AutoSize = true;
            this.totalTimeText.BackColor = System.Drawing.SystemColors.Control;
            this.totalTimeText.Location = new System.Drawing.Point(530, 451);
            this.totalTimeText.Name = "totalTimeText";
            this.totalTimeText.Size = new System.Drawing.Size(57, 13);
            this.totalTimeText.TabIndex = 3;
            this.totalTimeText.Text = "Total Time";
            // 
            // floorDropList
            // 
            this.floorDropList.BackColor = System.Drawing.Color.Transparent;
            this.floorDropList.BorderRadius = 3;
            this.floorDropList.DisabledColor = System.Drawing.Color.Gray;
            this.floorDropList.ForeColor = System.Drawing.Color.White;
            this.floorDropList.Items = new string[0];
            this.floorDropList.Location = new System.Drawing.Point(3, 81);
            this.floorDropList.Name = "floorDropList";
            this.floorDropList.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.floorDropList.onHoverColor = System.Drawing.Color.Teal;
            this.floorDropList.selectedIndex = -1;
            this.floorDropList.Size = new System.Drawing.Size(119, 25);
            this.floorDropList.TabIndex = 6;
            // 
            // History_Galal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.floorDropList);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.speedText);
            this.Controls.Add(this.totalTimeText);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.FasterButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SlowerButton);
            this.Controls.Add(this.timeSlider);
            this.Controls.Add(this.sfMap1);
            this.Name = "History_Galal";
            this.Size = new System.Drawing.Size(680, 519);
            ((System.ComponentModel.ISupportInitialize)(this.SlowerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FasterButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EGIS.Controls.SFMap sfMap1;
        private Bunifu.Framework.UI.BunifuSlider timeSlider;
        private Bunifu.Framework.UI.BunifuImageButton SlowerButton;
        private Bunifu.Framework.UI.BunifuImageButton PlayButton;
        private Bunifu.Framework.UI.BunifuImageButton FasterButton;
        private Bunifu.Framework.UI.BunifuCustomLabel timeText;
        private System.Windows.Forms.Button zoomOut;
        private Bunifu.Framework.UI.BunifuCustomLabel speedText;
        private Bunifu.Framework.UI.BunifuCustomLabel totalTimeText;
        private Bunifu.Framework.UI.BunifuDropdown floorDropList;
    }
}
