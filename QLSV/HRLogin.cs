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
    public class HRLogin
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool checkEmail(string mail)
        {
            command = new SqlCommand("SELECT email FROM hr WHERE email =@mail", mydb.getConnection);
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
        public bool insertHR(string fname, string lname, string user, string pass, string email, MemoryStream picture)
        {
            command = new SqlCommand("INSERT INTO hr (f_name,l_name,username,password,email,fimage)" +
                " VALUES (@fname,@lname,@user,@pass,@mail,@pic)", mydb.getConnection);
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
        public bool updateHR(string fname, string lname, string user, string pass, string email, MemoryStream picture)
        {
            command = new SqlCommand("UPDATE hr SET f_name = @fname,l_name=@lname,password=@pass,email=@mail,fimage=@pic WHERE username =@user", mydb.getConnection);
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
            command = new SqlCommand("DELETE FROM hr WHERE username =@user AND password=@pass", mydb.getConnection);
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
        public DataTable getHRByID(Int32 userid)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from hr where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string sql = "";

            if (operation == "register")
            {
                sql = "select * from hr WHERE username = @user";
            }
            else if (operation == "eidt")
            {
                sql = "select * from hr WHERE username = @user and id <>@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            }
            command = new SqlCommand(sql, mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NChar).Value = username;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
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
    }
}
