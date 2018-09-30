using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwabhavQAdapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenericAdapter<int> genericAdapter = new GenericAdapter<int>();

            genericAdapter.eQueue(32);
            genericAdapter.eQueue(2);
            genericAdapter.eQueue(3);
            genericAdapter.eQueue(302);

            foreach(int i in genericAdapter)
            {
                Console.WriteLine("Number: {0}",i);
            }
        }
    }
}
