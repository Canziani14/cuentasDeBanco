using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Cuenta
    {
        public bool Depositar()
        {
            return true;
        }

        public bool Extraer()
        {
            return true;
        }
       
    }
}
