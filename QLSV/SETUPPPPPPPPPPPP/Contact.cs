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
    public class Contact
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool insertContact(string fname, string lname, int group_id, string phone, string email, string address, MemoryStream picture, int userid)
        {
            command = new SqlCommand("INSERT INTO MyContact (fname,lname,group_id,phone,email,address,pic,userid) VALUES (@fname,@lname,@group_id,@phone,@email,@address,@picture,@userid)", mydb.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;

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
        public bool updateContact(int contactid, string fname, string lname, int group_id, string phone, string email, string address, MemoryStream picture)
        {
            command = new SqlCommand("UPDATE MyContact SET fname =@fname,lname=@lname,group_id=@group_id,phone=@phone,email=@email,address=@address,pic=@picture WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
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
        public bool deleteContact(int ContactID)
        {
            command = new SqlCommand("DELETE FROM MyContact WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ContactID;
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
        public DataTable getContactByID(int contactID)
        {
            command = new SqlCommand("SELECT id AS [Contact ID], CONCAT(fname,' ',lname) AS [Full Name], group_id AS [Group ID], phone AS [Phone], email AS [Email], pic AS [Image], userid AS [User ID] FROM MyContact WHERE id=@id");
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactID;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool MailGroupExist(int group_id, string email, string operation, int Contactid = 0)
        {
            string sql = "";

            if (operation == "add")
            {
                sql = "select * from MyContact WHERE group_id=@group_id and email=@email";
            }
            else if (operation == "edit")
            {
                sql = "select * from MyContact WHERE group_id=@group_id and email=@email and id <> @id";

            }
            command = new SqlCommand(sql, mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Contactid;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
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
        public DataTable selectContactList(string cmd)
        {
            command = new SqlCommand(cmd, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable selectContact(string cmd, int userid)
        {
            command = new SqlCommand(cmd, mydb.getConnection);
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
