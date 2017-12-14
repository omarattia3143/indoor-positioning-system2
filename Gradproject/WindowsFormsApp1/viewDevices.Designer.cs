namespace WindowsFormsApp1
{
    partial class viewDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewDevices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.image1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.createBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.deviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicebluetoothaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceiconDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicepictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deviceoverridegroupiconDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deviceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new WindowsFormsApp1.DatabaseDataSet2();
            this.addEditBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApp1.DatabaseDataSet1();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTableAdapter = new WindowsFormsApp1.DatabaseDataSet1TableAdapters.DeviceTableAdapter();
            this.databaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTableAdapter1 = new WindowsFormsApp1.DatabaseDataSet2TableAdapters.DeviceTableAdapter();
            this.createUser1 = new WindowsFormsApp1.createUser();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).BeginInit();
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
            this.header.Size = new System.Drawing.Size(767, 41);
            this.header.TabIndex = 1;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Orange;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(672, 12);
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
            this.image1.Location = new System.Drawing.Point(730, 10);
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(701, 12);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 716);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.createUser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 716);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.createBtn);
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.datagrid);
            this.panel3.Controls.Add(this.addEditBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 716);
            this.panel3.TabIndex = 29;
            // 
            // createBtn
            // 
            this.createBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.createBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createBtn.BorderRadius = 0;
            this.createBtn.ButtonText = "Create";
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.DisabledColor = System.Drawing.Color.Gray;
            this.createBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.createBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("createBtn.Iconimage")));
            this.createBtn.Iconimage_right = null;
            this.createBtn.Iconimage_right_Selected = null;
            this.createBtn.Iconimage_Selected = null;
            this.createBtn.IconMarginLeft = 0;
            this.createBtn.IconMarginRight = 0;
            this.createBtn.IconRightVisible = true;
            this.createBtn.IconRightZoom = 0D;
            this.createBtn.IconVisible = true;
            this.createBtn.IconZoom = 90D;
            this.createBtn.IsTab = false;
            this.createBtn.Location = new System.Drawing.Point(144, 437);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.createBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.createBtn.selected = false;
            this.createBtn.Size = new System.Drawing.Size(152, 45);
            this.createBtn.TabIndex = 35;
            this.createBtn.Text = "Create";
            this.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Textcolor = System.Drawing.Color.White;
            this.createBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(593, 8);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(152, 45);
            this.bunifuFlatButton1.TabIndex = 34;
            this.bunifuFlatButton1.Text = "Refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(69, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name:";
            // 
            // name
            // 
            this.name.AccessibleDescription = "";
            this.name.AccessibleName = "";
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.HintForeColor = System.Drawing.Color.White;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(185, 8);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(228, 33);
            this.name.TabIndex = 32;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_KeyDown);
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.BorderRadius = 0;
            this.searchBtn.ButtonText = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchBtn.Iconimage")));
            this.searchBtn.Iconimage_right = null;
            this.searchBtn.Iconimage_right_Selected = null;
            this.searchBtn.Iconimage_Selected = null;
            this.searchBtn.IconMarginLeft = 0;
            this.searchBtn.IconMarginRight = 0;
            this.searchBtn.IconRightVisible = true;
            this.searchBtn.IconRightZoom = 0D;
            this.searchBtn.IconVisible = true;
            this.searchBtn.IconZoom = 90D;
            this.searchBtn.IsTab = false;
            this.searchBtn.Location = new System.Drawing.Point(435, 8);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(152, 45);
            this.searchBtn.TabIndex = 31;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Iconimage")));
            this.deleteBtn.Iconimage_right = null;
            this.deleteBtn.Iconimage_right_Selected = null;
            this.deleteBtn.Iconimage_Selected = null;
            this.deleteBtn.IconMarginLeft = 0;
            this.deleteBtn.IconMarginRight = 0;
            this.deleteBtn.IconRightVisible = true;
            this.deleteBtn.IconRightZoom = 0D;
            this.deleteBtn.IconVisible = true;
            this.deleteBtn.IconZoom = 90D;
            this.deleteBtn.IsTab = false;
            this.deleteBtn.Location = new System.Drawing.Point(460, 437);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(152, 45);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceidDataGridViewTextBoxColumn,
            this.devicenameDataGridViewTextBoxColumn,
            this.devicebluetoothaddressDataGridViewTextBoxColumn,
            this.deviceiconDataGridViewImageColumn,
            this.groupidDataGridViewTextBoxColumn,
            this.deviceinfoDataGridViewTextBoxColumn,
            this.devicepictureDataGridViewImageColumn,
            this.deviceoverridegroupiconDataGridViewCheckBoxColumn});
            this.datagrid.DataSource = this.deviceBindingSource2;
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.Black;
            this.datagrid.HeaderBgColor = System.Drawing.Color.Black;
            this.datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(12, 74);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.Size = new System.Drawing.Size(743, 343);
            this.datagrid.TabIndex = 28;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // deviceidDataGridViewTextBoxColumn
            // 
            this.deviceidDataGridViewTextBoxColumn.DataPropertyName = "device_id";
            this.deviceidDataGridViewTextBoxColumn.HeaderText = "device_id";
            this.deviceidDataGridViewTextBoxColumn.Name = "deviceidDataGridViewTextBoxColumn";
            this.deviceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devicenameDataGridViewTextBoxColumn
            // 
            this.devicenameDataGridViewTextBoxColumn.DataPropertyName = "device_name";
            this.devicenameDataGridViewTextBoxColumn.HeaderText = "device_name";
            this.devicenameDataGridViewTextBoxColumn.Name = "devicenameDataGridViewTextBoxColumn";
            // 
            // devicebluetoothaddressDataGridViewTextBoxColumn
            // 
            this.devicebluetoothaddressDataGridViewTextBoxColumn.DataPropertyName = "device_bluetooth_address";
            this.devicebluetoothaddressDataGridViewTextBoxColumn.HeaderText = "device_bluetooth_address";
            this.devicebluetoothaddressDataGridViewTextBoxColumn.Name = "devicebluetoothaddressDataGridViewTextBoxColumn";
            // 
            // deviceiconDataGridViewImageColumn
            // 
            this.deviceiconDataGridViewImageColumn.DataPropertyName = "device_icon";
            this.deviceiconDataGridViewImageColumn.HeaderText = "device_icon";
            this.deviceiconDataGridViewImageColumn.Name = "deviceiconDataGridViewImageColumn";
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "group_id";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            // 
            // deviceinfoDataGridViewTextBoxColumn
            // 
            this.deviceinfoDataGridViewTextBoxColumn.DataPropertyName = "device_info";
            this.deviceinfoDataGridViewTextBoxColumn.HeaderText = "device_info";
            this.deviceinfoDataGridViewTextBoxColumn.Name = "deviceinfoDataGridViewTextBoxColumn";
            // 
            // devicepictureDataGridViewImageColumn
            // 
            this.devicepictureDataGridViewImageColumn.DataPropertyName = "device_picture";
            this.devicepictureDataGridViewImageColumn.HeaderText = "device_picture";
            this.devicepictureDataGridViewImageColumn.Name = "devicepictureDataGridViewImageColumn";
            // 
            // deviceoverridegroupiconDataGridViewCheckBoxColumn
            // 
            this.deviceoverridegroupiconDataGridViewCheckBoxColumn.DataPropertyName = "device_override_group_icon";
            this.deviceoverridegroupiconDataGridViewCheckBoxColumn.HeaderText = "device_override_group_icon";
            this.deviceoverridegroupiconDataGridViewCheckBoxColumn.Name = "deviceoverridegroupiconDataGridViewCheckBoxColumn";
            // 
            // deviceBindingSource2
            // 
            this.deviceBindingSource2.DataMember = "Device";
            this.deviceBindingSource2.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addEditBtn
            // 
            this.addEditBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addEditBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEditBtn.BorderRadius = 0;
            this.addEditBtn.ButtonText = "Edit";
            this.addEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEditBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addEditBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addEditBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addEditBtn.Iconimage")));
            this.addEditBtn.Iconimage_right = null;
            this.addEditBtn.Iconimage_right_Selected = null;
            this.addEditBtn.Iconimage_Selected = null;
            this.addEditBtn.IconMarginLeft = 0;
            this.addEditBtn.IconMarginRight = 0;
            this.addEditBtn.IconRightVisible = true;
            this.addEditBtn.IconRightZoom = 0D;
            this.addEditBtn.IconVisible = true;
            this.addEditBtn.IconZoom = 90D;
            this.addEditBtn.IsTab = false;
            this.addEditBtn.Location = new System.Drawing.Point(302, 437);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addEditBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addEditBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addEditBtn.selected = false;
            this.addEditBtn.Size = new System.Drawing.Size(152, 45);
            this.addEditBtn.TabIndex = 29;
            this.addEditBtn.Text = "Edit";
            this.addEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEditBtn.Textcolor = System.Drawing.Color.White;
            this.addEditBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deviceBindingSource1
            // 
            this.deviceBindingSource1.DataMember = "Device";
            this.deviceBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.databaseDataSet1;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet2BindingSource
            // 
            this.databaseDataSet2BindingSource.DataSource = this.databaseDataSet2;
            this.databaseDataSet2BindingSource.Position = 0;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // createUser1
            // 
            this.createUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.createUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUser1.Location = new System.Drawing.Point(0, 0);
            this.createUser1.Name = "createUser1";
            this.createUser1.Size = new System.Drawing.Size(767, 716);
            this.createUser1.TabIndex = 28;
            this.createUser1.Load += new System.EventHandler(this.createUser1_Load);
            // 
            // viewDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(767, 757);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewDevices";
            this.Text = " ";
            this.Load += new System.EventHandler(this.viewDevices_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private DatabaseDataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter;
        private createUser createUser1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addEditBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.BindingSource deviceBindingSource1;
        private System.Windows.Forms.BindingSource databaseDataSet2BindingSource;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource deviceBindingSource2;
        private DatabaseDataSet2TableAdapters.DeviceTableAdapter deviceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicebluetoothaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deviceiconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn devicepictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deviceoverridegroupiconDataGridViewCheckBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton createBtn;
    }
}

