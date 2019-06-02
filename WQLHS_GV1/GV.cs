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
    public partial class GV : MetroFramework.Forms.MetroForm
    {
        public GV()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);

        private void cbbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet8.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHS_GV1DataSet8.GIAOVIEN);
            con.Open();

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
        private void LoadData()
        {
            txbMaGV.DataBindings.Clear();
            txbMaGV.DataBindings.Add("Text", dataGridView1.DataSource, "MaGV");
            txbTenGV.DataBindings.Clear();
            txbTenGV.DataBindings.Add("Text", dataGridView1.DataSource, "TenGV");
            txbDiaChi.DataBindings.Clear();
            txbDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            cbbMaMH.DataBindings.Clear();
            cbbMaMH.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");

        }
        public void GetAllGiaoVien()
        {
            SqlCommand stcmd = new SqlCommand("select * from GiaoVien", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                LoadData();
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "select * from GIAOVIEN where MaGV='" + txbMaGV.Text + "'";
            SqlCommand stinscmd1 = new SqlCommand(sql, con);
            SqlDataReader reader = stinscmd1.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                MessageBox.Show(" Tồn tại mã giáo vên. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                reader.Close();
                string stInsert = "insert into GiaoVien values(@MaGV, @TenGV, @DiaChi, @MaMH)";
                SqlCommand stinscmd = new SqlCommand(stInsert, con);
                stinscmd.Parameters.AddWithValue("MaGV", txbMaGV.Text);
                stinscmd.Parameters.AddWithValue("TenGV", txbTenGV.Text);
                stinscmd.Parameters.AddWithValue("DiaChi", txbDiaChi.Text);
                stinscmd.Parameters.AddWithValue("MaMH", cbbMaMH.Text);
                MessageBox.Show(" Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stinscmd.ExecuteNonQuery();
                GetAllGiaoVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string stUpdate = "update GiaoVien set TenGV = @TenGV, DiaChi = @DiaChi, MaMH = @MaMH where MaGV= @MaGV";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaGV", txbMaGV.Text);
            stinscmd.Parameters.AddWithValue("TenGV", txbTenGV.Text);
            stinscmd.Parameters.AddWithValue("DiaChi", txbDiaChi.Text);
            stinscmd.Parameters.AddWithValue("MaMH", cbbMaMH.Text);
            MessageBox.Show(" Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stinscmd.ExecuteNonQuery();
            GetAllGiaoVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from GiaoVien where MaGV = @MaGV";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaGV", txbMaGV.Text);
            MessageBox.Show(" Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stdelcmd.ExecuteNonQuery();
            GetAllGiaoVien();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            GetAllGiaoVien();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string query = "select *from dbo.GIAOVIEN where TenGV like '%" + txbTK.Text + "%'or MaGV like '%" + txbTK.Text + "%' or MaMH like '%" + cbbMaMH + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }
    }
}
