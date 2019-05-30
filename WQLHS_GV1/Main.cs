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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mttHS_Click(object sender, EventArgs e)
        {
            HS hs = new HS();
            hs.ShowDialog();
         
        }

        private void mttGV_Click(object sender, EventArgs e)
        {
            GV gv = new GV();
            gv.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void mttLop_Click(object sender, EventArgs e)
        {
            Lop lh = new Lop();
            lh.ShowDialog();
        }

        private void mttMH_Click(object sender, EventArgs e)
        {
            TongQuanMonHoccs TQ = new TongQuanMonHoccs();
            TQ.ShowDialog();
        }

        private void mttNamHoc_Click(object sender, EventArgs e)
        {
            NamHoc NH = new NamHoc();
            NH.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            HocKy HK = new HocKy();
            HK.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DiemMH2 DMH = new DiemMH2();
            DMH.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            DuaraReport RP = new DuaraReport();
            RP.ShowDialog();
        }
    }
}
