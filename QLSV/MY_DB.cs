using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLSV
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0CLMOJLH;Initial Catalog=QLSV;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if((con.State == ConnectionState.Closed))
            {
                con.Close();
            }
        }
    }
}
