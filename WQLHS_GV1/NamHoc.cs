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
    public partial class NamHoc : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        public NamHoc()
        {
            InitializeComponent();
        }
        public void GetAllNamHoc()
        {
            SqlCommand stcmd = new SqlCommand("select * from NAMHOC", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }

        private void mttThem_Click(object sender, EventArgs e)
        {

            string sql = "select * from NAMHOC where MaNH='" + txbMaNH.Text + "'";
            SqlCommand stinscmd1 = new SqlCommand(sql, con);
            SqlDataReader reader = stinscmd1.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                MessageBox.Show(" Tồn tại mã năm học. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reader.Close();
                string stInsert = "insert into NAMHOC values(@MaNH, @TenNH)";
                SqlCommand stinscmd = new SqlCommand(stInsert, con);
                stinscmd.Parameters.AddWithValue("MaNH", txbMaNH.Text);
                stinscmd.Parameters.AddWithValue("TenNH", txbTenNH1.Text);
                MessageBox.Show(" Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stinscmd.ExecuteNonQuery();
                GetAllNamHoc();
            }
        }
       

        private void NamHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet.NAMHOC' table. You can move, or remove it, as needed.
            //this.nAMHOCTableAdapter.Fill(this.qLHS_GV1DataSet.NAMHOC);
            con.Open();
            GetAllNamHoc();
        }
        private void LoadData()
        {
            txbMaNH.DataBindings.Clear();
            txbMaNH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");
            txbTenNH1.DataBindings.Clear();
            txbTenNH1.DataBindings.Add("Text", dataGridView1.DataSource, "TenNH");
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
            GetAllNamHoc();
        }

        private void mttSua_Click(object sender, EventArgs e)
        {
            string stUpdate = "update NAMHOC set TenNH = @TenNH where MaNH = @MaNH";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaNH", txbMaNH.Text);
            stinscmd.Parameters.AddWithValue("TenNH", txbTenNH1.Text);
            MessageBox.Show(" Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stinscmd.ExecuteNonQuery();
            GetAllNamHoc();
        }

        private void mttXoa_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from NAMHOC where MaNH= @MaNH";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaNH", txbMaNH.Text);
            MessageBox.Show(" Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stdelcmd.ExecuteNonQuery();
            GetAllNamHoc();
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
            string query = "select *from dbo.NAMHOC where TenNH like N'" + TimKiem + "%'or MaNH like '" + TimKiem + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];

        }

        private void NamHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }
    }
}
