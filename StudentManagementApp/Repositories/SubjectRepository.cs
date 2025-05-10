
using System.Data;
using MySql.Data.MySqlClient;
using StudentManagementApp.Models;
using StudentManagementApp.Data;

namespace StudentManagementApp.Data
{
    internal class SubjectRepository
    {
        private readonly DBConnection connection = new DBConnection();

        //---------------------- CREATE ----------------------
        public bool InsertSubject(Subject subject)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `subject` (`subName`, `subAcronym`, `subEvaluationType`) VALUES (@sn, @sa, @set)", connection.getConnection());
            cmd.Parameters.AddWithValue("@sn", subject.SubName);
            cmd.Parameters.AddWithValue("@sa", subject.SubAcronym);
            cmd.Parameters.AddWithValue("@set", subject.SubEvaluationType);

            connection.openConnection();
            bool success = cmd.ExecuteNonQuery() == 1;
            connection.closeConnection();
            return success;
        }

        //---------------------- READ ----------------------
        public DataTable GetSubjects()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `subject`", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //---------------------- DELETE ----------------------
        public bool DeleteSubjectById(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `subject` WHERE `subjectId` = @id", connection.getConnection());
            cmd.Parameters.AddWithValue("@id", id);

            connection.openConnection();
            bool success = cmd.ExecuteNonQuery() == 1;
            connection.closeConnection();
            return success;
        }

        //---------------------- UPDATE ----------------------
        public bool UpdateSubject(Subject subject)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `subject` SET `subName` = @sn, `subAcronym` = @sa, `subEvaluationType` = @set WHERE `subjectId` = @id", connection.getConnection());
            cmd.Parameters.AddWithValue("@id", subject.SubjectId);
            cmd.Parameters.AddWithValue("@sn", subject.SubName);
            cmd.Parameters.AddWithValue("@sa", subject.SubAcronym);
            cmd.Parameters.AddWithValue("@set", subject.SubEvaluationType);

            connection.openConnection();
            bool success = cmd.ExecuteNonQuery() == 1;
            connection.closeConnection();
            return success;
        }
    }
}
