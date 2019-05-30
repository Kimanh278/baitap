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
    public partial class DuaraReport : MetroFramework.Forms.MetroForm
    {
        public DuaraReport()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CTDiemHSinh M = new CTDiemHSinh();
            M.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            TBCN TB = new TBCN();
            TB.ShowDialog();
        }
    }
}
