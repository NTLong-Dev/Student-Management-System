using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLSV
{
    public partial class themsv : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public themsv()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {



        }
        
        private void themsv_Load(object sender, EventArgs e)
        {



            khoa.SelectedIndexChanged += masvi_SelectedIndexChanged;
            var khoaList = du_an.lops.Select(k => k.tenkhoa).Distinct().ToList();

            foreach (var masvValue in khoaList)
            {
                khoa.Items.Add(masvValue);
            }
        }
        private void masvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlop.Items.Clear();
            string selectedk = khoa.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedk))
            {
                var selectedkhoa = du_an.lops.Where(k => k.tenkhoa == selectedk);

                foreach (var khoa in selectedkhoa)
                {
                    tlop.Items.Add(khoa.tenlop);
                }

                if (!selectedkhoa.Any())
                {
                    tlop.Items.Add("Không tìm thấy lớp");
                }
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files (*.jpeg; *.jpg; *.png; *.gif; *.bmp)|*.jpeg; *.jpg; *.png; *.gif; *.bmp";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic.ImageLocation = openFileDialog.FileName;
            }
            else
            {
            }
        }
        private byte[] images(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                return null;
            }
            MemoryStream memory = new MemoryStream();
            pictureBox.Image.Save(memory,pictureBox.Image.RawFormat);
            return memory.ToArray();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
                String gt;
            byte[] pics = images(pic);
            if (nam.Checked)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
                string pattern = "[0-9a-zA-Z]";
                Regex regex = new Regex(pattern);
                string patterns = "[0-9]";
                string patterns1 = "[a-zA-Z]";
                
                Regex regex1 = new Regex(patterns);
                Regex regex2 = new Regex(patterns1);
                if (!regex.IsMatch(ma.Text))
                {
                    MessageBox.Show("Mã không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!regex.IsMatch(dc.Text))
                {
                    MessageBox.Show("Địa chỉ không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!regex1.IsMatch(sdt.Text))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!regex2.IsMatch(ten.Text))
                {
                    MessageBox.Show("Tên không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sinhvien sv = new sinhvien()
                    {
                        anh = pics,
                        masv = ma.Text,
                        tensv = ten.Text,
                        gioitinh = gt,
                        sdt = sdt.Text,
                        diachi = dc.Text,
                        ngaysinh = ns.Value,
                        tenlop = tlop.Text,
                        tenkhoa = khoa.Text,
                        matkhau = ma.Text
                    };
                    du_an.sinhviens.Add(sv);
                    du_an.SaveChanges();
                    (Application.OpenForms["quanliSV"] as quanliSV)?.Loaddata();
                    this.Close();
                }
            
        }

        private void ns_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
