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
    public partial class chitietlop : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        public string tenlop { get; set; }
        public chitietlop(String Ten)
        {
            InitializeComponent();
            this.tenlop = Ten;
        }

        private void chitietlop_Load(object sender, EventArgs e)
        {
            tenlops.Text = tenlop;
            if (tenlops.Text == tenlop)
            {
                var result = from sv in da.sinhviens where sv.tenlop == tenlops.Text select new { sv.masv, sv.tensv, sv.gioitinh, sv.tenlop };
                dth.DataSource = result.ToList();
                dth.FirstDisplayedScrollingRowIndex = dth.Rows.Count - 1;
            }
        }
    }
}
