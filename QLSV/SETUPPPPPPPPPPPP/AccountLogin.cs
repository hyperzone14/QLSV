using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class AccountLogin
    {
        MY_DB mydb = new MY_DB();
        public bool checkEmail(string mail)
        {
            SqlCommand command = new SqlCommand("SELECT email FROM login WHERE email =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.NChar).Value = mail;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkUsername(string user)
        {
            SqlCommand command = new SqlCommand("SELECT username FROM login WHERE username =@user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool insertAccount(string fname, string lname, string user, string pass, string email, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username,password,email,f_name,l_name,fimage)" +
                " VALUES (@user,@pass,@mail,@fname,@lname,@pic)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@fname", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NChar).Value = lname;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteAccount(string user, string pass)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Login WHERE username =@user AND password=@pass", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getAccounts(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
