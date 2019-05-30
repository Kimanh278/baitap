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
    public partial class TBHK : MetroFramework.Forms.MetroForm
    {
        public TBHK()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);

        private void TBHK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet8.TBHK' table. You can move, or remove it, as needed.
            this.tBHKTableAdapter.Fill(this.qLHS_GV1DataSet8.TBHK);
            con.Open();
            GetAllXepLoai();       

        }
        public void GetAllXepLoai()
        {
            SqlCommand stcmd = new SqlCommand("select * from TBHK", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }
        private void LoadData()
        {
            txbMaNH.DataBindings.Clear();
            txbMaNH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");
            txbMaHK.DataBindings.Clear();
            txbMaHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");
            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");
            txbHK.DataBindings.Clear();
            txbHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaHanhKiem");
            txbTBHK.DataBindings.Clear();
            txbTBHK.DataBindings.Add("Text", dataGridView1.DataSource, "TBHK");
            txbHL.DataBindings.Clear();
            txbHL.DataBindings.Add("Text", dataGridView1.DataSource, "HocLuc");
            txbTenHS.DataBindings.Clear();
            txbTenHS.DataBindings.Add("Text", dataGridView1.DataSource, "TenHS");
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

        private void mttThem_Click(object sender, EventArgs e)
        {
            string stInsert = "insert into TBHK values(@MaNH, @MaHK, @MaHS,@MaHanhKiem, @TBHK,@HocLuc,@TenHS)";
            SqlCommand stinscmd = new SqlCommand(stInsert, con);
            stinscmd.Parameters.AddWithValue("MaNH", txbMaNH.Text);
            stinscmd.Parameters.AddWithValue("MaHK", txbMaHK.Text);
            stinscmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stinscmd.Parameters.AddWithValue("MaHanhKiem", txbHK.Text);
            stinscmd.Parameters.AddWithValue("TBHK",txbTBHK.Text);
            stinscmd.Parameters.AddWithValue("HocLuc", txbHL.Text);
            stinscmd.Parameters.AddWithValue("TenHS", txbTenHS.Text);
            stinscmd.ExecuteNonQuery();
            GetAllXepLoai();
        }

        private void mttSua_Click(object sender, EventArgs e)
        {
            string stUpdate = "update TBHK set MaNH = @MaNH, MaHK = @HK, MaHanhKiem = @MaHanhKiem, TBHK = @TBHK,HocLuc=@HocLuc,TenHS=@TenHS where MaHS = @MaHS";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaNH", txbMaNH.Text);
            stinscmd.Parameters.AddWithValue("MaHK", txbMaHK.Text);
            stinscmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stinscmd.Parameters.AddWithValue("MaHanhKiem", txbHK.Text);
            stinscmd.Parameters.AddWithValue("TBHK", txbTBHK.Text);
            stinscmd.Parameters.AddWithValue("HocLuc", txbHL.Text);
            stinscmd.Parameters.AddWithValue("TenHS", txbTenHS1.Text);
            stinscmd.ExecuteNonQuery();
            GetAllXepLoai();
        }

        private void mttReload_Click(object sender, EventArgs e)
        {
            GetAllXepLoai();
        }

        private void mttXoa_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from TBHK where MaHS = @MaHS";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            MessageBox.Show(" Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            stdelcmd.ExecuteNonQuery();
            GetAllXepLoai();
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
            string query = "select *from TBHK where TenHS like N'%" + TimKiem + "%'or MaHS like '%" + TimKiem + "%'or HocLuc like '%" + TimKiem + "%' or MaHanhKiem like '%"+TimKiem+ "%'or MaHK like '%" + TimKiem + "%'or MaNH like '%" + TimKiem + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }
    }
}
