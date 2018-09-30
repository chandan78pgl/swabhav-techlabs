using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp.Test
{
    class TestCollege
    {
        static void Main(string[] args)
        {
            Person dipen = new Professor(101, "Dipen", "Dahod", "15/10/1995",Branch.COMPUTER,12,20000,8);
            Person chandan = new Student(140180, "Chandan", "Surat", "25/11/1995", Branch.COMPUTER, 8);

            if(dipen is Professor)
            {
                Console.WriteLine(dipen);
            }

            Console.WriteLine("----------------------------");

            if (chandan is Student)
            {
                Console.WriteLine(chandan);
            }     
        }
    }
}
