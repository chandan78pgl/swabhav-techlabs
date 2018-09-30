using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterFaceCRUDApp.Test
{
    public class TestICRUDAble
    {
        static void Main(string[] args)
        {
            ICRUDAble iCRUDAble;

            iCRUDAble = new CustomerDB();
            iCRUDAble.Create();
            iCRUDAble.Update();
            iCRUDAble.Read();
            iCRUDAble.Delete();

            iCRUDAble = new VendorDB();
            iCRUDAble.Create();
            iCRUDAble.Update();
            iCRUDAble.Read();
            iCRUDAble.Delete();

            iCRUDAble = new InvoiceDB();
            iCRUDAble.Create();
            iCRUDAble.Update();
            iCRUDAble.Read();
            iCRUDAble.Delete();
        }

        public static void toDoCreate(ICRUDAble iCRUDAble)
        {
            iCRUDAble.Create();
        }

        public static void toDoUpdate(ICRUDAble iCRUDAble)
        {
            iCRUDAble.Update();
        }

        public static void toDoRead(ICRUDAble iCRUDAble)
        {
            iCRUDAble.Read();
        }

        public static void toDoDelete(ICRUDAble iCRUDAble)
        {
            iCRUDAble.Delete();
        }
    }
}
