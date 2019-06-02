using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WQLHS_GV1
{
    public partial class CTDiemHSinh : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        public CTDiemHSinh()
        {
            InitializeComponent();
        }

        private void CTDiemHSinh_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLHS_GV1DataSet10.MONHOC' table. You can move, or remove it, as needed.
            //this.mONHOCTableAdapter.Fill(this.qLHS_GV1DataSet10.MONHOC);
            //// TODO: This line of code loads data into the 'qLHS_GV1DataSet10.LOP' table. You can move, or remove it, as needed.
            //this.lOPTableAdapter.Fill(this.qLHS_GV1DataSet10.LOP);
            //// TODO: This line of code loads data into the 'qLHS_GV1DataSet10.HOCKY' table. You can move, or remove it, as needed.
            //this.hOCKYTableAdapter.Fill(this.qLHS_GV1DataSet10.HOCKY);
            //// TODO: This line of code loads data into the 'qLHS_GV1DataSet10.NAMHOC' table. You can move, or remove it, as needed.
            //this.nAMHOCTableAdapter.Fill(this.qLHS_GV1DataSet10.NAMHOC);
            con.Open();
            this.reportViewer1.RefreshReport();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CND12";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@MaNH", cbbMaNH.Text));
            cmd.Parameters.Add(new SqlParameter("@MaHK", txbMaHK.Text));
            cmd.Parameters.Add(new SqlParameter("@MaLop", txbMaLop.Text));
            cmd.Parameters.Add(new SqlParameter("@TenMH", txbTenMH.Text));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            if ((ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows.Count > 0))
            {
                ReportDataSource rds1 = new ReportDataSource();
                rds1.Name = "CND12";
                rds1.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds1);
                reportViewer1.RefreshReport();
            }
        }
    }
}
