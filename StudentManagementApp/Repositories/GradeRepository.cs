using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using StudentManagementApp.Models;

namespace StudentManagementApp.Repositories
{
    internal class GradeRepository
    {
        public GradeRepository() { }

        DBConnection connection = new DBConnection();

        public bool InsertGrade(Grade grade)
        {
            int studentId = grade.StudentId;
            int subjectId = grade.SubjectId;

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `grade` (`studentId`, `subjectId`, `gradeValue`, `gradingDate`) VALUES (@stuId, @subId, @grVal, @grDate)", connection.getConnection());
            cmd.Parameters.Add("@stuId", MySqlDbType.Int32).Value = studentId;
            cmd.Parameters.Add("@subId", MySqlDbType.Int32).Value = subjectId;
            cmd.Parameters.Add("@grVal", MySqlDbType.Int32).Value = grade.GradeValue;
            cmd.Parameters.Add("@grDate", MySqlDbType.DateTime).Value = grade.GradingDate;

            connection.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }


        public DataTable GetGrades()
        {
            MySqlCommand cmd = new MySqlCommand(
                @"
        SELECT 
            g.gradeId,
            s.stdFirstName AS StudentName,
            sub.subName AS SubjectName,
            g.gradeValue,
            g.gradingDate
        FROM grade g
        JOIN student s ON g.studentId = s.studentId
        JOIN subject sub ON g.subjectId = sub.subjectId
    ", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool DeleteGradeById(int gradeId)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `grade` WHERE `gradeId` = @gradeId", connection.getConnection());
            cmd.Parameters.Add("@gradeId", MySqlDbType.Int32).Value = gradeId;

            connection.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        public bool UpdateGrade(Grade grade)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `grade` SET `studentId` = @studentId, `subjectId` = @subjectId, `gradeValue` = @gradeValue, `gradingDate` = @gradingDate WHERE `gradeId` = @gradeId",
        connection.getConnection());
            cmd.Parameters.Add("@studentId", MySqlDbType.Int32).Value = grade.StudentId;
            cmd.Parameters.Add("@subjectId", MySqlDbType.Int32).Value = grade.SubjectId;
            cmd.Parameters.Add("@gradeValue", MySqlDbType.Int32).Value = grade.GradeValue;
            cmd.Parameters.Add("@gradingDate", MySqlDbType.DateTime).Value = grade.GradingDate;
            cmd.Parameters.Add("@gradeId", MySqlDbType.Int32).Value = grade.GradeId;

            connection.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        public DataTable GetSubjects()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT subjectId, subName, SubAcronym FROM `subject`", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }



    }


}
