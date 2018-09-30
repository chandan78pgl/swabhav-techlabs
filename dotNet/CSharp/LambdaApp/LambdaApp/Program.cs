using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaApp
{
    
    public class Program
    {
        public delegate void DMessage(String s);
        static void Main(string[] args)
        {
            DMessage message = SayHello;

            message("Chandan");

            message = SayGoodBye;

            message("Chandan");

            Action<string> actionMessage = SayHello;

            actionMessage("Chandan");
            actionMessage = SayGoodBye;
            actionMessage("Chandan");

            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);

            MessageWizard((name) => Console.WriteLine("OLA, {0}",name));

            Func<int, double> f = (x) => x + x * x;

            Console.WriteLine("Answer is {0}",f(10));

            Predicate<int> predicate = (x) => {
                if (x>5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            Console.WriteLine("Predicate Answer = {0}",predicate(6));
        }

        public static void SayHello(String name)
        {
            Console.WriteLine("Hello, {0}", name);
        }

        public static void SayGoodBye(String name)
        {
            Console.WriteLine("GoodBye, {0}",name);
        }

        public static void MessageWizard(Action<string> message)
        {
            message("Chandan");
        }
    }
}
