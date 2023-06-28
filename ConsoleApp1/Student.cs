using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        int id;
        string name;
        string surname;
        public double gpa;

        public Student() { }

        public Student(int id, string name, string surname, double gpa)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;

        }

        public string getStudentData()
        {
            return $"ID: {id}, Full Name: {name + " " + surname}, GPA = {gpa}";
        }
    }
}
