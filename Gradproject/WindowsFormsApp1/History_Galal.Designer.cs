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
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.SlowerButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlayButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.FasterButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TimeText = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SlowerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FasterButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sfMap1
            // 
            this.sfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMap1.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMap1.CentrePoint2D")));
            this.sfMap1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // bunifuSlider1
            // 
            this.bunifuSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSlider1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.Cyan;
            this.bunifuSlider1.Location = new System.Drawing.Point(220, 467);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(415, 30);
            this.bunifuSlider1.TabIndex = 1;
            this.bunifuSlider1.Value = 0;
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
            // 
            // TimeText
            // 
            this.TimeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.SystemColors.Control;
            this.TimeText.Location = new System.Drawing.Point(217, 451);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(54, 13);
            this.TimeText.TabIndex = 3;
            this.TimeText.Text = "Time here";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.FasterButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SlowerButton);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.sfMap1);
            this.Name = "History";
            this.Size = new System.Drawing.Size(680, 519);
            ((System.ComponentModel.ISupportInitialize)(this.SlowerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FasterButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EGIS.Controls.SFMap sfMap1;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuImageButton SlowerButton;
        private Bunifu.Framework.UI.BunifuImageButton PlayButton;
        private Bunifu.Framework.UI.BunifuImageButton FasterButton;
        private Bunifu.Framework.UI.BunifuCustomLabel TimeText;
    }
}
