using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementApp.Data;
using StudentManagementApp.Models;
using StudentManagementApp.Utils;

namespace StudentManagementApp.Control
{
    public partial class ManageSubjectControl : UserControl
    {
        private SubjectRepository repository = new SubjectRepository();
        InputValidation validation = new InputValidation();

        public ManageSubjectControl()
        {
            InitializeComponent();
            showTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subName = tbSubjectName.Text;
            string subAcronym = tbSubjectAcronym.Text;
            string subEvaluationType = cbEvaluationType.Text;

            if (string.IsNullOrWhiteSpace(subName) ||
                string.IsNullOrWhiteSpace(subAcronym))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validation.IsLessThanFiftyChar(subName) // I used methods for input validation, in this case, the input should be more than 2 and less than 50 char
                || !validation.IsLessThanTenChar(subAcronym)) // Less than 10 char
            {
                MessageBox.Show("Insert the right input.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbEvaluationType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an evaluation type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validation.IsAlphabetic(subName))  // I used methods for input validation, in this case, the input should get only letters)
            {
                MessageBox.Show("Please use only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Subject subject = new Subject()
            {
                SubName = subName,
                SubAcronym = subAcronym,
                SubEvaluationType = subEvaluationType
            };

            bool result = repository.InsertSubject(subject);

            if (result)
            {
                showTable();
                MessageBox.Show("Subject added successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while adding student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow != null)
            {
                int subjectId = Convert.ToInt32(dgvSubjects.CurrentRow.Cells[0].Value);
                bool success = repository.DeleteSubjectById(subjectId);

                if (success)
                {
                    MessageBox.Show("Subject successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                    hideButtons();
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDelete.Visible = true;
                btnModify.Visible = true;
            }
        }

        private void hideButtons()
        {
            btnDelete.Visible = false;
            btnModify.Visible = false;
        }

        private void dgvSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow != null && dgvSubjects.CurrentRow.Index >= 0 && !dgvSubjects.CurrentRow.IsNewRow)
            {

                int id = Convert.ToInt32(dgvSubjects.CurrentRow.Cells[0].Value);
                string subName = dgvSubjects.CurrentRow.Cells[1].Value.ToString();
                string subAcronym = dgvSubjects.CurrentRow.Cells[2].Value.ToString();
                string subEvaluationType = dgvSubjects.CurrentRow.Cells[3].Value.ToString();

                tbSubjectName.Text = subName;
                tbSubjectAcronym.Text = subAcronym;
                cbEvaluationType.Text = subEvaluationType;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSubjects.CurrentRow.Cells[0].Value);
            string subName = tbSubjectName.Text;
            string subAcronym = tbSubjectAcronym.Text;
            string subEvaluationType = cbEvaluationType.Text;

            if (string.IsNullOrWhiteSpace(subName) ||
                string.IsNullOrEmpty(subAcronym) ||
                string.IsNullOrWhiteSpace(subEvaluationType)
                )
            {
                MessageBox.Show("Please fill in all fields. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Subject subject = new Subject()
            {
                SubjectId = id,
                SubName = subName,
                SubAcronym = subAcronym,
                SubEvaluationType = subEvaluationType
            };
            bool result = repository.UpdateSubject(subject);

            if (result)
            {
                showTable();
                MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            else
            {
                MessageBox.Show("Error while updating the subject ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showTable()
        {
            dgvSubjects.DataSource = repository.GetSubjects();
        }
        public void clearFields()
        {
            tbSubjectName.Text = "";
            tbSubjectAcronym.Text = "";
            cbEvaluationType.Text = "";
        }

        private void dgvSubjects_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSubjects.ClearSelection();
            clearFields();
        }
    }
}
