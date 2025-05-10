using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentManagementApp.Data;
using StudentManagementApp.Repositories;

namespace StudentManagementApp.Control
{
    public partial class ViewAcademicStatusControl : UserControl
    {
        public ViewAcademicStatusControl()
        {
            InitializeComponent();
        }

        DBConnection connection = new DBConnection();
        StudentRepository studentRepository = new StudentRepository();
        SubjectRepository subjectRepository = new SubjectRepository();
        AcademicRepository academicRepository = new AcademicRepository();


        private void LoadComboBoxes()
        {
            DataTable students = studentRepository.GetStudents();
            cbSelectStudent.DataSource = students;
            students.Columns.Add("FullName", typeof(string), "stdFirstName + ' ' + stdLastName");
            cbSelectStudent.DisplayMember = "FullName";
            cbSelectStudent.ValueMember = "StudentId";
            cbSelectStudent.SelectedIndex = -1;

            DataTable subject = subjectRepository.GetSubjects();
            cbSelectSubject.DataSource = subject;
            cbSelectSubject.DisplayMember = "subName";
            cbSelectSubject.ValueMember = "subjectId";
            cbSelectSubject.SelectedIndex = -1;

            if (students.Rows.Count == 0)
            {
                MessageBox.Show("No students found.");
            }
            if (subject.Rows.Count == 0)
            {
                MessageBox.Show("No subjects found.");
            }

        }


        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            int? studentId = cbSelectStudent.SelectedValue as int?;
            int? subjectId = cbSelectSubject.SelectedValue as int?;


            string query = @"SELECT 
                        g.gradeId, 
                        s.stdFirstName AS 'Student', 
                        sub.subName AS 'Subject', 
                        g.gradeValue AS 'Grade', 
                        g.gradingDate AS 'Date'
                    FROM grade g
                    JOIN student s ON g.studentId = s.studentId
                    JOIN subject sub ON g.subjectId = sub.subjectId
                    WHERE 1=1";


            if (cbSelectStudent.SelectedIndex != -1)
                query += $" AND g.studentId = {studentId}";

            if (cbSelectSubject.SelectedIndex != -1)
                query += $" AND g.subjectId = {subjectId}";


            MySqlCommand cmd = new MySqlCommand(query, connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (!table.Columns.Contains("Result"))
                table.Columns.Add("Result", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                double voto = Convert.ToDouble(row["Grade"]);
                row["Result"] = voto >= 18 ? "PASS" : "FAIL";
            }

            dgvShowStatus.DataSource = table;


            if (table.Rows.Count > 0)
            {
                double avg = table.AsEnumerable().Average(row => Convert.ToDouble(row["Grade"]));
                lblAverageGrade.Text = $"Average grade: {avg:F2}";

                string status;
                if (avg >= 28 && avg <= 30)
                    status = "Very good";
                else if (avg >= 24)
                    status = "Good";
                else if (avg >= 20)
                    status = "Not good";
                else if (avg >= 18)
                    status = "You should study more!";
                else
                    status = "Not promoted";

                lblAcademicStatus.Text = status;
                lblAcademicStatus.Visible = true;
            }
            else
            {
                lblAverageGrade.Text = "No data found.";
            }
        }

        private void ViewAcademicStatusControl_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            cbSelectStudent.Text = "";
            cbSelectSubject.Text = "";
        }

        private void btnExportToCsv_Click(object sender, EventArgs e)
        {
            if (dgvShowStatus.Rows.Count == 0)
            {
                MessageBox.Show("No Data To Export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV file (*.csv)|*.csv";
            saveFile.FileName = "gradebook.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    var headers = dgvShowStatus.Columns.Cast<DataGridViewColumn>();
                    sw.WriteLine(string.Join(",", headers.Select(col => col.HeaderText)));

                    foreach (DataGridViewRow row in dgvShowStatus.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sw.WriteLine(string.Join(",", cells.Select(cell => cell.Value?.ToString()?.Replace(",", " ") ?? "")));
                    }
                }
            }
            MessageBox.Show("Successfully exported data into CSV file", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvShowStatus.DataSource = academicRepository.getAllData();
            dgvShowStatus.ClearSelection();

            if (dgvShowStatus.Rows.Count == 0)
            {
                MessageBox.Show("No Data To Export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbSelectStudent.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbSelectSubject.SelectedIndex = -1;
        }
    }
}
