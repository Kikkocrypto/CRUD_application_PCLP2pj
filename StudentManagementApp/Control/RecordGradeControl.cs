using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementApp.Data;
using StudentManagementApp.Models;
using StudentManagementApp.Repositories;
using StudentManagementApp.Utils;

namespace StudentManagementApp.Control
{
    public partial class RecordGradeControl : UserControl
    {

        StudentRepository studentRepo = new StudentRepository();
        SubjectRepository subjectRepository = new SubjectRepository();
        GradeRepository gradeRepository = new GradeRepository();
        InputValidation validation = new InputValidation();
        public RecordGradeControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }


        // Used to Load the students/subjcets into their combo box
        private void RecordGradeControl_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            ShowTable();
        }

        public void ShowTable()
        {
            dgvGrade.DataSource = gradeRepository.GetGrades();
        }

        private void LoadComboBoxes()
        {
            DataTable students = studentRepo.GetStudents();
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



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gradeInput = tbAssignGrade.Text;

            if (cbSelectStudent.SelectedIndex == -1 || cbSelectSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Both student and subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validation.IsNullOrEmpty(gradeInput))
            {
                MessageBox.Show("Please enter a grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validation.IsNumeric(gradeInput))
            {
                MessageBox.Show("Please enter a valid numeric grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int studentId = Convert.ToInt32(cbSelectStudent.SelectedValue);
            int subjectId = Convert.ToInt32(cbSelectSubject.SelectedValue);
            int gradeValue = Convert.ToInt32(gradeInput);

            if (!validation.isValidGrade(gradeValue))
            {
                MessageBox.Show("Please enter a valid grade ( <= 30)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Grade ObjGrade = new Grade()
            {
                StudentId = studentId,
                SubjectId = subjectId,
                GradeValue = gradeValue,
                GradingDate = DateTime.Now
            };

            bool result = gradeRepository.InsertGrade(ObjGrade);

            if (result)
            {
                MessageBox.Show("Grade has been successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTable();
                ClearFields();
            }
            else
            {
                MessageBox.Show("An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dgvGrade_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrade.CurrentRow != null && dgvGrade.CurrentRow.Index >= 0 && !dgvGrade.CurrentRow.IsNewRow)
            {
                int gradeId = Convert.ToInt32(dgvGrade.CurrentRow.Cells[0].Value);
                string studentName = dgvGrade.CurrentRow.Cells[1].Value.ToString();
                string subjectName = dgvGrade.CurrentRow.Cells[2].Value.ToString();
                int gradeValue = Convert.ToInt32(dgvGrade.CurrentRow.Cells[3].Value);

                cbSelectStudent.Text = studentName;
                cbSelectSubject.Text = subjectName;
                tbAssignGrade.Text = gradeValue.ToString();


            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Getting each user input
            int gradeId = Convert.ToInt32(dgvGrade.CurrentRow.Cells[0].Value);
            int studentId = Convert.ToInt32(cbSelectStudent.SelectedValue);
            int subjectId = Convert.ToInt32(cbSelectSubject.SelectedValue);

            // Verifying that the grade and the IDs are not null
            int gradeValue;
            if (!int.TryParse(tbAssignGrade.Text, out gradeValue))
            {
                MessageBox.Show("Please enter a valid numeric grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentId == -1 || subjectId == -1 || gradeValue == 0)
            {
                MessageBox.Show("Please select a student, a subject and enter a valid grade.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // I'm Creating a new Object based on the user input
            Grade grade = new Grade()
            {
                GradeId = gradeId,
                StudentId = studentId,
                SubjectId = subjectId,
                GradeValue = gradeValue,
                GradingDate = DateTime.Now
            };

            bool result = gradeRepository.UpdateGrade(grade); // Insert operation with the grade's repository

            if (result)
            {
                ShowTable();
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error while updating the student ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BTN for grade delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrade.CurrentRow != null)
            {
                int gradeId = Convert.ToInt32(dgvGrade.CurrentRow.Cells[0].Value);
                bool success = gradeRepository.DeleteGradeById(gradeId);

                if (success)
                {
                    MessageBox.Show("Grade successfully deleted!", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTable();
                    ClearFields();
                    HideButtons();
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearFields()
        {
            tbAssignGrade.Text = "";
            cbSelectStudent.Text = "";
            cbSelectSubject.Text = "";
        }

        private void dgvGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModify.Visible = true;
            btnDelete.Visible = true;
        }
        //Hiding delete/modify buttons after the delete
        public void HideButtons()
        {
            btnDelete.Visible = false;
            btnModify.Visible = false;
        }
    }
}
