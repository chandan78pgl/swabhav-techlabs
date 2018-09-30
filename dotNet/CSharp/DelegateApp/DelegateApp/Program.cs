using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateApp
{
    public delegate void DMessage(String name);
    public class Program
    {
        public static void SayHello(String name)
        {
            Console.WriteLine("Hello Mr. {0}", name);
        }

        public static void SayGoodBye(String name)
        {
            Console.WriteLine("GoodBye Mr. {0}", name);
        }

        public static void MessageWizard(DMessage message)
        {
            Console.WriteLine("Inside Message Wizard");
            message("CHAMP Work Done");
        }

        public static void Foo()
        {

        }

        static void Main(string[] args)
        {
            DMessage manyMessage;

            manyMessage = SayHello;
            manyMessage("Chandan");

            manyMessage = SayGoodBye;
            manyMessage("Dharmesh");

            DMessage multiMessage=new DMessage(SayHello);

            multiMessage += SayGoodBye;
            multiMessage += SayGoodBye;

            multiMessage("Chandan");
            multiMessage("Dharmesh");

            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);
        }
    }
}
