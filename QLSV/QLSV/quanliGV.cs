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
    public partial class quanliGV : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        public void loaddata()
        {
            var result = from c in da.giangviens select new {c.anh , c.magv, c.tengv, c.sdt, c.ngaysinh, c.tenkhoa, c.monday , c.diachi};
            grv.DataSource = result.ToList();
            var result22 = da.giangviens.Count();
            int count = result22;
            label3.Text = count.ToString();


            this.giangvienTableAdapter1.Fill(this.du_AnDataSet6.giangvien);
            
        }
        public quanliGV()                                                                       
        {
            InitializeComponent();
        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            themgv gvc = new themgv();
            gvc.Show();
        }

        private void grv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Columns[e.ColumnIndex].Name == "sua")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                byte[] anh = (byte[])selectedRow.Cells["anh"].Value;
                string magv = selectedRow.Cells["magv"].Value.ToString();
                string tengv = selectedRow.Cells["tengv"].Value.ToString();
                string  sdt = selectedRow.Cells["sdt"].Value.ToString();
                string ngaysinh = selectedRow.Cells["ngay"].Value.ToString();
                string tenk = selectedRow.Cells["tenkhoa"].Value.ToString();
                string mon = selectedRow.Cells["monday"].Value.ToString();
                string diachi = selectedRow.Cells["diachi"].Value.ToString();

                suagv gv = new suagv(anh, magv, tengv, sdt, ngaysinh, tenk, mon ,diachi);
                gv.Show();
            }
            if (grv.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult result = MessageBox.Show("Bạn muốn Xoá", "Xoá", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = grv.Rows[rowIndex];
                    string magv = selectedRow.Cells["magv"].Value.ToString();
                    var gvToDelete = da.giangviens.Where(gv => gv.magv == magv).FirstOrDefault();
                    da.giangviens.Remove(gvToDelete);
                    da.SaveChanges();
                    loaddata();
                }
                else { }
            }
        }

        private void quanliGV_Load(object sender, EventArgs e)
        {
                            this.khoaTableAdapter.Fill(this.du_AnDataSet3.khoa);
            this.hoc_phanTableAdapter.Fill(this.du_AnDataSet1.hoc_phan);
            loaddata();
            cb.SelectedIndex = -1; 
            mon.SelectedIndex = -1; 
            khoa1.SelectedIndex = -1;
            cb.Text = "Thống kê theo năm sinh";
            mon.Text = "Thống kê theo môn học";
            khoa1.Text = "Thống kê theo khoa";
            DataGridViewImageColumn pisc1 = new DataGridViewImageColumn();
            pisc1 = (DataGridViewImageColumn)grv.Columns[2];
           
            pisc1.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void tk_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tk_Click_1(object sender, EventArgs e)
        {
            List<object> resultsList = new List<object>();
            DateTime namsinh;
            if (DateTime.TryParse(cb.Text, out namsinh))
            {
                var results = (from gv in da.giangviens
                               where gv.ngaysinh == namsinh
                               select new { gv.magv, gv.tengv, gv.monday, gv.ngaysinh ,gv.tenkhoa }).ToList();
                resultsList.AddRange(results);
            }
            var results1 = (from gv in da.giangviens
                           where gv.monday == mon.Text
                           select new { gv.magv, gv.tengv, gv.monday, gv.ngaysinh, gv.tenkhoa }).ToList();
            resultsList.AddRange(results1);
            var results2 = (from gv in da.giangviens
                            where gv.tenkhoa == khoa1.Text
                            select new { gv.magv, gv.tengv, gv.monday, gv.ngaysinh, gv.tenkhoa }).ToList();
            resultsList.AddRange(results2);

            grt.DataSource = resultsList;
            grt.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cb.Text = "Thống kê theo năm sinh";
            mon.Text = "Thống kê theo môn học";
            khoa1.Text = "Thống kê theo khoa";
            grt.Visible = false;
            //thống kê
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            String timk = tim.Text;
            var results32 = (from gv in da.giangviens
                             where gv.tengv == timk
                             select new {gv.anh , gv.magv ,gv.tengv, gv.sdt ,gv.tenkhoa, gv.monday ,gv.diachi }).ToList();
            // tìm kiếm
            grv.DataSource = results32;
        }
    }
    }

