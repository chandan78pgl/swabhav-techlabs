using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp.Test
{
    public class TestCollection
    {
        static void Main(string[] args)
        {
            WithoutGenerics();
            WithGenerics();
        }

        private static void WithoutGenerics()
        {
            ArrayList list = new ArrayList();

            list.Add(new LineItem(101, "Chandan", 2, 2000));
            list.Add(new LineItem(102, "Shoes", 2, 1000));
            list.Add("Foo");

            try
            {
                foreach (Object obj in list)
                {
                    LineItem item = (LineItem)obj;
                    Console.WriteLine(item.TotalCost());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private static void WithGenerics()
        {
            List<LineItem> list = new List<LineItem>();

            list.Add(new LineItem(101, "Chandan", 2, 2000));
            list.Add(new LineItem(102, "Shoes", 1, 2000));
            list.Add(new LineItem(102, "Chappal", 4, 100));

            foreach(LineItem item in list)
            {
                Console.WriteLine(item.TotalCost());
            }
        }
    }
}
