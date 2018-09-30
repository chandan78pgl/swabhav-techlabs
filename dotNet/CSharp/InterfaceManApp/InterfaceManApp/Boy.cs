using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceManApp
{
    public class Boy : IMannerAble, IEmotionAble
    {
        public void Cry()
        {
            Console.WriteLine("Boy is Crying");
        }

        public void Depart()
        {
            Console.WriteLine("GoodBye Boy");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Hello, Everyone Boy");
        }
    }
}
