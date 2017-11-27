namespace WindowsFormsApp1
{
    partial class admin_tools
    {//eshta yaba eshta.. eshta ya 3amy eshta..
        //kolo keda eshta
        //wana keda
        //eshta
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
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.image1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.usersBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminBtn1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.createAdmin = new WindowsFormsApp1.createAdmin();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.header.BackColor = System.Drawing.Color.Orange;
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
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Orange;
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
            // image1
            // 
            this.image1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.image1.BackColor = System.Drawing.Color.Orange;
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
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Orange;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.createAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 520);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupsBtn);
            this.panel2.Controls.Add(this.usersBtn);
            this.panel2.Controls.Add(this.adminBtn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 520);
            this.panel2.TabIndex = 7;
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
            this.groupsBtn.Location = new System.Drawing.Point(182, 282);
            this.groupsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.groupsBtn.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.groupsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.groupsBtn.selected = false;
            this.groupsBtn.Size = new System.Drawing.Size(281, 48);
            this.groupsBtn.TabIndex = 8;
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
            this.usersBtn.Location = new System.Drawing.Point(182, 185);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.usersBtn.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.usersBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.usersBtn.selected = false;
            this.usersBtn.Size = new System.Drawing.Size(281, 48);
            this.usersBtn.TabIndex = 7;
            this.usersBtn.Text = "Create,Edit and Delete Users";
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.Textcolor = System.Drawing.Color.White;
            this.usersBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // adminBtn1
            // 
            this.adminBtn1.Activecolor = System.Drawing.Color.DarkOrchid;
            this.adminBtn1.BackColor = System.Drawing.Color.Transparent;
            this.adminBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminBtn1.BorderRadius = 0;
            this.adminBtn1.ButtonText = "Create, Delete Admin";
            this.adminBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn1.DisabledColor = System.Drawing.Color.Gray;
            this.adminBtn1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn1.Iconcolor = System.Drawing.Color.Transparent;
            this.adminBtn1.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminBtn1.Iconimage")));
            this.adminBtn1.Iconimage_right = null;
            this.adminBtn1.Iconimage_right_Selected = null;
            this.adminBtn1.Iconimage_Selected = null;
            this.adminBtn1.IconMarginLeft = 0;
            this.adminBtn1.IconMarginRight = 0;
            this.adminBtn1.IconRightVisible = true;
            this.adminBtn1.IconRightZoom = 0D;
            this.adminBtn1.IconVisible = true;
            this.adminBtn1.IconZoom = 90D;
            this.adminBtn1.IsTab = false;
            this.adminBtn1.Location = new System.Drawing.Point(182, 88);
            this.adminBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminBtn1.Name = "adminBtn1";
            this.adminBtn1.Normalcolor = System.Drawing.Color.Transparent;
            this.adminBtn1.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.adminBtn1.OnHoverTextColor = System.Drawing.Color.White;
            this.adminBtn1.selected = false;
            this.adminBtn1.Size = new System.Drawing.Size(281, 48);
            this.adminBtn1.TabIndex = 6;
            this.adminBtn1.Text = "Create, Delete Admin";
            this.adminBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn1.Textcolor = System.Drawing.Color.White;
            this.adminBtn1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn1.Click += new System.EventHandler(this.adminBtn_Click_2);
            // 
            // createAdmin
            // 
            this.createAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.createAdmin.Location = new System.Drawing.Point(0, 0);
            this.createAdmin.Name = "createAdmin";
            this.createAdmin.Size = new System.Drawing.Size(639, 520);
            this.createAdmin.TabIndex = 6;
            // 
            // admin_tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(639, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_tools";
            this.Text = " ";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton image1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private System.Windows.Forms.Panel panel1;
        private createAdmin createAdmin;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton groupsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton usersBtn;
        private Bunifu.Framework.UI.BunifuFlatButton adminBtn1;
    }
}

