using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterFaceCRUDApp
{
    public class InvoiceDB : ICRUDAble
    {
        public void Create()
        {
            Console.WriteLine("InvoiceDB is Created");
        }

        public void Delete()
        {
            Console.WriteLine("InvoiceDB is Deleting");
        }

        public void Read()
        {
            Console.WriteLine("InvoiceDB is Reading");
        }

        public void Update()
        {
            Console.WriteLine("InvoiceDB is Updating");
        }
    }
}
