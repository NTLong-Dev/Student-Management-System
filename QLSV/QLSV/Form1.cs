using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
    Color originalColor;
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            home.FillColor = Color.LightSkyBlue;
            sinhvien.FillColor = originalColor;
            hp.FillColor = originalColor;
            gv.FillColor = originalColor;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            home.FillColor = Color.LightSkyBlue;
            sinhvien.FillColor = originalColor;
            hp.FillColor = originalColor;
            gv.FillColor = originalColor;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = originalColor;
            hp.FillColor = Color.LightSkyBlue;
            gv.FillColor = originalColor;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new hocphan());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalColor = sinhvien.FillColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = originalColor;
            hp.FillColor = Color.White;
            gv.FillColor = originalColor;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            logout.FillColor = Color.LightSkyBlue;
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        public void guna2Button2_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.LightSkyBlue;
            hp.FillColor = Color.White;
            gv.FillColor = originalColor;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new quanliSV());
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            gv.FillColor = Color.LightSkyBlue;
            lop.FillColor = Color.White;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
               OpenChildForm(new quanliGV());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            gv.FillColor = Color.White;
            lop.FillColor = Color.LightSkyBlue;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
           OpenChildForm(new lopvakhoa());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            gv.FillColor = Color.White;
            lop.FillColor = Color.White;
            diem.FillColor = Color.LightSkyBlue;
            logout.FillColor = Color.White;
            OpenChildForm(new diemSV());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            gv.FillColor = Color.White;
            lop.FillColor = Color.White;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new taichinh());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            gv.FillColor = Color.White;
            lop.FillColor = Color.White;
            diem.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new qmk());
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_body_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                 guna2Button1_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
