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
    public partial class GiangDaycs : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        public GiangDaycs()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        public void GetAllGiangDay()
        {
            SqlCommand stcmd = new SqlCommand("select * from GiangDay", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }
        private void GiangDaycs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet7.GiangDay' table. You can move, or remove it, as needed.
            //this.giangDayTableAdapter.Fill(this.qLHS_GV1DataSet7.GiangDay);
            con.Open();
            GetAllGiangDay();

        }

        private void mttReload_Click(object sender, EventArgs e)
        {
            GetAllGiangDay();
        }
        private void LoadData()
        {
            txbMaGV.DataBindings.Clear();
            txbMaGV.DataBindings.Add("Text", dataGridView1.DataSource, "MaGV");
            txbTenGV.DataBindings.Clear();
            txbTenGV.DataBindings.Add("Text", dataGridView1.DataSource, "TenGV");
            txbTenMH.DataBindings.Clear();
            txbTenMH.DataBindings.Add("Text", dataGridView1.DataSource, "TenMH");
            
        }
        DataSet timkiem(string query)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();

            }
            return dt;
        }
        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                LoadData();
            }
            catch
            { }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string TimKiem = txbTK.Text;
            string query = "select *from GiangDay where TenGV like N'%" + TimKiem + "%'or MaGV like '%" + TimKiem + "%'or TenMH like N'%" + TimKiem + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }
    }
}
