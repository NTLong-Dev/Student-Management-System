using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
    public partial class edit : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public byte[] Anh { get; set; }
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string TenLop { get; set; }
        public string TenKhoa { get; set; }
        
        public edit(byte[] anh, string masv, string tensv, string gioitinh, string ngaysinh, string sdt, string diachi, string lop, string khoa)
        {
            
            InitializeComponent();
            

            this.Anh = anh;
            this.MaSV = masv;
            this.TenSV = tensv;
            this.GioiTinh = gioitinh;
            this.NgaySinh = DateTime.Parse(ngaysinh);
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.TenLop = lop;
            this.TenKhoa = khoa;
           anh1.Image = ByteArrayToImage(Anh);
            ma.Text = MaSV;
            ten.Text = TenSV;
            if(gioitinh == "Nam")
            {
                nam.Checked = true;
            }
            else
            {
                nu.Checked = true;
            }

            ngay.Value = NgaySinh.Value;
            sdt1.Text = SDT;
            dc.Text = DiaChi;
            tlop.Text = TenLop;
            tkhoa.Text = TenKhoa;

        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }


            private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn sửa", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                String gt = nam.Checked ? "Nam" : "Nữ";

                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                 
                    anh1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
              
                string id = ma.Text; string pattern = "[0-9a-zA-Z]";
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
                else if (!regex1.IsMatch(sdt1.Text))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!regex2.IsMatch(ten.Text))
                {
                    MessageBox.Show("Tên không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(imageBytes == null)
                    {
                        MessageBox.Show("Bạn chưa chọn lại ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                {
                    sinhvien sv = du_an.sinhviens.Find(id);

                    sv.anh = imageBytes;
                    sv.tensv = ten.Text;
                    sv.gioitinh = gt;
                    sv.sdt = sdt1.Text;
                    sv.diachi = dc.Text;
                    sv.ngaysinh = ngay.Value;
                    sv.tenlop = tlop.Text;
                    sv.tenkhoa = tkhoa.Text;
                    sv.matkhau = ma.Text;


                    du_an.SaveChanges();
                    (Application.OpenForms["quanliSV"] as quanliSV)?.Loaddata();
                    this.Close();


                }
            }
            else
            {
                this.Close();

            }

        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files (*.jpeg; *.jpg; *.png; *.gif; *.bmp)|*.jpeg; *.jpg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               anh1.ImageLocation = openFileDialog.FileName;
            }
        }
     



        private void edit_Load(object sender, EventArgs e)
        { 
            tlop.FlatStyle = FlatStyle.Flat;
            tlop.BackColor = Color.White;
           
            tkhoa.FlatStyle = FlatStyle.Flat;
            tlop.BackColor = Color.White;

            tkhoa.SelectedIndexChanged += masvi_SelectedIndexChanged;
            var khoaList = du_an.lops.Select(k => k.tenkhoa).Distinct().ToList();

            foreach (var masvValue in khoaList)
            {
                tkhoa.Items.Add(masvValue);
            }
        }
         private void masvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlop.Items.Clear();
            string selectedk = tkhoa.SelectedItem?.ToString();

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

        private void tlop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
