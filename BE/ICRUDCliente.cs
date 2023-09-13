using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICRUDCliente <T>
    {
        bool Add(T objAlta);
        List<T> GetAll();
        bool Updata(T objActualizar);
        bool Delete (T objDelete);
    }
}
