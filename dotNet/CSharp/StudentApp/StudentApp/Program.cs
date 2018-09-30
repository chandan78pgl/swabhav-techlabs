using StudentApp.StudentClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{

    class Program
    {
        private static Dictionary<Student, Student> studentMap = new Dictionary<Student, Student>();

        static void Main(string[] args)
        {
            Student student1 = new Student(101,"Chandan",8);
            Student student2 = new Student(102, "Dharmesh", 6);
            Student student3 = new Student(101, "Foo", 9);

            studentMap.Add(student1, student1);
            studentMap.Add(student2, student2);

            foreach(KeyValuePair<Student,Student> student in studentMap)
            {
                Console.WriteLine(student);
            }
        }
    }
}
