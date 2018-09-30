using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterFaceCRUDApp
{
    public class CustomerDB : ICRUDAble
    {
        public void Create()
        {
            Console.WriteLine("CustomerDB is Created");
        }

        public void Delete()
        {
            Console.WriteLine("CustomerDB is Deleting");
        }

        public void Read()
        {
            Console.WriteLine("CustomerDB is Reading");
        }

        public void Update()
        {
            Console.WriteLine("CustomerDB is Updated");
        }
    }
}
