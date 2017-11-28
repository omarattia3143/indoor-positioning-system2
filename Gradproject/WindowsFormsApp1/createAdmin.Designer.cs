namespace WindowsFormsApp1
{
    partial class createAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createAdmin));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApp1.DatabaseDataSet();
            this.adminTableAdapter = new WindowsFormsApp1.DatabaseDataSetTableAdapters.AdminTableAdapter();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.password2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.adminBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(493, 99);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(144, 356);
            this.bunifuCustomDataGrid1.TabIndex = 1;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // username
            // 
            this.username.AccessibleDescription = "";
            this.username.AccessibleName = "";
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.HintForeColor = System.Drawing.Color.White;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(202, 99);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(228, 33);
            this.username.TabIndex = 6;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Create a new";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // password
            // 
            this.password.AccessibleDescription = "";
            this.password.AccessibleName = "";
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HintForeColor = System.Drawing.Color.White;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(202, 169);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(228, 33);
            this.password.TabIndex = 11;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Re-type password:";
            // 
            // password2
            // 
            this.password2.AccessibleDescription = "";
            this.password2.AccessibleName = "";
            this.password2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password2.ForeColor = System.Drawing.Color.White;
            this.password2.HintForeColor = System.Drawing.Color.White;
            this.password2.HintText = "";
            this.password2.isPassword = false;
            this.password2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.password2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.password2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(177)))), ((int)(((byte)(246)))));
            this.password2.LineThickness = 3;
            this.password2.Location = new System.Drawing.Point(202, 250);
            this.password2.Margin = new System.Windows.Forms.Padding(4);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(228, 33);
            this.password2.TabIndex = 13;
            this.password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.insertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.insertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertBtn.BorderRadius = 0;
            this.insertBtn.ButtonText = "Insert";
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBtn.DisabledColor = System.Drawing.Color.Gray;
            this.insertBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.insertBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("insertBtn.Iconimage")));
            this.insertBtn.Iconimage_right = null;
            this.insertBtn.Iconimage_right_Selected = null;
            this.insertBtn.Iconimage_Selected = null;
            this.insertBtn.IconMarginLeft = 0;
            this.insertBtn.IconMarginRight = 0;
            this.insertBtn.IconRightVisible = true;
            this.insertBtn.IconRightZoom = 0D;
            this.insertBtn.IconVisible = true;
            this.insertBtn.IconZoom = 90D;
            this.insertBtn.IsTab = false;
            this.insertBtn.Location = new System.Drawing.Point(35, 355);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.insertBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.insertBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.insertBtn.selected = false;
            this.insertBtn.Size = new System.Drawing.Size(152, 45);
            this.insertBtn.TabIndex = 15;
            this.insertBtn.Text = "Insert";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertBtn.Textcolor = System.Drawing.Color.White;
            this.insertBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.deleteBtn.Location = new System.Drawing.Point(193, 355);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(152, 45);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.searchBtn.Location = new System.Drawing.Point(351, 355);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(152, 45);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // createAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "createAdmin";
            this.Size = new System.Drawing.Size(706, 473);
            this.Load += new System.EventHandler(this.createAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton insertBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
    }
}
