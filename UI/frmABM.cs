using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;


namespace UI
{
    public partial class frmABM : Form
    {
        public frmABM()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Cliente newCliente = new Cliente(0,"","",DateTime.Now); //Creo un objeto de cliente

            //ClienteBLL BL = new ClienteBLL();        //Creo un objeto de Negocio para acceder a los metodos // no sirve para clases static

            CargaCliente(newCliente);                  //Metodo para Instanciar cliente
            ClienteBLL.AltaCliente(newCliente);        //Llamo al metodo de la BLL static

        }

        private void CargaCliente(Cliente C) //Intancio el objeto cliente
        {
            int nro = 0;
            if (!int.TryParse(txbNumero.Text, out nro)) ;
            {
                MessageBox.Show("Ingrese un Numero por favor");
            }
            C.Numero = Convert.ToInt32(txbNumero.Text);
            C.Nombre = txbNombre.Text;
            C.Telefono = txbTel.Text;
            C.Fecha_Nacimiento = Convert.ToDateTime(txbFechaNac.Text);
        }

        private void frmABM_Load(object sender, EventArgs e)
        {
            txbNumero.TabIndex = 1;
            txbNombre.TabIndex = 2;
            txbFechaNac.TabIndex = 3;
            txbTel.TabIndex = 4;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Cliente delcliente = new Cliente(0,"","",DateTime.Now);
            
            //ClienteBLL BL = new ClienteBLL();
            CargaCliente(delcliente);
            ClienteBLL.BajaCliente(delcliente);
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            Cliente updCliente = new Cliente(0, "", "", DateTime.Now);

            CargaCliente(updCliente);
            ClienteBLL.ActualizaCliente(updCliente);
            
        }
    }
}
