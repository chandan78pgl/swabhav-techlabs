using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp.TestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(101, "Chandan", 22);
            Player player2 = new Player(102, "Dharmesh", 21);

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            Console.WriteLine("Elder is : {0}",player1.WhoIsElder(player2));

            Console.WriteLine("Equality: {0}", player1.Equals(player2));
        }
    }
}
