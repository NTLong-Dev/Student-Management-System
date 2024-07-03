using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLSV.Profile;
using static QLSV.ProfileGV;

namespace QLSV
{
    public partial class lopvakhoa : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        string maText = GlobalData.MaText;
        string maTextgv = GlobalData1.MaTextgv;
        public lopvakhoa()
        {
            InitializeComponent();
        }


        private void p3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            themkhoa them = new themkhoa();
            them.Show();
        }
        public void loaddata()
        {
            var result = from k in da.khoas select new {k.makhoa ,k.tenkhoa};
            grv.DataSource = result.ToList();
            var result1 = from p in da.lops select new{p.malop ,p.tenlop , p.tenkhoa ,p.khoahoc};
            ddg.DataSource = result1.ToList();
            var result22 = da.khoas.Count();
            int count = result22;
            label5.Text = count.ToString();
            var result23 = da.lops.Count();
            int counts = result23;
            label8.Text = counts.ToString();
        }
        private void lopvakhoa_Load(object sender, EventArgs e)

        {
            cb.SelectedIndex = -1;
            cb.Text = "Thống kê theo khoá học";
            loaddata();
            if (!string.IsNullOrEmpty(maText))
            {
                    add1.Visible = false;
                    grv.Columns["sua"].Visible = false;
                    grv.Columns["xoa"].Visible = false;
                    add2.Visible = false;
                    ddg.Columns["edit"].Visible = false;
                    ddg .Columns["delete"].Visible = false;
                    tabControl1.TabPages.Remove(tabPage3);
                    tabPage1.Text = "Thông tin khoa";
                    tabPage5.Text = "Thông tin lớp"; 



            }
            if (!string.IsNullOrEmpty(maTextgv))
            {
                add1.Visible = true;
                grv.Columns["sua"].Visible = true;
                grv.Columns["xoa"].Visible = true;
                add2.Visible = true;
                ddg.Columns["edit"].Visible = true;
                ddg.Columns["delete"].Visible = true;




            }
        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Columns[e.ColumnIndex].Name == "sua")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                string ma = selectedRow.Cells["mak"].Value.ToString();
                string ten = selectedRow.Cells["tenk"].Value.ToString();

                suakhoa sua = new suakhoa(ma, ten);
                sua.Show();
            }
            if (grv.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult result = MessageBox.Show("Bạn muốn Xoá", "Xoá", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = grv.Rows[rowIndex];
                    string makhoas = selectedRow.Cells["mak"].Value.ToString();
                    var Delete = da.khoas.Where(k => k.makhoa == makhoas).FirstOrDefault();
                    da.khoas.Remove(Delete);
                    da.SaveChanges();
                    loaddata();
                }
                else { }
            }
            if (grv.Columns[e.ColumnIndex].Name == "ct")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                string ten = selectedRow.Cells["tenk"].Value.ToString();

                chitietkhoa ct = new chitietkhoa(ten);
                ct.Show();
            }
        }

        private void ddg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ddg.Columns[e.ColumnIndex].Name == "edit")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = ddg.Rows[rowIndex];
                string ma1 = selectedRow.Cells["mal"].Value.ToString();
                string ten1 = selectedRow.Cells["tenl"].Value.ToString();
                string tenK = selectedRow.Cells["tenkh"].Value.ToString();
                string khoahoc = selectedRow.Cells["kh"].Value.ToString();

                sualop sua1 = new sualop(ma1, ten1 , tenK, khoahoc);
                sua1.Show();
            }
            
            if (ddg.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult result = MessageBox.Show("Bạn muốn Xoá", "Xoá", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = ddg.Rows[rowIndex];
                    string malops = selectedRow.Cells["mal"].Value.ToString();
                    var Delete = da.lops.Where(l => l.malop == malops).FirstOrDefault();
                    da.lops.Remove(Delete);
                    da.SaveChanges();
                    loaddata();
                }
                else { }
                
            }
            if (ddg.Columns[e.ColumnIndex].Name == "chitiet12")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = ddg.Rows[rowIndex];
                string ten12 = selectedRow.Cells["tenl"].Value.ToString();

                chitietlop ct1 = new chitietlop(ten12);
                ct1.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            themlop lop = new themlop();  
            lop.Show();
        }

        private void tk_Click(object sender, EventArgs e)
        {
            List<object> resultsList = new List<object>();
            var results2s = (from lp in da.lops
                            where lp.khoahoc == cb.Text
                            select new { lp.malop, lp.tenlop, lp.tenkhoa, lp.khoahoc }).ToList();
            resultsList.AddRange(results2s);

            ddt.DataSource = resultsList;
            ddt.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cb.Text = "Thống kê theo khoá học";
            ddt.Visible = false;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            String timk = tim1.Text;
            var results32 = (from lp in da.lops
                             where lp.tenlop == timk
                             select new { lp.malop, lp.tenlop, lp.tenkhoa, lp.khoahoc }).ToList();

            ddg.DataSource = results32;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            String timk = tim.Text;
            var results32 = (from k in da.khoas
                             where k.tenkhoa == timk
                             select new { k.makhoa, k.tenkhoa }).ToList();

            grv.DataSource = results32;
        }

        private void ddt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
