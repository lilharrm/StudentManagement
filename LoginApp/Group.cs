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
    public class Group
    {
        protected string Group_id;
        protected string Group_Name;
        protected SqlConnection conn;
        public Group() { }
        public Group(string id, string name)
        {
            Group_id = id;
            Group_Name = name;
            
        }
        public string GetGroupId()
        {
            return Group_id;
        }
        public string GetGroupName()
        {
            return Group_Name;
        }
    }
}
