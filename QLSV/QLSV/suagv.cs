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
        public partial class suagv : Form
        {
        Du_AnEntities da = new Du_AnEntities();
            public byte[] anh { get; set; }
            public string magv { get; set; }
            public string tengv { get; set; }
            public string sdt { get; set; }
            public Nullable<System.DateTime> ngaysinh { get; set; }
            public string tenkhoa { get; set; }
            public string monday { get; set; }
            public string diachi { get; set; }
            public suagv(byte[] pic, String Ma, String Ten, String sodt,String Ngay, String tenk , String mond, String Diachi)
            {
                InitializeComponent();
                this .anh = pic;
                this .magv = Ma;
                this .tengv = Ten;
                this.sdt = sodt;
                this.ngaysinh = DateTime.Parse(Ngay);
                this .tenkhoa = tenk;
                this .monday = mond;
                this .diachi = Diachi;
             image.Image = ByteArrayToImage(pic);
               ma.Text = magv;
               ten.Text = tengv;
               this.sodt.Text = sdt;
               ngay.Value = ngaysinh.Value;
               khoa.Text = tenkhoa;
               mon.Text = monday;
               dc.Text = diachi;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
        private void suagv_Load(object sender, EventArgs e)
        {
            khoa.FlatStyle = FlatStyle.Flat;
            mon.BackColor = Color.White;
            mon.FlatStyle = FlatStyle.Flat;
            khoa.BackColor = Color.White;
            var result1 = from sv in da.hoc_phan
                          select
                         sv.tenhp;
            foreach (var tenSV in result1)
            {
                mon.Items.Add(tenSV);
            }
            var result2 = from sv in da.khoas
                          select
                         sv.tenkhoa;
            foreach (var tenSV1 in result2)
            {
                khoa.Items.Add(tenSV1);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files (*.jpeg; *.jpg; *.png; *.gif; *.bmp)|*.jpeg; *.jpg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.ImageLocation = openFileDialog.FileName;
            }
            else
            {

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn sửa", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }


                string id = ma.Text;
                string pattern = "[0-9a-zA-Z]";
                string patterns = "[0-9]";
                string patterns1 = "[a-zA-Z]";
                Regex regex = new Regex(pattern);
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
                else if (!regex1.IsMatch(sodt.Text))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!regex2.IsMatch(ten.Text))
                {
                    MessageBox.Show("Tên không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    giangvien gv = da.giangviens.Find(id);
                    gv.anh = imageBytes;
                    gv.magv = ma.Text;
                    gv.tengv = ten.Text;
                    gv.sdt = sodt.Text;
                    gv.ngaysinh = ngay.Value;
                    gv.monday = mon.Text;
                    gv.tenkhoa = khoa.Text;
                    gv.diachi = dc.Text;
                    gv.matkhau = ma.Text;
                    da.SaveChanges();
                    (Application.OpenForms["quanliGV"] as quanliGV)?.loaddata();
                    this.Close();
                    // Sửa 



                }
            }
            }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
