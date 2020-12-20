using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApp;
using System.Drawing;
using System.Security.Policy;
using System.Data.SqlClient;

namespace LoginApp
{
    public class Grade
    {
        private string Id;
        private string Grades;
        private string Student_id;
        private string Subject_id;
        private string Teacher_id;

        public Grade() { }
        public Grade(string id, string grades, string studentid, string subjectid, string teacherid)
        {
            Id = id;
            Grades = grades;
            Student_id = studentid;
            Subject_id = subjectid;
            Teacher_id = teacherid;
        }

        public string GetId()
        {
            return Id;
        }
        public string GetGrades()
        {
            return Grades;
        }
        public string GetStudentId()
        {
            return Student_id;
        }
        public string GetSubjectId()
        {
            return Subject_id;
        }
        public string GetTeacherId()
        {
            return Teacher_id;
        }

    }
}
