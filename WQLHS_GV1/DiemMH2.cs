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
    public partial class DiemMH2 : MetroFramework.Forms.MetroForm
    {
        public DiemMH2()
        {
            InitializeComponent();
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            CTdiemHS CT = new CTdiemHS();
            CT.ShowDialog();
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            TBHK TB = new TBHK();
            TB.ShowDialog();
        }
    }
}
