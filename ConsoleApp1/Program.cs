using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Iphone = new Phone("Iphone", "14 Pro", 550000);
            Console.WriteLine(Iphone.getData());

            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                double gpa = Convert.ToDouble(Console.ReadLine());

                students[i] = new Student(id, name, surname, gpa);
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.getStudentData());
            }

            static Student topStudent(Student[] students)
            {
                double count = 0;
                Student topStudent = new Student();
                foreach (Student student in students)
                {
                    if (student.gpa > count)
                    {
                        count = student.gpa;
                        topStudent = student;
                    }
                }

                return topStudent;
            }

            Student top = topStudent(students);
            Console.WriteLine(top.gpa);
        }

        
    }


}