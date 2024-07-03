namespace QLSV
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.quenmk = new System.Windows.Forms.LinkLabel();
            this.taikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.matkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.dang = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.eye = new System.Windows.Forms.PictureBox();
            this.hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // quenmk
            // 
            resources.ApplyResources(this.quenmk, "quenmk");
            this.quenmk.LinkColor = System.Drawing.Color.White;
            this.quenmk.Name = "quenmk";
            this.quenmk.TabStop = true;
            this.quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // taikhoan
            // 
            this.taikhoan.BorderRadius = 15;
            this.taikhoan.BorderThickness = 0;
            this.taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taikhoan.DefaultText = "";
            this.taikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.taikhoan, "taikhoan");
            this.taikhoan.ForeColor = System.Drawing.Color.Black;
            this.taikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.taikhoan.MaxLength = 10;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.PasswordChar = '\0';
            this.taikhoan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.taikhoan.PlaceholderText = "Tên đăng nhập";
            this.taikhoan.SelectedText = "";
            this.taikhoan.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // matkhau
            // 
            this.matkhau.BorderRadius = 15;
            this.matkhau.BorderThickness = 0;
            this.matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matkhau.DefaultText = "";
            this.matkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.matkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.matkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.matkhau, "matkhau");
            this.matkhau.ForeColor = System.Drawing.Color.Black;
            this.matkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matkhau.MaxLength = 10;
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.matkhau.PlaceholderText = "Mật khẩu";
            this.matkhau.SelectedText = "";
            this.matkhau.TextChanged += new System.EventHandler(this.matkhau_TextChanged);
            // 
            // dang
            // 
            this.dang.BorderRadius = 20;
            this.dang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dang.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dang, "dang");
            this.dang.ForeColor = System.Drawing.Color.Black;
            this.dang.Name = "dang";
            this.dang.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.eye, "eye");
            this.eye.Name = "eye";
            this.eye.TabStop = false;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hide, "hide");
            this.hide.Name = "hide";
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.hide);
            this.Controls.Add(this.dang);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.quenmk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.eye);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2TextBox taikhoan;
        private Guna.UI2.WinForms.Guna2TextBox matkhau;
        private Guna.UI2.WinForms.Guna2Button dang;
        private System.Windows.Forms.PictureBox eye;
        private System.Windows.Forms.PictureBox hide;
        protected System.Windows.Forms.LinkLabel quenmk;
    }
}

