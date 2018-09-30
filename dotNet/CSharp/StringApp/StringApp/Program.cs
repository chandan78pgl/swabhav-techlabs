using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringApp
{
    class Program
    {
        static Hashtable table= new Hashtable();
        static void Main(string[] args)
        {
            String url = "https://www.swabhavtechlabs.com?user=\"Chandan\"";

            testSplit(url);

            ICollection key = table.Keys;

            foreach(string k in key)
            {
                Console.WriteLine("Using Split \n\nUser = {0} \nCompany = {1}", k, table[k]);
                Console.WriteLine("-------------------------------------");
            }
        }

        static void testSplit(String s)
        {
            String[] s1 = Regex.Split(s,"[.|\"|\']");
            table.Add(s1[3], s1[1]);

            foreach (string str in s1)
            {
                Console.WriteLine("String: {0}",str);
            }
        }
    }
}
