using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Windows.Forms;

namespace BLL
{
    public static class ClienteBLL
    {
        public static void AltaCliente(Cliente newCliente)
        {
            try
            {
                ClienteDAL D = new ClienteDAL();
                int existe = newCliente.Numero;
                D.Existe(newCliente);

                if (newCliente.Numero != existe)
                {
                    D.NewCliente(newCliente);
                }
                else
                {
                    throw new Exception("El cliente ya existe");
                } 

            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }
        public static void BajaCliente(Cliente delCliente)
        {
            try
            {
                ClienteDAL D = new ClienteDAL();
                D.DelCliente(delCliente);
            }
            catch
            {
                throw new Exception("");
            }
        }
        public static void ActualizaCliente(Cliente updCliente)
        {
            ClienteDAL D = new ClienteDAL();
            D.UpdCliente(updCliente);

        }
    }
}
