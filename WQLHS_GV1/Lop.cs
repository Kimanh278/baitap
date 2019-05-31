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
    public partial class Lop : MetroFramework.Forms.MetroForm
    {
        public Lop()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);

        private void Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHS_GV1DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHS_GV1DataSet.NAMHOC);
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHS_GV1DataSet.LOP);
            con.Open();
            GetAllLop();
        }
        private void LoadData()
        {
            txbMaLop.DataBindings.Clear();
            txbMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MaLop");
            txbTenLop.DataBindings.Clear();
            txbTenLop.DataBindings.Add("Text", dataGridView1.DataSource, "TenLop");
            cbbMaNH.DataBindings.Clear();
            cbbMaNH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");
            txbMaGV.DataBindings.Clear();
            txbMaGV.DataBindings.Add("Text", dataGridView1.DataSource, "MaGV");
        }

        public void GetAllLop()
        {
            SqlCommand stcmd = new SqlCommand("select * from LOP", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }

        private void mttReload_Click(object sender, EventArgs e)
        {
            GetAllLop();
        }

        private void mttThem_Click(object sender, EventArgs e)
        {
            string stInsert = "insert into LOP values(@MaLop, @TenLop, @MaNH,@MaGV)";
            SqlCommand stinscmd = new SqlCommand(stInsert, con);
            stinscmd.Parameters.AddWithValue("MaLop", txbMaLop.Text);
            stinscmd.Parameters.AddWithValue("TenLop", txbTenLop.Text);
            stinscmd.Parameters.AddWithValue("MaNH", cbbMaNH.Text);
            stinscmd.Parameters.AddWithValue("MaGV", txbMaGV.Text);
            stinscmd.ExecuteNonQuery();
            GetAllLop();
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
        private void mttSua_Click(object sender, EventArgs e)
        {
            string stUpdate = "update LOP set TenLop = @TenLop, MaNH = @MaNH, MaGV = @MaGV where MaLop = @MaLop";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaLop", txbMaLop.Text);
            stinscmd.Parameters.AddWithValue("TenLop", txbTenLop.Text);
            stinscmd.Parameters.AddWithValue("MaNH", cbbMaNH.Text);
            stinscmd.Parameters.AddWithValue("MaGV", txbMaGV.Text);
            stinscmd.ExecuteNonQuery();
            GetAllLop();
        }
        //xoathongtinlop
        private void mttXoa_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from Lop where MaLop = @Malop";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaLop", txbMaLop.Text);
            stdelcmd.ExecuteNonQuery();
            GetAllLop();
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
        private void DgvStudent_SelectionChanged(object sender, EventArgs e)
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
            string query = "select *from dbo.Lop where TenLop like N'" + TimKiem + "%'or MaLop like '" + TimKiem + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }

        private void Lop_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }
    }
}
