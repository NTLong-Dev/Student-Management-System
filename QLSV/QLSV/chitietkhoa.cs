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
    public partial class chitietkhoa : Form
    {
        Du_AnEntities du_An = new Du_AnEntities();
        public string tenkhoa { get; set; }
        public chitietkhoa(String Ten)
        {
            InitializeComponent();
            this.tenkhoa = Ten;
            
        }

        private void chitietkhoa_Load(object sender, EventArgs e)
        {
            ten.Text = tenkhoa;
            if (ten.Text == tenkhoa)
            {
                var result = from l in du_An.lops where l.tenkhoa == ten.Text select new { l.malop, l.tenlop, l.khoahoc };
                dth.DataSource = result.ToList();
                dth.FirstDisplayedScrollingRowIndex = dth.Rows.Count - 1;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
