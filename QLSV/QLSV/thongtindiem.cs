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

namespace QLSV
{
    public partial class thongtindiem : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        string maText = GlobalData.MaText;
        public thongtindiem()
        {
            InitializeComponent();
        }

        private void thongtindiem_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maText))
            {
                var result = from c in da.diems
                             where c.masv == maText
                             select new
                             {
                                 c.id,
                                 c.masv,
                                 c.tensv,
                                 c.monhoc,
                                 c.diem1,
                                 c.diem2,
                                 c.diem3,
                                 c.diemtb,
                                 c.ketqua
                             };
                grv.DataSource = result.ToList();

            }
        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Columns[e.ColumnIndex].Name == "ct")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                string diem1 = selectedRow.Cells["diem1"].Value.ToString();
                string diem2 = selectedRow.Cells["diem2"].Value.ToString();
                string diem3 = selectedRow.Cells["diem3"].Value.ToString();
                double p1 = Convert.ToDouble(diem1);
                double p2 = Convert.ToDouble(diem2);
                double p3 = Convert.ToDouble(diem3);

                chitietdiem ea = new chitietdiem(p1, p2, p3);
                ea.Show();



            }
        }
    }
}
