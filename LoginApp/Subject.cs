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
    public class Subject
    {
        private string Id;
        private string Name;
        private string Group_id;
        private string Teacher_id;
        public Subject() { }
        public Subject(string id, string name, string groupid, string teacherid)
        {
            Id = id;
            Name = name;
            Group_id = groupid;
            Teacher_id = teacherid;
        }

        public string GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetGroupId()
        {
            return Group_id;
        }
        public string GetTeacherId()
        {
            return Teacher_id;
        }
    }
}
