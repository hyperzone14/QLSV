using System;
using System.Data;
using System.Data.SqlClient;

namespace QLSV
{
    public class Group
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool insertGroup(string name, int userid)
        {
            command = new SqlCommand("INSERT INTO MyGroup (name,userid) VALUES (@name,@user)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@user", SqlDbType.Int).Value = userid;
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
        public bool updateGroup(string name, int groupid)
        {
            command = new SqlCommand("UPDATE MyGroup SET name=@name WHERE id =@id", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
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
        public bool deleteGroup(int groupID)
        {
            command = new SqlCommand("DELETE FROM MyGroup WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupID;
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
        public DataTable getGroup(int userid)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from MyGroup WHERE userid =@user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool groupNameExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string sql = "";

            if (operation == "add")
            {
                sql = "select * from MyGroup WHERE name = @name and userid = @userid";
            }
            else if (operation == "edit")
            {
                sql = "select * from MyGroup WHERE name = @name and userid = @userid and id <> @id";

            }
            command = new SqlCommand(sql, mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
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
        public int totalGroup(int userid)
        {
            Group group = new Group();
            DataTable table = group.getGroup(userid);
            int total = table.Rows.Count;
            mydb.openConnection();
            return total;
        }
    }
}
