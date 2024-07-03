using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLSV.Profile;
using static QLSV.ProfileGV;
namespace QLSV
{
    public partial class hocphan : Form
    {
        Du_AnEntities du_An = new Du_AnEntities();
        string maText = GlobalData.MaText;
        string maTextgv = GlobalData1.MaTextgv;

        public hocphan()
        {
            InitializeComponent();
        }
       public void loadData()
        {
            var result = from c in du_An.hoc_phan select new {c.mahp, c.tenhp ,c.namhoc, c.sotinchi};
            grv.DataSource = result.ToList();
            var result22 = du_An.hoc_phan.Count();
            int count = result22;
            sl.Text = count.ToString();
            var result3 = (from sv in du_An.hoc_phan
                           select sv.namhoc).Distinct();

            foreach (var kq in result3)
            {
                cb.Items.Add(kq);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            themhp hp = new themhp();
            hp.Show();
        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Columns[e.ColumnIndex].Name == "sua")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                string ma = selectedRow.Cells["mahp"].Value.ToString();
                string ten = selectedRow.Cells["tenhp"].Value.ToString();
                string nh1 = selectedRow.Cells["namhoc"].Value.ToString();
                string tc = selectedRow.Cells["tinchi"].Value.ToString();
                int tinchi = int.Parse(tc);

                suahp sua = new suahp(ma,ten,nh1, tinchi);
                sua.Show();
            }
            if (grv.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult result = MessageBox.Show("Bạn muốn Xoá", "Xoá", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = grv.Rows[rowIndex];
                    string mahps = selectedRow.Cells["mahp"].Value.ToString();
                    var hpToDelete = du_An.hoc_phan.Where(sv => sv.mahp == mahps).FirstOrDefault();
                    du_An.hoc_phan.Remove(hpToDelete);
                    du_An.SaveChanges();
                    loadData();
                }
                else { }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        private void hocphan_Load(object sender, EventArgs e)
        {
          
            loadData();
            if (!string.IsNullOrEmpty(maText))
            {
                add.Visible = false;
                grv.Columns["sua"].Visible = false;
                grv.Columns["xoa"].Visible = false;
                tabControl1.TabPages.Remove(tabPage2);
                tabPage1.Text = "Thông tin học phần";


            }
            if (!string.IsNullOrEmpty(maTextgv))
            {
                add.Visible = true;
                grv.Columns["sua"].Visible = true;
                grv.Columns["xoa"].Visible = true;


            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tk_Click(object sender, EventArgs e)
        {
            List<object> resultsList = new List<object>();
            String namhocs = cb.Text;
       
                var results = (from hp in du_An.hoc_phan
                               where hp.namhoc == namhocs
                               select new { hp.tenhp , hp.namhoc }).Distinct().ToList();
                resultsList.AddRange(results);
            // Thống kê
            gtt.DataSource = resultsList;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            String timk = tim.Text;
            var results32 = (from hp in du_An.hoc_phan
                             where hp.tenhp == timk
                             select new { hp.mahp, hp.tenhp, hp.namhoc}).ToList();

            grv.DataSource = results32;
            //tìm kiếm
        }
    }
}
