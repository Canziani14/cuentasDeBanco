using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLL.Cliente BLLCliente = new BLL.Cliente();
        BE.Cliente BECliente = new BE.Cliente();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BLL.Cliente BLLCliente = new BLL.Cliente();
            BE.Cliente BECliente = new BE.Cliente();

            BECliente.nombre = txtNombre.Text;
            BECliente.apellido = txtApellido.Text;
            BECliente.direccion = txtDireccion.Text;
            
            //BECliente.cuenta = txtCuenta.Text;

            if (BLLCliente.Add(BECliente))
            {
                MessageBox.Show("Cliente creado con exito");
            }
            

        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
           dtgListarClientes.DataSource = BLLCliente.GetAll();
        }
    }
}
