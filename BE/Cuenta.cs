using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cuenta
    {
        public int ID { get; set; }
        public int numero { get; set; }
        public Cliente cliente { get; set; }
        public float saldo { get; set; }
       
    }
}
