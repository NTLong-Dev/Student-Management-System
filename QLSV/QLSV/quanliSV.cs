using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSV
{
    public partial class quanliSV : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public quanliSV()
        {
            InitializeComponent();
                
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Loaddata()
        {
            var result = from c in du_an.sinhviens select new {c.anh , c.masv, c.tensv , c.gioitinh, c.ngaysinh, c.sdt, c.diachi, c.tenlop, c.tenkhoa};
            grv.DataSource = result.ToList();
            var result22 = du_an.sinhviens.Count();
            int count = result22;
            sv.Text = count.ToString();
            var result21 = du_an.sinhviens.Where(s => s.gioitinh == "Nam").Count();
            int count1 = result21;
            male.Text = count1.ToString();
            var result23 = du_an.sinhviens.Where(s => s.gioitinh == "Nữ").Count();
            int count12 = result23;
            female.Text = count12.ToString();
            if (grv.DataSource == null)
            {
                cb.Text = "";
            }
            var result3 = from sv in du_an.sinhviens
                          select
                         sv.ngaysinh;
            foreach (var ngay in result3)
            {
                cb.Items.Add(ngay);
            }




        }
        private void quanliSV_Load(object sender, EventArgs e)
        {
            
            
            Loaddata();
           
            
            DataGridViewImageColumn pisc = new DataGridViewImageColumn();
            pisc = (DataGridViewImageColumn)grv.Columns[2];
            pisc.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Columns[e.ColumnIndex].Name == "sua")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                byte[] anh = (byte[])selectedRow.Cells["anh"].Value;
                string masv = selectedRow.Cells["masv"].Value.ToString();
                string tensv = selectedRow.Cells["hoten"].Value.ToString();
                string gioitinh = selectedRow.Cells["gioitinh"].Value.ToString();
                string ngaysinh = selectedRow.Cells["ngay"].Value.ToString();
                string sdt = selectedRow.Cells["sdt"].Value.ToString();
                string diachi = selectedRow.Cells["diachi"].Value.ToString();
                string lop = selectedRow.Cells["tenlop"].Value.ToString();
                string khoa = selectedRow.Cells["tenkhoa"].Value.ToString();

                edit edit1 = new edit(anh, masv, tensv, gioitinh, ngaysinh, sdt, diachi, lop, khoa);
                edit1.Show();



            }
            if (grv.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult result = MessageBox.Show("Bạn muốn Xoá", "Xoá", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = grv.Rows[rowIndex];
                    string masv = selectedRow.Cells["masv"].Value.ToString();
                    var svToDelete = du_an.sinhviens.Where(sv => sv.masv == masv).FirstOrDefault();
                    du_an.sinhviens.Remove(svToDelete);
                    du_an.SaveChanges();
                    Loaddata();
                }
                else { }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            themsv them = new themsv();
            them.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tk_Click(object sender, EventArgs e)
        {
            List<object> resultsList = new List<object>();
            DateTime namsinh;
            if (DateTime.TryParse(cb.Text, out namsinh))
            {
                var results = (from sv in du_an.sinhviens
                               where sv.ngaysinh == namsinh
                               select new { sv.masv, sv.tensv, sv.gioitinh, sv.ngaysinh }).ToList();
                resultsList.AddRange(results);
            }

            dtg.DataSource = resultsList;
            dtg.Visible = true;
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

            cb.Text = "";
            dtg.Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            String timk = tim.Text;
            var results32 = (from sv in du_an.sinhviens
                             where sv.tensv == timk || sv.gioitinh == timk //vd tìm thêm gioitinh
                             select new { sv.anh, sv.masv, sv.tensv, sv.gioitinh, sv.ngaysinh, sv.sdt, sv.diachi, sv.tenlop, sv.tenkhoa }).ToList();

            grv.DataSource = results32;
        }
        //ở đây là tìm kiếm
    }
}
