namespace $rootnamespace$
{
    partial class $safeitemname$
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof($safeitemname$));
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mapPanel = new System.Windows.Forms.Panel();
            this.map = new System.Windows.Forms.PictureBox();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.adminTools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customize_view = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.floorDroplist = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.search_image = new Bunifu.Framework.UI.BunifuImageButton();
            this.mapWindow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.loginForm1 = new $rootnamespace$.loginForm();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
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
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
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
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
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
            this.mapPanel.Controls.Add(this.map);
            this.mapPanel.Controls.Add(this.loginForm1);
            this.panelAnimator.SetDecoration(this.mapPanel, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.mapPanel, BunifuAnimatorNS.DecorationType.None);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(292, 41);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(680, 520);
            this.mapPanel.TabIndex = 2;
            // 
            // map
            // 
            this.logoAnimator.SetDecoration(this.map, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.map, BunifuAnimatorNS.DecorationType.None);
            this.map.Image = global::$rootnamespace$.Properties.Resources.Akoakoa_Plan_Main;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(652, 519);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0.5F;
            animation4.RotateLimit = 0.2F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation4;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.adminTools);
            this.sideMenu.Controls.Add(this.customize_view);
            this.sideMenu.Controls.Add(this.bunifuImageButton1);
            this.sideMenu.Controls.Add(this.floorDroplist);
            this.sideMenu.Controls.Add(this.bunifuMaterialTextbox1);
            this.sideMenu.Controls.Add(this.search_image);
            this.sideMenu.Controls.Add(this.mapWindow);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.sideMenu.Controls.Add(this.logo);
            this.panelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 41);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(292, 520);
            this.sideMenu.TabIndex = 0;
            this.sideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.adminTools.Location = new System.Drawing.Point(0, 360);
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
            this.customize_view.Location = new System.Drawing.Point(0, 306);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 214);
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
            this.floorDroplist.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorDroplist.ForeColor = System.Drawing.Color.White;
            this.floorDroplist.Items = new string[0];
            this.floorDroplist.Location = new System.Drawing.Point(57, 214);
            this.floorDroplist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.floorDroplist.Name = "floorDroplist";
            this.floorDroplist.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.floorDroplist.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.floorDroplist.selectedIndex = -1;
            this.floorDroplist.Size = new System.Drawing.Size(194, 32);
            this.floorDroplist.TabIndex = 5;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AccessibleDescription = "";
            this.bunifuMaterialTextbox1.AccessibleName = "";
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelAnimator.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "Search Devices ...";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(57, 171);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(228, 33);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // search_image
            // 
            this.search_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.search_image, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.search_image, BunifuAnimatorNS.DecorationType.None);
            this.search_image.Image = ((System.Drawing.Image)(resources.GetObject("search_image.Image")));
            this.search_image.ImageActive = null;
            this.search_image.Location = new System.Drawing.Point(12, 171);
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
            this.mapWindow.Location = new System.Drawing.Point(3, 252);
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
            this.mapWindow.Click += new System.EventHandler(this.customize_view_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation3;
            // 
            // loginForm1
            // 
            this.loginForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoAnimator.SetDecoration(this.loginForm1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.loginForm1, BunifuAnimatorNS.DecorationType.None);
            this.loginForm1.Location = new System.Drawing.Point(0, 3);
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Size = new System.Drawing.Size(680, 519);
            this.loginForm1.TabIndex = 1;
            // 
            // $safeitemname$
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(972, 561);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "$safeitemname$";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mapPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel mapPanel;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton adminTools;
        private Bunifu.Framework.UI.BunifuFlatButton customize_view;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDropdown floorDroplist;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton search_image;
        private Bunifu.Framework.UI.BunifuFlatButton mapWindow;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox logo;
        private loginForm loginForm1;
    }
}

