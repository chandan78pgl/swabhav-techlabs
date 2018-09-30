using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Chandan", "Dharmesh", "Foo" };

            IEnumerable<String> myNames = names;

            IEnumerable<String> myNamesWithA = myNames.Where<string>((s)=>s.Contains("a"));

            IEnumerable<String> mynamesWithAabove4 = myNamesWithA.Where<string>((s)=>s.Length >= 4);

            foreach (string name in mynamesWithAabove4)
            {
                Console.WriteLine(name);
            }  
        }
    }
}
