using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StudentManagementApp.Models;

namespace StudentManagementApp.Repositories
{
    internal class StudentRepository
    {
        //Initializing a DB connection
        DBConnection connection = new DBConnection();

        //---------------------- CREATE ----------------------

        public bool InsertStudent(Student student)
        {
            // Query for DB (create)
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `student` (`StdFirstName`, `StdLastName`, `StdEmail`, `StdAcademicGroup`) VALUES (@fn, @ln, @em, @ag)", connection.getConnection());

            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = student.firstName; // Used to put values into the prepared statement
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = student.lastName;
            cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = student.email;
            cmd.Parameters.Add("@ag", MySqlDbType.VarChar).Value = student.academicGroup;

            // Open a DB connection
            connection.openConnection();
            if (cmd.ExecuteNonQuery() == 1) // return true if a row has been effected
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


        //---------------------- READ ----------------------

        public DataTable GetStudent()
        {
            //Query for (Read)
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `student`", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //---------------------- DELETE ----------------------

        // DELETE A STUDENT BY ID
        public bool DeleteStudent(int id)
        {
            //Query for (delete)
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `student` WHERE `StudentId` = @id", connection.getConnection());
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

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


        //---------------------- UPDATE ----------------------

        public bool UpdateStudents(Student student)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `student` SET `StdFirstName` = @fn, `StdLastName` = @ln, `StdEmail` = @em, `StdAcademicGroup` = @ag WHERE `StudentId` = @id", connection.getConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = student.studentId;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = student.firstName;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = student.lastName;
            cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = student.email;
            cmd.Parameters.Add("@ag", MySqlDbType.VarChar).Value = student.academicGroup;


            connection.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {   //Success
                connection.closeConnection();
                return true;
            }
            else
            {   //Failure
                connection.closeConnection();
                return false;
            }
        }

        public DataTable GetStudents()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT StudentId, StdFirstName, StdLastName FROM `student`", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool EmailExists(string email)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `student` WHERE TRIM(LOWER(stdEmail)) = @stdEmail;", connection.getConnection());
            cmd.Parameters.Add("@stdEmail", MySqlDbType.VarChar).Value = email.Trim().ToLower();

            connection.openConnection();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.closeConnection();
            return count > 0;
        }
    }
}
