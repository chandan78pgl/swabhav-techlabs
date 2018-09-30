using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp
{
    public static class StringExtension
    {
        public static void Swabhav(this string s)
        {
            Console.WriteLine(s + " Swabhav");
        }
    }
}
