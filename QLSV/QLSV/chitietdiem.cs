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
    public partial class chitietdiem : Form
    {
        public double diem1 { get; set; }
        public double diem2 { get; set; }
        public double diem3 { get; set; }
        public chitietdiem(double dt1, double dt2, double dt3)
        {
            InitializeComponent();
            this.diem1 = dt1;
            this.diem2 = dt2;
            this.diem3 = dt3;
            d1.Text = dt1.ToString();
            d2.Text = dt2.ToString();
            d3.Text = dt3.ToString();
        }

        private void chitietdiem_Load(object sender, EventArgs e)
        {

        }
    }
}
