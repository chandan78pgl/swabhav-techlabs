using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;

namespace ConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String fname,lname;

            fname = ConfigurationManager.AppSettings.Get("firstname");
            lname = ConfigurationManager.AppSettings.Get("lastname");

            Console.WriteLine("FirstName: {0} LastName: {1}",fname,lname);

            NameValueCollection names;
            names = ConfigurationManager.AppSettings;

            foreach(string name in names.AllKeys)
                Console.WriteLine("Key: "+name+"  Value: "+names.Get(name));
        }
    }
}
