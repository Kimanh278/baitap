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
    public partial class HocKy : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        public HocKy()
        {
            InitializeComponent();
        }
        public void GetAllHocKy()
        {
            SqlCommand stcmd = new SqlCommand("select * from HOCKY", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }

        private void mttXoa_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from HOCKY where MaHK= @MaHK";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaHK", ccbMaHK.Text);
            stdelcmd.ExecuteNonQuery();
            GetAllHocKy();
        }

        private void HocKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHS_GV1DataSet.HOCKY);
            con.Open();
            GetAllHocKy();

        }
        private void LoadData()
        {
            ccbMaHK.DataBindings.Clear();
            ccbMaHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");
            ccbTenHK.DataBindings.Clear();
            ccbTenHK.DataBindings.Add("Text", dataGridView1.DataSource, "TenHK");
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

        private void mttReload_Click(object sender, EventArgs e)
        {
            GetAllHocKy();
        }

        private void mttSua_Click(object sender, EventArgs e)
        {
            string stUpdate = "update HOCKY set TenHK = @TenHK where MaHK = @MaHK";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaHK", ccbMaHK.Text);
            stinscmd.Parameters.AddWithValue("TenHK", ccbMaHK.Text);
            stinscmd.ExecuteNonQuery();
            GetAllHocKy();
        }

        private void mttThem_Click(object sender, EventArgs e)
        {

            string stInsert = "insert into HOCKY values(@MaHK, @TenHK)";
            SqlCommand stinscmd = new SqlCommand(stInsert, con);
            stinscmd.Parameters.AddWithValue("MaHK", ccbMaHK.Text);
            stinscmd.Parameters.AddWithValue("TenHK", ccbTenHK.Text);
            stinscmd.ExecuteNonQuery();
            GetAllHocKy();
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

        private void btnTK_Click(object sender, EventArgs e)
        {
            string TimKiem = txbTK.Text;
            string query = "select *from dbo.HOCKY where TenHK like N'" + TimKiem + "%'or MaHK like '" + TimKiem + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }
    }
}
