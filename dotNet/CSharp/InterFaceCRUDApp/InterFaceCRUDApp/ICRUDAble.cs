using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterFaceCRUDApp
{
    public interface ICRUDAble
    {
        void Create();
        void Update();
        void Read();
        void Delete();
    }
}
