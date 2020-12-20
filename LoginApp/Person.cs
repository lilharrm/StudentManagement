using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using LoginApp;

namespace ConsoleApp1
{
    public class Person
    {
        protected string Name;
        protected string Surname;


        public Person(string name, string surname)
        {

            if (name != "")
                Name = name;
            else
                throw new Exception("Name is required");

            if (surname != "")
                Surname = surname;
            else
                throw new Exception("Surname is required");
        }


        public string GetName()
        {
            return Name;
        }

        public string GetSurname()
        {
            return Surname;
        }


    }

}
