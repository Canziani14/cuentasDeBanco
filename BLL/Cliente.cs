using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente : BE.ICRUDCliente<BE.Cliente>
    {
        DAL.Cliente DALCliente = new DAL.Cliente();

        public bool depositar()
        {
            return true;
        }

        public bool extraer()
        {
            return true;
        }


        public bool Add(BE.Cliente objAlta)
        {
            return DALCliente.Add(objAlta);
        }

        public bool Delete(BE.Cliente objDelete)
        {
            throw new NotImplementedException();
        }

        public List<BE.Cliente> GetAll()
        {
            return DALCliente.GetAll();
        }

        public bool Updata(BE.Cliente objActualizar)
        {
            throw new NotImplementedException();
        }
    }
}
