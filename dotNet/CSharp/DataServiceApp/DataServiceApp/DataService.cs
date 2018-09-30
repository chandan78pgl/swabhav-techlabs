using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataServiceApp
{
    public delegate void DResult(Int32 number);
    public class DataService
    {
        public event DResult OnSuccess;
        public event DResult OnError;

        public void GetData()
        {
            Random random = new Random();
            int num = random.Next(10);

            if (OnSuccess!=null && OnError!=null)
            {
                if (num > 5)
                {
                    OnSuccess(num);
                }
                else
                {
                    OnError(num);
                }
            }
            
        }

        private static void DataService_OnResult(int number)
        {
            throw new NotImplementedException();
        }
    }
}
