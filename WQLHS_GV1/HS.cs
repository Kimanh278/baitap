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
    public partial class HS : MetroFramework.Forms.MetroForm
    {
        public HS()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void HS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet13.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter1.Fill(this.qLHS_GV1DataSet13.HOCSINH);
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet10.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qLHS_GV1DataSet10.HOCSINH);
            con.Open();
            loadcombobox();
            loadcombobox2();
            GetAllHocSinh();

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
            public void GetAllHocSinh()
            {
                SqlCommand stcmd = new SqlCommand("select * from HocSinh", con);
                stcmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
                DataTable sttable = new DataTable();
                adapter.Fill(sttable);
                dataGridView1.DataSource = sttable;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                string sql = "select * from HocSinh where MaHS='" + txbMaHS.Text + "'";
                SqlCommand stinscmd1 = new SqlCommand(sql, con);
                SqlDataReader reader = stinscmd1.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    MessageBox.Show(" Tồn tại mã học sinh. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    reader.Close();
                    string stInsert = "insert into HOCSINH values(@MaHS, @TenHS, @GioiTinh,@NgaySinh,@DiaChi, @MaLop)";
                    SqlCommand stinscmd = new SqlCommand(stInsert, con);
                stinscmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
                stinscmd.Parameters.AddWithValue("TenHS", txbTenHS.Text);
                stinscmd.Parameters.AddWithValue("GioiTinh", cbbGioiTinh.Text);
                stinscmd.Parameters.AddWithValue("NgaySinh", Convert.ToDateTime(dtpNgaySinh.Text));
                stinscmd.Parameters.AddWithValue("DiaChi", txbDiaChi.Text);
                stinscmd.Parameters.AddWithValue("MaLop", cbbMaLop.Text);
                MessageBox.Show(" Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stinscmd.ExecuteNonQuery();
                    GetAllHocSinh();
                }
            }
        private void LoadData()
        {

            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");
            txbTenHS.DataBindings.Clear();
            txbTenHS.DataBindings.Add("Text", dataGridView1.DataSource, "TenHS");
            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dataGridView1.DataSource, "GioiTinh");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dataGridView1.DataSource, "NgaySinh");
            txbDiaChi.DataBindings.Clear();
            txbDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            cbbMaLop.DataBindings.Clear();
            cbbMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MaLop");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string stUpdate = "update HOCSINH set TenHS = @TenHS, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,DiaChi=@DiaChi, MaLop = @MaLop where MaHS = @MaHS";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stinscmd.Parameters.AddWithValue("TenHS", txbTenHS.Text);
            stinscmd.Parameters.AddWithValue("GioiTinh", cbbGioiTinh.Text);
            stinscmd.Parameters.AddWithValue("NgaySinh", Convert.ToDateTime(dtpNgaySinh.Text));
            stinscmd.Parameters.AddWithValue("DiaChi", txbDiaChi.Text);
            stinscmd.Parameters.AddWithValue("MaLop", cbbMaLop.Text);
            MessageBox.Show(" Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stinscmd.ExecuteNonQuery();
            GetAllHocSinh();
        }
        void loadcombobox()
        {
            var cmd = new SqlCommand("select GioiTinh from HocSinh", con);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbGioiTinh.DisplayMember = "GioiTinh";
            cbbGioiTinh.DataSource = dt;
        }
        void loadcombobox2()
        {
            var cmd = new SqlCommand("select MaLop from HocSinh", con);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMaLop.DisplayMember = "MaLop";
            cbbMaLop.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from HOCSINH where MaHS = @MaHS";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stdelcmd.ExecuteNonQuery();
            MessageBox.Show(" Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAllHocSinh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAllHocSinh();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string TimKiem = txbTK.Text;
            string query = "select *from dbo.HOCSINH where TenHS like N'%" + TimKiem + "%'or MaHS like '%" + TimKiem + "%'or GioiTinh like '%" + TimKiem + "%'or MaLop like '%" + TimKiem + "%'or DiaChi like N'%" + TimKiem + "%' ";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }
    }
 }