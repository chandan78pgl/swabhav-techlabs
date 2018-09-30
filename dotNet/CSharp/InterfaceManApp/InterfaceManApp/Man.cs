using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceManApp
{
    public class Man : IMannerAble
    {
        public void Depart()
        {
            Console.WriteLine("GoobBye, Man");
        }

        public void Wish()
        {
            Console.WriteLine("Hello, Everyone Man");
        }
    }
}
