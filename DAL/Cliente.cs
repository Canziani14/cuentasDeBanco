using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente : BE.ICRUDCliente<BE.Cliente>
    {

        string conectionString = @"Data Source=DESKTOP-NOJ7B2G\SQLEXPRESS;Initial Catalog=Banco;Integrated Security=True";
        public bool Add(BE.Cliente objAlta)
        {
            bool returnValue = false;

            string insertQuery = $"insert into Cliente(nombre,apellido,direccion) Values ('{objAlta.nombre}', '{objAlta.apellido}', '{objAlta.direccion}')";


            SqlConnection connection = new SqlConnection(conectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = insertQuery;

            connection.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                returnValue = true;
            }

            connection.Close();

            return returnValue;


        }

        public bool Delete(BE.Cliente objDelete)
        {
            throw new NotImplementedException();
        }

        public List<BE.Cliente> GetAll()
        {
            
            string selectQuery = "SELECT * FROM cliente";
            //select cliente.ID, nombre, apellido, direccion, cuenta.saldo, numero from cliente inner join cuenta ON cliente.IDCuenta = cuenta.id
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            List<BE.Cuenta> cuentas = new List<BE.Cuenta>();

            SqlDataReader reader;
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = selectQuery;

            connection.Open();

            reader = command.ExecuteReader();
            table.Load(reader);

            connection.Close();

            foreach (DataRow item in table.Rows)
            {
                clientes.Add(new BE.Cliente()
                {
                    ID = item.Field<int>("ID"),
                    nombre = item.Field<string>("nombre"),
                    apellido = item.Field<string>("apellido"),
                    direccion = item.Field<string>("direccion"),

                });                
                
            }
            return clientes;
            
           
                     
        }

        public bool Updata(BE.Cliente objActualizar)
        {
            throw new NotImplementedException();
        }
    }
}
