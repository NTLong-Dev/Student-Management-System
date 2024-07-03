namespace QLSV
{
    partial class themsv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themsv));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ma = new Guna.UI2.WinForms.Guna2TextBox();
            this.ten = new Guna.UI2.WinForms.Guna2TextBox();
            this.sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ns = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.khoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dc = new Guna.UI2.WinForms.Guna2TextBox();
            this.nam = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.tlop = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-17, 369);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(277, 206);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(31, 15);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(243, 176);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(71, 199);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(161, 47);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Thêm hình ảnh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ma
            // 
            this.ma.BorderRadius = 12;
            this.ma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ma.DefaultText = "";
            this.ma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ma.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ma.Location = new System.Drawing.Point(339, 15);
            this.ma.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ma.Name = "ma";
            this.ma.PasswordChar = '\0';
            this.ma.PlaceholderText = "Mã sinh viên";
            this.ma.SelectedText = "";
            this.ma.Size = new System.Drawing.Size(523, 57);
            this.ma.TabIndex = 3;
            // 
            // ten
            // 
            this.ten.BorderRadius = 12;
            this.ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ten.DefaultText = "";
            this.ten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ten.Location = new System.Drawing.Point(339, 84);
            this.ten.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ten.Name = "ten";
            this.ten.PasswordChar = '\0';
            this.ten.PlaceholderText = "Họ tên";
            this.ten.SelectedText = "";
            this.ten.Size = new System.Drawing.Size(523, 57);
            this.ten.TabIndex = 4;
            this.ten.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // sdt
            // 
            this.sdt.BorderRadius = 12;
            this.sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sdt.DefaultText = "";
            this.sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sdt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sdt.Location = new System.Drawing.Point(339, 246);
            this.sdt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sdt.Name = "sdt";
            this.sdt.PasswordChar = '\0';
            this.sdt.PlaceholderText = "Số điện thoại";
            this.sdt.SelectedText = "";
            this.sdt.Size = new System.Drawing.Size(523, 57);
            this.sdt.TabIndex = 6;
            // 
            // ns
            // 
            this.ns.BorderRadius = 12;
            this.ns.Checked = true;
            this.ns.FillColor = System.Drawing.Color.White;
            this.ns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ns.Location = new System.Drawing.Point(339, 186);
            this.ns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ns.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.ns.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(523, 44);
            this.ns.TabIndex = 9;
            this.ns.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.ns.ValueChanged += new System.EventHandler(this.ns_ValueChanged);
            // 
            // khoa
            // 
            this.khoa.BackColor = System.Drawing.Color.Transparent;
            this.khoa.BorderRadius = 12;
            this.khoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.khoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.khoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.khoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.khoa.ItemHeight = 30;
            this.khoa.Location = new System.Drawing.Point(339, 394);
            this.khoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(521, 36);
            this.khoa.TabIndex = 11;
            // 
            // dc
            // 
            this.dc.BorderRadius = 12;
            this.dc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dc.DefaultText = "";
            this.dc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dc.Location = new System.Drawing.Point(339, 319);
            this.dc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dc.Name = "dc";
            this.dc.PasswordChar = '\0';
            this.dc.PlaceholderText = "Địa chỉ";
            this.dc.SelectedText = "";
            this.dc.Size = new System.Drawing.Size(523, 57);
            this.dc.TabIndex = 12;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.Location = new System.Drawing.Point(467, 148);
            this.nam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(86, 35);
            this.nam.TabIndex = 13;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu.Location = new System.Drawing.Point(576, 149);
            this.nu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(69, 35);
            this.nu.TabIndex = 14;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            this.nu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giới tính:";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 12;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(552, 507);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(161, 47);
            this.guna2Button2.TabIndex = 16;
            this.guna2Button2.Text = "Thêm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 12;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(721, 507);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(161, 47);
            this.guna2Button3.TabIndex = 17;
            this.guna2Button3.Text = "Huỷ";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // tlop
            // 
            this.tlop.BackColor = System.Drawing.Color.Transparent;
            this.tlop.BorderRadius = 12;
            this.tlop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tlop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tlop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tlop.ItemHeight = 30;
            this.tlop.Location = new System.Drawing.Point(339, 455);
            this.tlop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlop.Name = "tlop";
            this.tlop.Size = new System.Drawing.Size(521, 36);
            this.tlop.TabIndex = 18;
            // 
            // themsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 566);
            this.Controls.Add(this.tlop);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.guna2PictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "themsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.themsv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox ma;
        private Guna.UI2.WinForms.Guna2TextBox ten;
        private Guna.UI2.WinForms.Guna2TextBox sdt;
        private Guna.UI2.WinForms.Guna2DateTimePicker ns;
        private Guna.UI2.WinForms.Guna2ComboBox khoa;
        private Guna.UI2.WinForms.Guna2TextBox dc;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2ComboBox tlop;
    }
}