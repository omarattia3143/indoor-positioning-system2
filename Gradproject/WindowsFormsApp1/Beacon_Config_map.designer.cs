namespace WindowsFormsApp1 {
    partial class Beacon_Config_map {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beacon_Config_map));
            this.sfMap1 = new EGIS.Controls.SFMap();
            this.zoomOut = new System.Windows.Forms.Button();
            this.floorDropList = new Bunifu.Framework.UI.BunifuDropdown();
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
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(3, 112);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(75, 23);
            this.zoomOut.TabIndex = 5;
            this.zoomOut.Text = "Full Extent";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Visible = false;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
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
            this.floorDropList.Visible = false;
            // 
            // Beacon_Config_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.floorDropList);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.sfMap1);
            this.Name = "Beacon_Config_map";
            this.Size = new System.Drawing.Size(680, 519);
            this.ResumeLayout(false);

        }

        #endregion

        public EGIS.Controls.SFMap sfMap1;
        private System.Windows.Forms.Button zoomOut;
        private Bunifu.Framework.UI.BunifuDropdown floorDropList;
    }
}
