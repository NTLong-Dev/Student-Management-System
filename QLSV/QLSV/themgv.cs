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

namespace QLSV
{
    public partial class themgv : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        public themgv()
        {
            InitializeComponent();
        }

        private void themgv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'du_AnDataSet3.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.du_AnDataSet3.khoa);
            // TODO: This line of code loads data into the 'du_AnDataSet2.hoc_phan' table. You can move, or remove it, as needed.
            this.hoc_phanTableAdapter.Fill(this.du_AnDataSet2.hoc_phan);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files (*.jpeg; *.jpg; *.png; *.gif; *.bmp)|*.jpeg; *.jpg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pis.ImageLocation = openFileDialog.FileName;
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
            pictureBox.Image.Save(memory, pictureBox.Image.RawFormat);
            return memory.ToArray();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
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
            else if (!regex.IsMatch(diachi.Text))
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

                byte[] image = images(pis);

                    giangvien gv = new giangvien()
                    {
                        anh = image,
                        magv = ma.Text,
                        tengv = ten.Text,
                        sdt = sdt.Text,
                        ngaysinh = ngaysinhs.Value,
                        tenkhoa = tenkhoa.Text,
                        monday = monday.Text,
                        diachi = diachi.Text,
                        matkhau = ma.Text
                        // Thêm

                    };
                    da.giangviens.Add(gv);
                    da.SaveChanges();
                    (Application.OpenForms["quanliGV"] as quanliGV)?.loaddata();
                    this.Close();
                
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
