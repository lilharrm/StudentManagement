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
        protected DateTime BirthDate;


        public Person(string name, string surname, DateTime birthDate)
        {

            if (name != "")
                Name = name;
            else
                throw new Exception("Name is required");

            if (surname != "")
                Surname = surname;
            else
                throw new Exception("Surname is required");

            if (birthDate <= DateTime.Now)
                BirthDate = birthDate;
            else
                throw new Exception("Birthdate must be in the past");

            if (GetTestAge(birthDate) >= 14)
                BirthDate = birthDate;
            else
                throw new Exception("Must be 14 years old or older");

        }


        public int GetAge()
        {
            return (int)((DateTime.Now - BirthDate).TotalDays / 365.25);
        }

        public int GetTestAge(DateTime date)
        {
            return (int)((DateTime.Now - BirthDate).TotalDays / 365.25);
        }

        public int DaysBefore()
        {
            
            DateTime today = DateTime.Today;
            DateTime next = BirthDate.AddYears(today.Year - BirthDate.Year);
            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;
            return numDays;
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
