namespace WindowsFormsApp1
{
    partial class admin_tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_tools));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.image1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.usersBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.createAdmin = new WindowsFormsApp1.createAdmin();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkViolet;
            this.header.Controls.Add(this.minimize);
            this.header.Controls.Add(this.image1);
            this.header.Controls.Add(this.bunifuImageButton3);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(639, 41);
            this.header.TabIndex = 1;
            // 
            // image1
            // 
            this.image1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.image1.BackColor = System.Drawing.Color.DarkViolet;
            this.image1.Image = ((System.Drawing.Image)(resources.GetObject("image1.Image")));
            this.image1.ImageActive = null;
            this.image1.Location = new System.Drawing.Point(602, 10);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(25, 25);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 0;
            this.image1.TabStop = false;
            this.image1.Zoom = 20;
            this.image1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.DarkViolet;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton3.Location = new System.Drawing.Point(573, 12);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(23, 23);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 5;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // pictureBox2
            // 
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
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(205, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Indoor positioning system";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.groupsBtn);
            this.bunifuGradientPanel1.Controls.Add(this.usersBtn);
            this.bunifuGradientPanel1.Controls.Add(this.adminBtn);
            this.bunifuGradientPanel1.Controls.Add(this.createAdmin);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 41);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(639, 520);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // groupsBtn
            // 
            this.groupsBtn.Activecolor = System.Drawing.Color.DarkOrchid;
            this.groupsBtn.BackColor = System.Drawing.Color.Transparent;
            this.groupsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupsBtn.BorderRadius = 0;
            this.groupsBtn.ButtonText = "Create,Edit and Delete Groups";
            this.groupsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.groupsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.groupsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("groupsBtn.Iconimage")));
            this.groupsBtn.Iconimage_right = null;
            this.groupsBtn.Iconimage_right_Selected = null;
            this.groupsBtn.Iconimage_Selected = null;
            this.groupsBtn.IconMarginLeft = 0;
            this.groupsBtn.IconMarginRight = 0;
            this.groupsBtn.IconRightVisible = true;
            this.groupsBtn.IconRightZoom = 0D;
            this.groupsBtn.IconVisible = true;
            this.groupsBtn.IconZoom = 90D;
            this.groupsBtn.IsTab = false;
            this.groupsBtn.Location = new System.Drawing.Point(187, 265);
            this.groupsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.groupsBtn.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.groupsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.groupsBtn.selected = false;
            this.groupsBtn.Size = new System.Drawing.Size(281, 48);
            this.groupsBtn.TabIndex = 2;
            this.groupsBtn.Text = "Create,Edit and Delete Groups";
            this.groupsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsBtn.Textcolor = System.Drawing.Color.White;
            this.groupsBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // usersBtn
            // 
            this.usersBtn.Activecolor = System.Drawing.Color.DarkOrchid;
            this.usersBtn.BackColor = System.Drawing.Color.Transparent;
            this.usersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersBtn.BorderRadius = 0;
            this.usersBtn.ButtonText = "Create,Edit and Delete Users";
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.DisabledColor = System.Drawing.Color.Gray;
            this.usersBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.usersBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("usersBtn.Iconimage")));
            this.usersBtn.Iconimage_right = null;
            this.usersBtn.Iconimage_right_Selected = null;
            this.usersBtn.Iconimage_Selected = null;
            this.usersBtn.IconMarginLeft = 0;
            this.usersBtn.IconMarginRight = 0;
            this.usersBtn.IconRightVisible = true;
            this.usersBtn.IconRightZoom = 0D;
            this.usersBtn.IconVisible = true;
            this.usersBtn.IconZoom = 90D;
            this.usersBtn.IsTab = false;
            this.usersBtn.Location = new System.Drawing.Point(187, 168);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.usersBtn.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.usersBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.usersBtn.selected = false;
            this.usersBtn.Size = new System.Drawing.Size(281, 48);
            this.usersBtn.TabIndex = 1;
            this.usersBtn.Text = "Create,Edit and Delete Users";
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.Textcolor = System.Drawing.Color.White;
            this.usersBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // adminBtn
            // 
            this.adminBtn.Activecolor = System.Drawing.Color.DarkOrchid;
            this.adminBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminBtn.BorderRadius = 0;
            this.adminBtn.ButtonText = "Create, Delete Admin";
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.DisabledColor = System.Drawing.Color.Gray;
            this.adminBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.adminBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminBtn.Iconimage")));
            this.adminBtn.Iconimage_right = null;
            this.adminBtn.Iconimage_right_Selected = null;
            this.adminBtn.Iconimage_Selected = null;
            this.adminBtn.IconMarginLeft = 0;
            this.adminBtn.IconMarginRight = 0;
            this.adminBtn.IconRightVisible = true;
            this.adminBtn.IconRightZoom = 0D;
            this.adminBtn.IconVisible = true;
            this.adminBtn.IconZoom = 90D;
            this.adminBtn.IsTab = false;
            this.adminBtn.Location = new System.Drawing.Point(187, 71);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.adminBtn.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.adminBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.adminBtn.selected = false;
            this.adminBtn.Size = new System.Drawing.Size(281, 48);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Create, Delete Admin";
            this.adminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.Textcolor = System.Drawing.Color.White;
            this.adminBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.DarkViolet;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(544, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(23, 23);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 5;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 20;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // createAdmin
            // 
            this.createAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createAdmin.Location = new System.Drawing.Point(0, 0);
            this.createAdmin.Name = "createAdmin";
            this.createAdmin.Size = new System.Drawing.Size(639, 520);
            this.createAdmin.TabIndex = 3;
            // 
            // admin_tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(639, 561);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_tools";
            this.Text = " ";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton image1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton adminBtn;
        private Bunifu.Framework.UI.BunifuFlatButton usersBtn;
        private Bunifu.Framework.UI.BunifuFlatButton groupsBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private createAdmin createAdmin;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
    }
}

//////////////////////////asodmasodmasomdoasmso