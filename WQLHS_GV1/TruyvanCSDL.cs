using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WQLHS_GV1
{
    class TruyvanCSDL
    {
        public static DataTable filldb(String name, params object[] po)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-M2KIF2A\KIM; Initial Catalog = QLHS_GV1; Integrated Security = True");
            if (con.State == ConnectionState.Closed) con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(name, con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(sda.SelectCommand);
            if (sda.SelectCommand.Parameters.Count - 1 != po.Length)
            {
                return null;
            }
            int i = 0;
            foreach (SqlParameter p in sda.SelectCommand.Parameters)
            {
                if (p.Direction == ParameterDirection.Input || p.Direction == ParameterDirection.InputOutput)
                {
                    p.Value = po[i++];
                }
            }
            sda.Fill(dt);
            if (con.State == ConnectionState.Open) con.Close();
            return dt;
        }
    }
}
    

