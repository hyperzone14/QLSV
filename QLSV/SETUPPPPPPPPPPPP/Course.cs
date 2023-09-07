using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Course
    {
        MY_DB mydb = new MY_DB();
        public bool checkCourseName(string courseName, int courseID = 0)
        {
            // id <> @cID de phan biet xem co ton tai khong, chi la parameter
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cname AND id <> @cID", mydb.getConnection);
            command.Parameters.Add("@cname",SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool insertCourse(int courseid, string coursename, int courseperiod, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, period, description)" +
                " VALUES (@cid, @cname, @cperiod, @cdescription)", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = coursename;
            command.Parameters.Add("@cperiod", SqlDbType.Int).Value = courseperiod;
            command.Parameters.Add("@cdescription", SqlDbType.Text).Value = description;
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
        public bool updateCourse(int courseid, string coursename, int courseperiod, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET label=@cname, period=@cperiod, description=@cdescription WHERE id=@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = coursename;
            command.Parameters.Add("@cperiod", SqlDbType.Int).Value = courseperiod;
            command.Parameters.Add("@cdescription", SqlDbType.Text).Value = description;
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
        public bool deleteCourse(int courseid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id =@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;
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
        public DataTable getCourses(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getCourseByID(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id =@courseId", mydb.getConnection);
            command.Parameters.Add("@courseId", SqlDbType.NVarChar).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public double totalCourses()
        {
            Course course = new Course();
            double total = 0;
            SqlCommand command = new SqlCommand("select * from Course");
            DataTable table = course.getCourses(command);
            total = table.Rows.Count;
            mydb.openConnection();
            return total;
        }
        public DataTable getStudentByCourse(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT std.id AS [Student ID],std.fname AS [First Name], std.lname AS [Last Name], Course.[description] AS [Description] FROM std	INNER JOIN score ON std.id=Score.studentid INNER JOIN course ON Course.id=score.courseid WHERE score.courseid =" + courseID, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
