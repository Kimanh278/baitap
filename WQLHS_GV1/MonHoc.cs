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
    public partial class MonHoc : MetroFramework.Forms.MetroForm
    {
        public MonHoc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        private void MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHS_GV1DataSet.MONHOC);
            con.Open();
            loadcombobox();
            loadcombobox1();
            GetAllMonHoc();
        }
        public void GetAllMonHoc()
        {
            SqlCommand stcmd = new SqlCommand("select * from MONHOC", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }

        private void mttReload_Click(object sender, EventArgs e)
        {
            GetAllMonHoc();
        }

        private void mttThem_Click(object sender, EventArgs e)
        {
            string sql = "select * from MONHOC where MaMH='" + txbMaMH.Text + "'";
            SqlCommand stinscmd1 = new SqlCommand(sql, con);
            SqlDataReader reader = stinscmd1.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                MessageBox.Show(" Tồn tại mã môn học. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reader.Close();
                string stInsert = "insert into MONHOC values(@MaMH, @TenMH)";
                SqlCommand stinscmd = new SqlCommand(stInsert, con);
                stinscmd.Parameters.AddWithValue("MaMH", txbMaMH.Text);
                stinscmd.Parameters.AddWithValue("TenMH", txbTenMH.Text);
                MessageBox.Show(" Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stinscmd.ExecuteNonQuery();
                GetAllMonHoc();
            }
        }

        private void mttSua_Click(object sender, EventArgs e)
        {
            string stUpdate = "update MONHOC set TenMH = @TenMH where MaMH = @MaMH";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaMH", txbMaMH.Text);
            stinscmd.Parameters.AddWithValue("TenMH", txbTenMH.Text);
            MessageBox.Show(" Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stinscmd.ExecuteNonQuery();
            GetAllMonHoc();
        }

        private void mttXoa_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from MONHOC where MaMH= @MaMH";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaMH", txbMaMH.Text);
            MessageBox.Show(" Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stdelcmd.ExecuteNonQuery();
            GetAllMonHoc();
        }
        private void LoadData()
        {
            txbMaMH.DataBindings.Clear();
            txbMaMH.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");
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
        private void btnTK_Click(object sender, EventArgs e)
        {
            string TimKiem = txbTK.Text;
            string query = "select *from dbo.MONHOC where TenMH like N'%" + TimKiem + "%'or MaMH like '%" + TimKiem + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }

        private void dgvMonHoc(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                LoadData();
            }
            catch
            { }
        }
        void loadcombobox()
        {
            var cmd = new SqlCommand("select MaMH from MonHoc", con);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaMH.DisplayMember = "MaMH";
            cbbMaMH.DataSource = dt;
        }
        void loadcombobox1()
        {
            var cmd = new SqlCommand("select MaHK from HocKy", con);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaHK.DisplayMember = "MaHK";
            cbbMaHK.DataSource = dt;
        }

        private void btnTìmKiem_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("Select_DiemMH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaMH", SqlDbType.Char).Value = cbbMaMH.Text;
            cmd.Parameters.Add("@MaHK", SqlDbType.Char).Value = cbbMaHK.Text;  
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;
           // cbbMaMH.DataBindings.Clear();
           // cbbMaMH.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");
           // cbbMaHK.DataBindings.Clear();
           //cbbMaHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");
        }
    }
}
