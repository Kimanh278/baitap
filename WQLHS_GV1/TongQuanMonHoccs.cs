using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WQLHS_GV1
{
    public partial class TongQuanMonHoccs : MetroFramework.Forms.MetroForm
    {
        public TongQuanMonHoccs()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            GiangDaycs GD = new GiangDaycs();
            GD.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MonHoc MH = new MonHoc();
            MH.ShowDialog();
        }
    }
}
