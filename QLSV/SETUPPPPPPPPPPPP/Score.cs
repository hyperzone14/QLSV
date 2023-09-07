using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QLSV
{
    internal class Score
    {
        SqlCommand command = new SqlCommand();
        MY_DB mydb = new MY_DB();
        public bool insertScore(int studentId, int courseId, double scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (studentid, courseid, score, description)" + "VALUES (@sid, @cid, @scr,@descr)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool deleteScore(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score Where studentid =@sid AND courseid = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public DataTable studentScoreexist(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE studentid = @sid AND courseid = @cid", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT score.studentid as [Student ID],std.fname as [First Name], std.lname as [Last Name], score.courseid as [Course ID],course.label as [Course Label],score.score as [Score],score.description as [Description] FROM std INNER JOIN score on std.Id = score.studentid INNER JOIN Course on score.courseid = Course.Id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseScores(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT score.studentid as [Student ID], std.fname as [First Name], std.lname as [Last Name], score.courseid as [Course ID], Course.label as [Course Label], score.score as [Score], score.description as [Description] FROM std INNER JOIN score ON std.id=score.studentid INNER JOIN Course ON Course.id=score.courseid WHERE score.courseid=" + courseID);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentScores(int studentID)
        {
            SqlCommand command = new SqlCommand("SELECT score.studentid as [Student ID], std.fname as [First Name], std.lname as [Last Name], score.courseid as [Course ID], Course.label as [Course Label], score.score as [Score], score.description as [Description] FROM std INNER JOIN score ON std.id=score.studentid INNER JOIN Course ON Course.id=score.courseid WHERE score.studentid=" + studentID);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public double getAverageScoreByCourse(string course)
        {
            SqlCommand command = new SqlCommand("Select AverageGrade FROM (Select Course.[label], AVG(score.score) as AverageGrade From Course, score where Course.id = score.courseid GROUP BY Course.label) as GRADE WHERE GRADE.label ='" + course + "'");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToDouble(table.Rows[0]["AverageGrade"]);
        }
        public DataTable getAverageScoreByCourse()
        {
            command = new SqlCommand("SELECT [label] AS [Course Name] ,AVG(score) AS [Average Score By Course] , Count(studentid) AS [The Number Student Of Course] FROM score JOIN Course ON score.courseid = Course.id GROUP BY [label]");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int getStudentPass()
        {
            mydb.openConnection();
            command = new SqlCommand("SELECT COUNT([Student ID]) FROM (SELECT studentid AS [Student ID], AVG(score) AS [Average Score By Student] FROM Score GROUP BY studentid) AS TBSV WHERE [Average Score By Student]>=5", mydb.getConnection);
            int pass = (int)command.ExecuteScalar();
            mydb.closeConnection();
            return pass;
        }
        public int getStudentFail()
        {
            mydb.openConnection();
            command = new SqlCommand("SELECT COUNT([Student ID]) FROM (SELECT studentid AS [Student ID], AVG(score) AS [Average Score By Student] FROM Score GROUP BY studentid) AS TBSV WHERE [Average Score By Student]<5", mydb.getConnection);
            int fail = (int)command.ExecuteScalar();
            mydb.closeConnection();
            return fail;
        }
        public int getRatingStudent(int below, int greaterEqual)
        {
            mydb.openConnection();
            command = new SqlCommand("SELECT COUNT([Student ID]) FROM (SELECT studentid AS [Student ID], AVG(score) AS [Average Score By Student] FROM score GROUP BY studentid) AS TBSV WHERE [Average Score By Student] <" + below + " and [Average Score By Student] >=" + greaterEqual, mydb.getConnection);
            int rate = (int)command.ExecuteScalar();
            mydb.closeConnection();
            return rate;
        }

    }
}
