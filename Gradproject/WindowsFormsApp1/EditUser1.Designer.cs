namespace WindowsFormsApp1
{
    partial class EditUser1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.macTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 716);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.macTextbox);
            this.panel2.Controls.Add(this.nameTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.descriptionBox);
            this.panel2.Controls.Add(this.avatar);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 716);
            this.panel2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(358, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(29, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Bluetooth MAC";
            // 
            // macTextbox
            // 
            this.macTextbox.AccessibleDescription = "";
            this.macTextbox.AccessibleName = "";
            this.macTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.macTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.macTextbox.ForeColor = System.Drawing.Color.White;
            this.macTextbox.HintForeColor = System.Drawing.Color.White;
            this.macTextbox.HintText = "";
            this.macTextbox.isPassword = false;
            this.macTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.macTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.macTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.macTextbox.LineThickness = 3;
            this.macTextbox.Location = new System.Drawing.Point(228, 253);
            this.macTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.macTextbox.Name = "macTextbox";
            this.macTextbox.Size = new System.Drawing.Size(199, 33);
            this.macTextbox.TabIndex = 25;
            this.macTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameTextbox
            // 
            this.nameTextbox.AccessibleDescription = "";
            this.nameTextbox.AccessibleName = "";
            this.nameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextbox.ForeColor = System.Drawing.Color.White;
            this.nameTextbox.HintForeColor = System.Drawing.Color.White;
            this.nameTextbox.HintText = "";
            this.nameTextbox.isPassword = false;
            this.nameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.nameTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.nameTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.nameTextbox.LineThickness = 3;
            this.nameTextbox.Location = new System.Drawing.Point(228, 183);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(199, 33);
            this.nameTextbox.TabIndex = 21;
            this.nameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextbox.OnValueChanged += new System.EventHandler(this.nameTextbox_OnValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(290, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Edit ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(39, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionBox.BorderColorFocused = System.Drawing.Color.Orange;
            this.descriptionBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.descriptionBox.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.descriptionBox.BorderThickness = 3;
            this.descriptionBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.descriptionBox.ForeColor = System.Drawing.Color.White;
            this.descriptionBox.isPassword = false;
            this.descriptionBox.Location = new System.Drawing.Point(393, 426);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(370, 198);
            this.descriptionBox.TabIndex = 32;
            this.descriptionBox.Text = "Description...";
            this.descriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(223)))));
            this.avatar.Image = global::WindowsFormsApp1.Properties.Resources.facebook_avatar;
            this.avatar.Location = new System.Drawing.Point(542, 95);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(209, 207);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 31;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Iconimage")));
            this.cancelBtn.Iconimage_right = null;
            this.cancelBtn.Iconimage_right_Selected = null;
            this.cancelBtn.Iconimage_Selected = null;
            this.cancelBtn.IconMarginLeft = 0;
            this.cancelBtn.IconMarginRight = 0;
            this.cancelBtn.IconRightVisible = true;
            this.cancelBtn.IconRightZoom = 0D;
            this.cancelBtn.IconVisible = true;
            this.cancelBtn.IconZoom = 90D;
            this.cancelBtn.IsTab = false;
            this.cancelBtn.Location = new System.Drawing.Point(191, 507);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelBtn.selected = false;
            this.cancelBtn.Size = new System.Drawing.Size(152, 45);
            this.cancelBtn.TabIndex = 29;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Textcolor = System.Drawing.Color.White;
            this.cancelBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = true;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(33, 507);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(152, 45);
            this.updateBtn.TabIndex = 28;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.createBtn2_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // EditUser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Name = "EditUser1";
            this.Size = new System.Drawing.Size(767, 716);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton cancelBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        public System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox macTextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox nameTextbox;
        public Bunifu.Framework.UI.BunifuMetroTextbox descriptionBox;
        public System.Windows.Forms.PictureBox avatar;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
