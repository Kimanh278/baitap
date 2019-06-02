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
    public partial class CTdiemHS : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
        public CTdiemHS()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void CTdiemHS_Load(object sender, EventArgs e)
        {
            con.Open();

            // TODO: This line of code loads data into the 'qLHS_GV1DataSet10.HOCSINH' table. You can move, or remove it, as needed.
            //this.hOCSINHTableAdapter.Fill(this.qLHS_GV1DataSet10.HOCSINH);
            //// TODO: This line of code loads data into the 'qLHS_GV1DataSet10.MONHOC' table. You can move, or remove it, as needed.
            //this.mONHOCTableAdapter.Fill(this.qLHS_GV1DataSet10.MONHOC);
            // TODO: This line of code loads data into the 'qLHS_GV1DataSet10.LOP' table. You can move, or remove it, as needed.
            //this.lOPTableAdapter.Fill(this.qLHS_GV1DataSet10.LOP);
            GetAllDiem();
        }
        public void GetAllDiem()
        {
            SqlCommand stcmd = new SqlCommand("select * from DIEM", con);
            stcmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(stcmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            dataGridView1.DataSource = sttable;
        }
        private void LoadData()
        {
            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");        
            txbNamH.DataBindings.Clear();
            txbNamH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");
            txbMaHK.DataBindings.Clear();
            txbMaHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");
            txbMH.DataBindings.Clear();
            txbMH.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");
            txbDM_1.DataBindings.Clear();
            txbDM_1.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_1");
            txbDM_2.DataBindings.Clear();
            txbDM_2.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_2");
            txbDM_3.DataBindings.Clear();
            txbDM_3.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_3");
            txbD15_1.DataBindings.Clear();
            txbD15_1.DataBindings.Add("Text", dataGridView1.DataSource, "D15_1");
            txbD15_2.DataBindings.Clear();
            txbD15_2.DataBindings.Add("Text", dataGridView1.DataSource, "D15_2");
            txbD15_3.DataBindings.Clear();
            txbD15_3.DataBindings.Add("Text", dataGridView1.DataSource, "D15_3");
            txbD45_1.DataBindings.Clear();
            txbD45_1.DataBindings.Add("Text", dataGridView1.DataSource, "D45_1");
            txbD45_2.DataBindings.Clear();
            txbD45_2.DataBindings.Add("Text", dataGridView1.DataSource, "D45_2");
            txbDThi.DataBindings.Clear();
            txbDThi.DataBindings.Add("Text", dataGridView1.DataSource, "DThi");
            txbD_TB.DataBindings.Clear();
            txbD_TB.DataBindings.Add("Text", dataGridView1.DataSource, "DiemTB");
            
        }

        private void mttThem_Click(object sender, EventArgs e)
        {
        
        }

        private void mttSua_Click(object sender, EventArgs e)
        {
           
            
        }

        private void mttXoa_Click(object sender, EventArgs e)
        {
            
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
            string query = "select *from DIEM where  MaHS like '%" + txbTK.Text + "%' or MaMH like '%" + txbTK.Text +  "%'or MaNH like '%" + txbTK.Text + "%'or MaHK like '%" + txbTK.Text + "%'";
            dataGridView1.DataSource = timkiem(query).Tables[0];
        }

        private void txbTK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCND_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txbDM_1.Text);
            int b = Convert.ToInt32(txbDM_2.Text);
            int c = Convert.ToInt32(txbDM_3.Text);
            int d = Convert.ToInt32(txbD15_1.Text);
            int o = Convert.ToInt32(txbD15_2.Text);
            int f = Convert.ToInt32(txbD15_3.Text);
            int g = Convert.ToInt32(txbD45_1.Text);
            int h = Convert.ToInt32(txbD45_2.Text);
            int y = Convert.ToInt32(txbDThi.Text);
            double tong = (a + b + c + d + o + f + g * 2 + h * 2 + y * 3);
            double dtb = tong / 13;
            dtb = Math.Round(dtb, 1);
            string update = "UPDATE DIEM SET DiemTB = " + dtb + " where MaHS=@MaHS and MaMH=@MaMH and MaNH=@MaNH and MaHK=@MaHK ";
            SqlCommand stinscmd = new SqlCommand(update, con);
            stinscmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stinscmd.Parameters.AddWithValue("MaMH", txbMH.Text);
            stinscmd.Parameters.AddWithValue("MaNH", txbNamH.Text);
            stinscmd.Parameters.AddWithValue("MaHK", txbMaHK.Text);
            stinscmd.Parameters.AddWithValue("DiemTB", txbD_TB.Text);
            LoadData();
            stinscmd.ExecuteNonQuery();
           GetAllDiem();
            
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

        private void txbMaHK_Click(object sender, EventArgs e)
        {

        }

        private void cbbDiemTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txbDiemTL_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("Select_DiemLop", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLop", SqlDbType.Char).Value = txbDiemTL.Text;
            cmd.Parameters.Add("@MaMH", SqlDbType.Char).Value = txbMH.Text;
            cmd.Parameters.Add("@MaHK", SqlDbType.Char).Value = txbMaHK.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;
            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");
            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "TenHS");
            txbNamH.DataBindings.Clear();
            txbNamH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");
            txbMaHK.DataBindings.Clear();
            txbMaHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");
            txbDM_1.DataBindings.Clear();
            txbDM_1.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_1");
            txbDM_2.DataBindings.Clear();
            txbDM_2.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_2");
            txbDM_3.DataBindings.Clear();
            txbDM_3.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_3");
            txbD15_1.DataBindings.Clear();
            txbD15_1.DataBindings.Add("Text", dataGridView1.DataSource, "D15_1");
            txbD15_2.DataBindings.Clear();
            txbD15_2.DataBindings.Add("Text", dataGridView1.DataSource, "D15_2");
            txbD15_3.DataBindings.Clear();
            txbD15_3.DataBindings.Add("Text", dataGridView1.DataSource, "D15_3");
            txbD45_1.DataBindings.Clear();
            txbD45_1.DataBindings.Add("Text", dataGridView1.DataSource, "D45_1");
            txbD45_2.DataBindings.Clear();
            txbD45_2.DataBindings.Add("Text", dataGridView1.DataSource, "D45_2");
            txbDThi.DataBindings.Clear();
            txbDThi.DataBindings.Add("Text", dataGridView1.DataSource, "DThi");
            txbD_TB.DataBindings.Clear();
            txbD_TB.DataBindings.Add("Text", dataGridView1.DataSource, "DiemTB");
        }

        private void mttReload_Click(object sender, EventArgs e)
        {
          //  GetAllDiem();
        }

        private void cbbDiemTMHS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbDiemTMHS_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("Select_DiemHSID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHS", SqlDbType.Char).Value = txbDiemTMHS.Text;
           
            cmd.Parameters.Add("@MaHK", SqlDbType.Char).Value = txbMaHK.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;
            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");
            txbMaHS.DataBindings.Clear();
            txbMaHS.DataBindings.Add("Text", dataGridView1.DataSource, "TenHS");
            txbNamH.DataBindings.Clear();
            txbNamH.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");
            txbMaHK.DataBindings.Clear();           
            txbMaHK.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");
            txbDM_1.DataBindings.Clear();
            txbDM_1.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_1");
            txbDM_2.DataBindings.Clear();
            txbDM_2.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_2");
            txbDM_3.DataBindings.Clear();
            txbDM_3.DataBindings.Add("Text", dataGridView1.DataSource, "DiemM_3");
            txbD15_1.DataBindings.Clear();
            txbD15_1.DataBindings.Add("Text", dataGridView1.DataSource, "D15_1");
            txbD15_2.DataBindings.Clear();
            txbD15_2.DataBindings.Add("Text", dataGridView1.DataSource, "D15_2");
            txbD15_3.DataBindings.Clear();
            txbD15_3.DataBindings.Add("Text", dataGridView1.DataSource, "D15_3");
            txbD45_1.DataBindings.Clear();
            txbD45_1.DataBindings.Add("Text", dataGridView1.DataSource, "D45_1");
            txbD45_2.DataBindings.Clear();
            txbD45_2.DataBindings.Add("Text", dataGridView1.DataSource, "D45_2");
            txbDThi.DataBindings.Clear();
            txbDThi.DataBindings.Add("Text", dataGridView1.DataSource, "DThi");
            txbD_TB.DataBindings.Clear();
            txbD_TB.DataBindings.Add("Text", dataGridView1.DataSource, "DiemTB");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stInsert = "insert into DIEM(DiemM_1,DiemM_2,DiemM_3,D15_1,D15_2,D15_3,D45_1,D45_2,DThi)values(@DiemM_1,@DiemM_2,@DiemM_3,@D15_1,@D15_2,@D15_3,@D45_1,@D45_2,@DThi)";
            SqlCommand stinscmd = new SqlCommand(stInsert, con);
            
            stinscmd.Parameters.AddWithValue("DiemM_1", txbDM_1.Text);
            stinscmd.Parameters.AddWithValue("DiemM_2", txbDM_2.Text);
            stinscmd.Parameters.AddWithValue("DiemM_3", txbDM_3.Text);
            stinscmd.Parameters.AddWithValue("D15_1", txbD15_1.Text);
            stinscmd.Parameters.AddWithValue("D15_2", txbD15_2.Text);
            stinscmd.Parameters.AddWithValue("D15_3", txbD15_3.Text);
            stinscmd.Parameters.AddWithValue("D45_1", txbD45_1.Text);
            stinscmd.Parameters.AddWithValue("D45_2", txbD45_2.Text);
            stinscmd.Parameters.AddWithValue("DThi", txbDThi.Text);
            stinscmd.Parameters.AddWithValue("DiemTB", txbD_TB.Text);
            MessageBox.Show(" Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stinscmd.ExecuteNonQuery();
            GetAllDiem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stUpdate = "update Diem set DiemM_1=@DiemM_1,DiemM_2=@DiemM_2,DiemM_3=@DiemM_3,D15_1=@D15_1,D15_2=@D15_2,D15_3=@D15_3,D45_1=@D45_1,D45_2=@D45_2,DThi=@DThi where MaHS = @MaHS and MaMH=@MaMH and MaNH=@MaNH and MaHK=@MaHK";
            SqlCommand stinscmd = new SqlCommand(stUpdate, con);
            stinscmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stinscmd.Parameters.AddWithValue("MaMH", txbMH.Text);
            stinscmd.Parameters.AddWithValue("MaNH", txbNamH.Text);
            stinscmd.Parameters.AddWithValue("MaHK", txbMaHK.Text);
            stinscmd.Parameters.AddWithValue("DiemM_1", txbDM_1.Text);
            stinscmd.Parameters.AddWithValue("DiemM_2", txbDM_2.Text);
            stinscmd.Parameters.AddWithValue("DiemM_3", txbDM_3.Text);
            stinscmd.Parameters.AddWithValue("D15_1", txbD15_1.Text);
            stinscmd.Parameters.AddWithValue("D15_2", txbD15_2.Text);
            stinscmd.Parameters.AddWithValue("D15_3", txbD15_3.Text);
            stinscmd.Parameters.AddWithValue("D45_1", txbD45_1.Text);
            stinscmd.Parameters.AddWithValue("D45_2", txbD45_2.Text);
            stinscmd.Parameters.AddWithValue("DThi", txbDThi.Text);
            stinscmd.Parameters.AddWithValue("DiemTB", txbD_TB.Text);
            MessageBox.Show(" Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stinscmd.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stDelete = "delete from DIEM where MaHS = @MaHS and MaMH=@MaMH and MaNH=@MaNH and MaHK=@MaHK";
            SqlCommand stdelcmd = new SqlCommand(stDelete, con);
            stdelcmd.Parameters.AddWithValue("MaHS", txbMaHS.Text);
            stdelcmd.Parameters.AddWithValue("MaMH", txbMH.Text);
            stdelcmd.Parameters.AddWithValue("MaNH", txbNamH.Text);
            stdelcmd.Parameters.AddWithValue("MaHK", txbMaHK.Text);
            MessageBox.Show(" Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stdelcmd.ExecuteNonQuery();
            GetAllDiem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAllDiem();
        }
    }
   
}
