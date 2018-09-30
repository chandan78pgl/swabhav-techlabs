using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanApp.Test
{
    class TestHuman
    {
        static void Main(string[] args)
        {
            Human human = new Human("Chandan", GenderType.MALE, 22);

            human.eat();
            human.eat();
            human.eat();
            human.eat();
            human.eat();
            human.workout();
            human.workout();
 
            Console.WriteLine(human);
        }
    }
}
