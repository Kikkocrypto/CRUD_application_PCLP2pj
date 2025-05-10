using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementApp.Models;
using StudentManagementApp.Repositories;
using StudentManagementApp.Utils;

namespace StudentManagementApp
{
    public partial class ManageStudentsControl : UserControl
    {
        StudentRepository repository = new StudentRepository();
        InputValidation validation = new InputValidation();

        public ManageStudentsControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //ADD A STUDENT
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string academicGroup = tbAcademicGroup.Text;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(academicGroup)
                )
            {
                MessageBox.Show("Please fill in all fields. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validation.IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid Email! ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (repository.EmailExists(email))
            {
                MessageBox.Show("Duplicate email addresses.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validation.IsAlphabetic(firstName)  // I used methods for input validation, in this case, the input should get only letters
                || !validation.IsAlphabetic(lastName))
            {
                MessageBox.Show("Please use only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validation.IsLessThanFiftyChar(firstName) // I used methods for input validation, in this case, the input should be more than 2 and less than 50 char
                || !validation.IsLessThanFiftyChar(lastName)
                || !validation.IsLessThanTenChar(academicGroup)) // Less than 10 char
            {
                MessageBox.Show("Insert the right input.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // This is for student obj creation and for DB insert
            Student student = new Student()
            {
                firstName = firstName,
                lastName = lastName,
                email = email,
                academicGroup = academicGroup
            };
            bool result = repository.InsertStudent(student);


            // Refresh Data Grid View after insert
            if (result)
            {
                showTable();
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            else
            {
                MessageBox.Show("Error while adding student ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void loadTable(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            dgvStudents.DataSource = repository.GetStudent();
            dgvStudents.ClearSelection();

        }


        private void clearFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbAcademicGroup.Text = "";
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDelete.Visible = true;
                btnModify.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value);
                bool success = repository.DeleteStudent(studentId);
                if (success)
                {
                    MessageBox.Show("Student successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                    hideButtons();
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hideButtons()
        {
            btnDelete.Visible = false;
            btnModify.Visible = false;
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            //If the CurrentRow is not null and it isn't empty and it contains data, it will execute.
            if (dgvStudents.CurrentRow != null && dgvStudents.CurrentRow.Index >= 0 && !dgvStudents.CurrentRow.IsNewRow)
            {
                //With this, I'm able to extract data from the DataGridView
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value);
                string firstName = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                string lastName = dgvStudents.CurrentRow.Cells[2].Value.ToString();
                string email = dgvStudents.CurrentRow.Cells[3].Value.ToString();
                string academicGroup = dgvStudents.CurrentRow.Cells[4].Value.ToString();

                //Charge selected data into textBox, ready to being modified
                tbFirstName.Text = firstName;
                tbLastName.Text = lastName;
                tbEmail.Text = email;
                tbAcademicGroup.Text = academicGroup;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //MODIFY A STUDENT
            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value);
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string academicGroup = tbAcademicGroup.Text;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(academicGroup))
            {
                MessageBox.Show("Please fill in all fields. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid Email address. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student student = new Student()
            {
                studentId = id,
                firstName = firstName,
                lastName = lastName,
                email = email,
                academicGroup = academicGroup
            };
            bool result = repository.UpdateStudents(student);



            if (result)
            {
                showTable();
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            else
            {
                MessageBox.Show("Error while updating the student ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStudents.ClearSelection();
            clearFields();
        }
    }
}
