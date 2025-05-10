using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementApp.Control;

namespace StudentManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // I'm using panels instead of forms, to be able to develop a super responsive/modern application
        private void loadControl(UserControl control)
        {
            MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(control);
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            loadControl(new ManageStudentsControl());
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(mainTableLayout);
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            loadControl(new ManageSubjectControl());
        }

        private void btnRecordGrade_Click(object sender, EventArgs e)
        {
            loadControl(new RecordGradeControl());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadControl(new ViewAcademicStatusControl());
        }

    }
}
