namespace WindowsFormsApp1
{
    partial class mapForm
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapForm));
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mapPanel = new System.Windows.Forms.Panel();
            this.sfMap1 = new EGIS.Controls.SFMap();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.History = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.setBoundaries = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminTools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customize_view = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.floorDroplist = new Bunifu.Framework.UI.BunifuDropdown();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.search_image = new Bunifu.Framework.UI.BunifuImageButton();
            this.mapWindow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NottificationButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotificationText = new System.Windows.Forms.RichTextBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.countNotification = new System.Windows.Forms.Label();
            this.loginForm1 = new WindowsFormsApp1.loginForm();
            this.customizedView1 = new WindowsFormsApp1.CustomizedView();
            this.boundaryControl1 = new WindowsFormsApp1.boundaryControl();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mapPanel.SuspendLayout();
            this.sideMenu.SuspendLayout();
            this.NotificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NottificationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.header.Controls.Add(this.bunifuImageButton4);
            this.header.Controls.Add(this.bunifuImageButton3);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.panelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(972, 41);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton4.Location = new System.Drawing.Point(882, 13);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(23, 23);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 4;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 20;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton3.Location = new System.Drawing.Point(911, 13);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(23, 23);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 3;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton2.Location = new System.Drawing.Point(940, 11);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.logoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(205, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Indoor positioning system";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mapPanel
            // 
            this.mapPanel.Controls.Add(this.sfMap1);
            this.mapPanel.Controls.Add(this.loginForm1);
            this.mapPanel.Controls.Add(this.customizedView1);
            this.mapPanel.Controls.Add(this.boundaryControl1);
            this.panelAnimator.SetDecoration(this.mapPanel, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.mapPanel, BunifuAnimatorNS.DecorationType.None);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(292, 41);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(680, 537);
            this.mapPanel.TabIndex = 2;
            // 
            // sfMap1
            // 
            this.sfMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMap1.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMap1.CentrePoint2D")));
            this.panelAnimator.SetDecoration(this.sfMap1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.sfMap1, BunifuAnimatorNS.DecorationType.None);
            this.sfMap1.Location = new System.Drawing.Point(0, 0);
            this.sfMap1.MapBackColor = System.Drawing.SystemColors.Control;
            this.sfMap1.Name = "sfMap1";
            this.sfMap1.PanSelectMode = EGIS.Controls.PanSelectMode.Pan;
            this.sfMap1.RenderQuality = EGIS.ShapeFileLib.RenderQuality.Auto;
            this.sfMap1.Size = new System.Drawing.Size(677, 534);
            this.sfMap1.TabIndex = 2;
            this.sfMap1.UseMercatorProjection = false;
            this.sfMap1.ZoomLevel = 1D;
            this.sfMap1.ZoomToSelectedExtentWhenCtrlKeydown = false;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation2;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.countNotification);
            this.sideMenu.Controls.Add(this.controlPanel);
            this.sideMenu.Controls.Add(this.NotificationPanel);
            this.sideMenu.Controls.Add(this.RefreshButton);
            this.sideMenu.Controls.Add(this.NottificationButton);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.sideMenu.Controls.Add(this.logo);
            this.panelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 41);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(292, 537);
            this.sideMenu.TabIndex = 0;
            this.sideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NotificationPanel.Controls.Add(this.NotificationText);
            this.panelAnimator.SetDecoration(this.NotificationPanel, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.NotificationPanel, BunifuAnimatorNS.DecorationType.None);
            this.NotificationPanel.Location = new System.Drawing.Point(0, 164);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(292, 370);
            this.NotificationPanel.TabIndex = 12;
            // 
            // History
            // 
            this.History.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.History.BorderRadius = 0;
            this.History.ButtonText = "    History";
            this.History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.History, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.History, BunifuAnimatorNS.DecorationType.None);
            this.History.DisabledColor = System.Drawing.Color.Gray;
            this.History.Iconcolor = System.Drawing.Color.Transparent;
            this.History.Iconimage = ((System.Drawing.Image)(resources.GetObject("History.Iconimage")));
            this.History.Iconimage_right = null;
            this.History.Iconimage_right_Selected = null;
            this.History.Iconimage_Selected = null;
            this.History.IconMarginLeft = 0;
            this.History.IconMarginRight = 0;
            this.History.IconRightVisible = true;
            this.History.IconRightZoom = 0D;
            this.History.IconVisible = true;
            this.History.IconZoom = 80D;
            this.History.IsTab = true;
            this.History.Location = new System.Drawing.Point(3, 314);
            this.History.Name = "History";
            this.History.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.History.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.History.OnHoverTextColor = System.Drawing.Color.White;
            this.History.selected = false;
            this.History.Size = new System.Drawing.Size(277, 48);
            this.History.TabIndex = 11;
            this.History.Text = "    History";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.Textcolor = System.Drawing.Color.White;
            this.History.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // RefreshButton
            // 
            this.logoAnimator.SetDecoration(this.RefreshButton, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.RefreshButton, BunifuAnimatorNS.DecorationType.None);
            this.RefreshButton.Location = new System.Drawing.Point(107, 119);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Full Extent";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // setBoundaries
            // 
            this.setBoundaries.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.setBoundaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.setBoundaries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setBoundaries.BorderRadius = 0;
            this.setBoundaries.ButtonText = "    Set Boundaries";
            this.setBoundaries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.setBoundaries, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.setBoundaries, BunifuAnimatorNS.DecorationType.None);
            this.setBoundaries.DisabledColor = System.Drawing.Color.Gray;
            this.setBoundaries.Iconcolor = System.Drawing.Color.Transparent;
            this.setBoundaries.Iconimage = ((System.Drawing.Image)(resources.GetObject("setBoundaries.Iconimage")));
            this.setBoundaries.Iconimage_right = null;
            this.setBoundaries.Iconimage_right_Selected = null;
            this.setBoundaries.Iconimage_Selected = null;
            this.setBoundaries.IconMarginLeft = 0;
            this.setBoundaries.IconMarginRight = 0;
            this.setBoundaries.IconRightVisible = true;
            this.setBoundaries.IconRightZoom = 0D;
            this.setBoundaries.IconVisible = true;
            this.setBoundaries.IconZoom = 80D;
            this.setBoundaries.IsTab = true;
            this.setBoundaries.Location = new System.Drawing.Point(3, 260);
            this.setBoundaries.Name = "setBoundaries";
            this.setBoundaries.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.setBoundaries.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.setBoundaries.OnHoverTextColor = System.Drawing.Color.White;
            this.setBoundaries.selected = false;
            this.setBoundaries.Size = new System.Drawing.Size(277, 48);
            this.setBoundaries.TabIndex = 9;
            this.setBoundaries.Text = "    Set Boundaries";
            this.setBoundaries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setBoundaries.Textcolor = System.Drawing.Color.White;
            this.setBoundaries.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBoundaries.Click += new System.EventHandler(this.setBoundaries_Click);
            // 
            // adminTools
            // 
            this.adminTools.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.adminTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.adminTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminTools.BorderRadius = 0;
            this.adminTools.ButtonText = "    Admin Tools";
            this.adminTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.adminTools, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.adminTools, BunifuAnimatorNS.DecorationType.None);
            this.adminTools.DisabledColor = System.Drawing.Color.Gray;
            this.adminTools.Iconcolor = System.Drawing.Color.Transparent;
            this.adminTools.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminTools.Iconimage")));
            this.adminTools.Iconimage_right = null;
            this.adminTools.Iconimage_right_Selected = null;
            this.adminTools.Iconimage_Selected = null;
            this.adminTools.IconMarginLeft = 0;
            this.adminTools.IconMarginRight = 0;
            this.adminTools.IconRightVisible = true;
            this.adminTools.IconRightZoom = 0D;
            this.adminTools.IconVisible = true;
            this.adminTools.IconZoom = 80D;
            this.adminTools.IsTab = true;
            this.adminTools.Location = new System.Drawing.Point(3, 206);
            this.adminTools.Name = "adminTools";
            this.adminTools.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.adminTools.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.adminTools.OnHoverTextColor = System.Drawing.Color.White;
            this.adminTools.selected = false;
            this.adminTools.Size = new System.Drawing.Size(277, 48);
            this.adminTools.TabIndex = 8;
            this.adminTools.Text = "    Admin Tools";
            this.adminTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminTools.Textcolor = System.Drawing.Color.White;
            this.adminTools.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTools.Click += new System.EventHandler(this.adminTools_Click);
            // 
            // customize_view
            // 
            this.customize_view.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.customize_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.customize_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customize_view.BorderRadius = 0;
            this.customize_view.ButtonText = "    Customize View";
            this.customize_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.customize_view, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.customize_view, BunifuAnimatorNS.DecorationType.None);
            this.customize_view.DisabledColor = System.Drawing.Color.Gray;
            this.customize_view.Iconcolor = System.Drawing.Color.Transparent;
            this.customize_view.Iconimage = ((System.Drawing.Image)(resources.GetObject("customize_view.Iconimage")));
            this.customize_view.Iconimage_right = null;
            this.customize_view.Iconimage_right_Selected = null;
            this.customize_view.Iconimage_Selected = null;
            this.customize_view.IconMarginLeft = 0;
            this.customize_view.IconMarginRight = 0;
            this.customize_view.IconRightVisible = true;
            this.customize_view.IconRightZoom = 0D;
            this.customize_view.IconVisible = true;
            this.customize_view.IconZoom = 90D;
            this.customize_view.IsTab = true;
            this.customize_view.Location = new System.Drawing.Point(3, 152);
            this.customize_view.Name = "customize_view";
            this.customize_view.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.customize_view.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.customize_view.OnHoverTextColor = System.Drawing.Color.White;
            this.customize_view.selected = false;
            this.customize_view.Size = new System.Drawing.Size(277, 48);
            this.customize_view.TabIndex = 7;
            this.customize_view.Text = "    Customize View";
            this.customize_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customize_view.Textcolor = System.Drawing.Color.White;
            this.customize_view.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customize_view.Click += new System.EventHandler(this.customize_view_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton1.Location = new System.Drawing.Point(15, 60);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // floorDroplist
            // 
            this.floorDroplist.BackColor = System.Drawing.Color.Transparent;
            this.floorDroplist.BorderRadius = 3;
            this.logoAnimator.SetDecoration(this.floorDroplist, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.floorDroplist, BunifuAnimatorNS.DecorationType.None);
            this.floorDroplist.DisabledColor = System.Drawing.Color.Gray;
            this.floorDroplist.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.floorDroplist.ForeColor = System.Drawing.Color.White;
            this.floorDroplist.Items = new string[0];
            this.floorDroplist.Location = new System.Drawing.Point(60, 60);
            this.floorDroplist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.floorDroplist.Name = "floorDroplist";
            this.floorDroplist.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.floorDroplist.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.floorDroplist.selectedIndex = -1;
            this.floorDroplist.Size = new System.Drawing.Size(194, 32);
            this.floorDroplist.TabIndex = 5;
            // 
            // searchBox
            // 
            this.searchBox.AccessibleDescription = "";
            this.searchBox.AccessibleName = "";
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelAnimator.SetDecoration(this.searchBox, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.searchBox, BunifuAnimatorNS.DecorationType.None);
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.HintForeColor = System.Drawing.Color.White;
            this.searchBox.HintText = "Search Devices ...";
            this.searchBox.isPassword = false;
            this.searchBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.searchBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.searchBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.searchBox.LineThickness = 3;
            this.searchBox.Location = new System.Drawing.Point(60, 17);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 33);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // search_image
            // 
            this.search_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.search_image, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.search_image, BunifuAnimatorNS.DecorationType.None);
            this.search_image.Image = ((System.Drawing.Image)(resources.GetObject("search_image.Image")));
            this.search_image.ImageActive = null;
            this.search_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search_image.Location = new System.Drawing.Point(15, 17);
            this.search_image.Name = "search_image";
            this.search_image.Size = new System.Drawing.Size(31, 32);
            this.search_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_image.TabIndex = 4;
            this.search_image.TabStop = false;
            this.search_image.Zoom = 20;
            this.search_image.Click += new System.EventHandler(this.search_image_Click);
            // 
            // mapWindow
            // 
            this.mapWindow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.mapWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mapWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapWindow.BorderRadius = 0;
            this.mapWindow.ButtonText = "    Map";
            this.mapWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.mapWindow, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.mapWindow, BunifuAnimatorNS.DecorationType.None);
            this.mapWindow.DisabledColor = System.Drawing.Color.Gray;
            this.mapWindow.Iconcolor = System.Drawing.Color.Transparent;
            this.mapWindow.Iconimage = ((System.Drawing.Image)(resources.GetObject("mapWindow.Iconimage")));
            this.mapWindow.Iconimage_right = null;
            this.mapWindow.Iconimage_right_Selected = null;
            this.mapWindow.Iconimage_Selected = null;
            this.mapWindow.IconMarginLeft = 0;
            this.mapWindow.IconMarginRight = 0;
            this.mapWindow.IconRightVisible = true;
            this.mapWindow.IconRightZoom = 0D;
            this.mapWindow.IconVisible = true;
            this.mapWindow.IconZoom = 70D;
            this.mapWindow.IsTab = true;
            this.mapWindow.Location = new System.Drawing.Point(6, 98);
            this.mapWindow.Name = "mapWindow";
            this.mapWindow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mapWindow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.mapWindow.OnHoverTextColor = System.Drawing.Color.White;
            this.mapWindow.selected = false;
            this.mapWindow.Size = new System.Drawing.Size(277, 48);
            this.mapWindow.TabIndex = 3;
            this.mapWindow.Text = "    Map";
            this.mapWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mapWindow.Textcolor = System.Drawing.Color.White;
            this.mapWindow.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapWindow.Click += new System.EventHandler(this.map_Click);
            // 
            // NottificationButton
            // 
            this.NottificationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NottificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.NottificationButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.NottificationButton, BunifuAnimatorNS.DecorationType.None);
            this.NottificationButton.Image = global::WindowsFormsApp1.Properties.Resources.bell_256;
            this.NottificationButton.ImageActive = null;
            this.NottificationButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NottificationButton.Location = new System.Drawing.Point(246, 71);
            this.NottificationButton.Name = "NottificationButton";
            this.NottificationButton.Size = new System.Drawing.Size(34, 34);
            this.NottificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NottificationButton.TabIndex = 1;
            this.NottificationButton.TabStop = false;
            this.NottificationButton.Zoom = 10;
            this.NottificationButton.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMenu.Location = new System.Drawing.Point(255, 28);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo.Location = new System.Drawing.Point(50, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(153, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.panelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Indoor Positioning System";
            this.notifyIcon1.Visible = true;
            // 
            // NotificationText
            // 
            this.NotificationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NotificationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelAnimator.SetDecoration(this.NotificationText, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.NotificationText, BunifuAnimatorNS.DecorationType.None);
            this.NotificationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationText.ForeColor = System.Drawing.Color.White;
            this.NotificationText.Location = new System.Drawing.Point(0, 0);
            this.NotificationText.Name = "NotificationText";
            this.NotificationText.ReadOnly = true;
            this.NotificationText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NotificationText.Size = new System.Drawing.Size(292, 370);
            this.NotificationText.TabIndex = 0;
            this.NotificationText.Text = "";
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlPanel.Controls.Add(this.History);
            this.controlPanel.Controls.Add(this.setBoundaries);
            this.controlPanel.Controls.Add(this.adminTools);
            this.controlPanel.Controls.Add(this.customize_view);
            this.controlPanel.Controls.Add(this.bunifuImageButton1);
            this.controlPanel.Controls.Add(this.floorDroplist);
            this.controlPanel.Controls.Add(this.searchBox);
            this.controlPanel.Controls.Add(this.search_image);
            this.controlPanel.Controls.Add(this.mapWindow);
            this.panelAnimator.SetDecoration(this.controlPanel, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.controlPanel, BunifuAnimatorNS.DecorationType.None);
            this.controlPanel.Location = new System.Drawing.Point(0, 161);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(292, 376);
            this.controlPanel.TabIndex = 13;
            // 
            // countNotification
            // 
            this.countNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countNotification.BackColor = System.Drawing.Color.Red;
            this.logoAnimator.SetDecoration(this.countNotification, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.countNotification, BunifuAnimatorNS.DecorationType.None);
            this.countNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNotification.ForeColor = System.Drawing.Color.White;
            this.countNotification.Location = new System.Drawing.Point(255, 94);
            this.countNotification.Name = "countNotification";
            this.countNotification.Size = new System.Drawing.Size(37, 25);
            this.countNotification.TabIndex = 14;
            this.countNotification.Text = "label1";
            this.countNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countNotification.Visible = false;
            // 
            // loginForm1
            // 
            this.loginForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoAnimator.SetDecoration(this.loginForm1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.loginForm1, BunifuAnimatorNS.DecorationType.None);
            this.loginForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginForm1.Location = new System.Drawing.Point(0, 0);
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Size = new System.Drawing.Size(680, 537);
            this.loginForm1.TabIndex = 1;
            this.loginForm1.Load += new System.EventHandler(this.loginForm1_Load);
            // 
            // customizedView1
            // 
            this.customizedView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customizedView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoAnimator.SetDecoration(this.customizedView1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.customizedView1, BunifuAnimatorNS.DecorationType.None);
            this.customizedView1.Location = new System.Drawing.Point(0, 0);
            this.customizedView1.Name = "customizedView1";
            this.customizedView1.Size = new System.Drawing.Size(677, 534);
            this.customizedView1.TabIndex = 12;
            // 
            // boundaryControl1
            // 
            this.boundaryControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boundaryControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoAnimator.SetDecoration(this.boundaryControl1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.boundaryControl1, BunifuAnimatorNS.DecorationType.None);
            this.boundaryControl1.Location = new System.Drawing.Point(0, 1);
            this.boundaryControl1.Name = "boundaryControl1";
            this.boundaryControl1.Size = new System.Drawing.Size(677, 534);
            this.boundaryControl1.TabIndex = 12;
            // 
            // mapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(972, 578);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mapForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mapPanel.ResumeLayout(false);
            this.sideMenu.ResumeLayout(false);
            this.NotificationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NottificationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel mapPanel;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton adminTools;
        private Bunifu.Framework.UI.BunifuFlatButton customize_view;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDropdown floorDroplist;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private Bunifu.Framework.UI.BunifuImageButton search_image;
        private Bunifu.Framework.UI.BunifuFlatButton mapWindow;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox logo;
        private loginForm loginForm1;
        private Bunifu.Framework.UI.BunifuFlatButton setBoundaries;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private EGIS.Controls.SFMap sfMap1;
        private System.Windows.Forms.Button RefreshButton;
        private Bunifu.Framework.UI.BunifuFlatButton History;
        private CustomizedView customizedView1;
        private boundaryControl boundaryControl1;
        private Bunifu.Framework.UI.BunifuImageButton NottificationButton;
        private System.Windows.Forms.Panel NotificationPanel;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RichTextBox NotificationText;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label countNotification;
    }
}

