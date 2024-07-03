using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form2 : Form
    {
        public string Ma_SV { get; set; }
        Color originalColor;

        public Form2(String maSV)
        {
            InitializeComponent();
            this.Ma_SV = maSV;
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
        private void Form2_Load(object sender, EventArgs e)
        {
            originalColor = sinhvien.FillColor;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                home_Click(sender, e);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            home.FillColor = Color.LightSkyBlue;
            sinhvien.FillColor = originalColor;
            hp.FillColor = originalColor;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            pass.FillColor = Color.White;
            logout.FillColor = Color.White;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void sinhvien_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.LightSkyBlue;
            hp.FillColor = Color.White;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            pass.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new Profile(Ma_SV));
        }

        private void hp_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = originalColor;
            hp.FillColor = Color.LightSkyBlue;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            pass.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new hocphan());
        }

        private void gv_Click(object sender, EventArgs e)
        {
        }

        private void lop_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            lop.FillColor = Color.LightSkyBlue;
            diem.FillColor = Color.White;
            pass.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new lopvakhoa());
        }

        private void diem_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            lop.FillColor = Color.White;
            diem.FillColor = Color.LightSkyBlue;
            pass.FillColor = Color.White;
            logout.FillColor = Color.White;
            OpenChildForm(new thongtindiem());
        }

        private void tc_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            lop.FillColor = Color.White;
            diem.FillColor = Color.White;
            pass.FillColor = Color.White;
            logout.FillColor = Color.White;
            
        }

        private void pass_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = Color.White;
            hp.FillColor = Color.White;
            lop.FillColor = Color.White;
            diem.FillColor = Color.White;
            pass.FillColor = Color.LightSkyBlue;
            logout.FillColor = Color.White;
            OpenChildForm(new qmk());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            home.FillColor = originalColor;
            sinhvien.FillColor = originalColor;
            hp.FillColor = Color.White;
            lop.FillColor = originalColor;
            diem.FillColor = Color.White;
            pass.FillColor = Color.White;
            logout.FillColor = Color.LightSkyBlue;
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
