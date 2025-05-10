using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Models
{
    internal class Grade
    {
        public int GradeId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal GradeValue { get; set; }
        public DateTime GradingDate { get; set; }

        public Grade(int studentId, int subjectId, decimal gradeValue, DateTime gradingDate)
        {
            StudentId = studentId;
            SubjectId = subjectId;
            GradeValue = gradeValue;
            GradingDate = gradingDate;
        }

        public Grade() { }
    }
}
