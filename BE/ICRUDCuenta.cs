using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICRUDCuenta <T>
    {
        void Add(T objAlta);
        List<T> GetAll();
        void Updata(T objActualizar);
        void Delete(T objDelete);
    }
}
