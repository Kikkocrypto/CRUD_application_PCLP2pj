using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentManagementApp.Repositories
{
    internal class AcademicRepository
    {
        DBConnection connection = new DBConnection();


        public DataTable getAllData()
        {
            MySqlCommand cmd = new MySqlCommand(@"SELECT 
                        g.gradeId, 
                        s.stdFirstName AS 'Student', 
                        sub.subName AS 'Subject', 
                        g.gradeValue AS 'Grade', 
                        g.gradingDate AS 'Date'
                    FROM grade g
                    JOIN student s ON g.studentId = s.studentId
                    JOIN subject sub ON g.subjectId = sub.subjectId
                    WHERE 1=1", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
