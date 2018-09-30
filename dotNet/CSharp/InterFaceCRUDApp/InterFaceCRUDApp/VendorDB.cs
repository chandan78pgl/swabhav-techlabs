using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterFaceCRUDApp
{
    public class VendorDB : ICRUDAble
    {
        public void Create()
        {
            Console.WriteLine("VendorDB is Created");
        }

        public void Delete()
        {
            Console.WriteLine("VendorDB is Deleting");
        }

        public void Read()
        {
            Console.WriteLine("VendorDB is Reading");
        }

        public void Update()
        {
            Console.WriteLine("VendorDB is Updating");
        }
    }
}
