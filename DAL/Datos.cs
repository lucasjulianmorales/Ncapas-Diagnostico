﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDAL
    {
     
        public Cliente Existe(Cliente newCliente) //Especifico tipo dato a devolver es del tipo Cliente
        {

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-HJ3D0O9\\sqlExpress;Initial Catalog=test;Integrated Security=True");
            conexion.Open();
            SqlCommand Cmm = conexion.CreateCommand();

            Cmm.CommandText = "SELECT COUNT(ID_cliente) FROM Cliente WHERE ID_cliente = @ID_cliente";
            Cmm.Parameters.AddWithValue("@ID_cliente", newCliente.Numero);

            newCliente.Numero = (int)Cmm.ExecuteScalar();
            conexion.Close();

            return newCliente;
        }

        public void NewCliente(Cliente newCliente)
        {
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HJ3D0O9\\sqlExpress; Initial Catalog = test; Integrated Security = True");
            conexion.Open();
            SqlCommand Cmm = conexion.CreateCommand();

            Cmm.CommandText = "INSERT INTO CLIENTE (ID_cliente, Nombre, Fecha_nac , Telefono) OUTPUT INSERTED.ID_cliente VALUES (@ID_cliente, @Nombre, @Fecha_nac, @Telefono)";

            Cmm.Parameters.AddWithValue("@ID_cliente", newCliente.Numero);
            Cmm.Parameters.AddWithValue("@Nombre", newCliente.Nombre);
            Cmm.Parameters.AddWithValue("@Fecha_nac", newCliente.Fecha_Nacimiento);
            Cmm.Parameters.AddWithValue("Telefono", newCliente.Telefono);

            Cmm.ExecuteNonQuery();
            conexion.Close();
        }
        public void DelCliente(Cliente delCliente)
        {
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HJ3D0O9\\sqlExpress; Initial Catalog = test; Integrated Security = True");
            conexion.Open();
            SqlCommand Cmm = conexion.CreateCommand();

            Cmm.CommandText = "Delete From Cliente Where ID_cliente = @ID_cliente";
            Cmm.Parameters.AddWithValue("@ID_cliente", delCliente.Numero);

            Cmm.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdCliente(Cliente updCliente)
        {
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HJ3D0O9\\sqlExpress; Initial Catalog = test; Integrated Security = True");
            conexion.Open();
            SqlCommand Cmm = conexion.CreateCommand();

            Cmm.CommandText = "UPDATE CLIENTE SET ID_cliente = @ID_cliente, NOMBRE = @Nombre, FECHA_NAC = @Fecha_nac, TELEFONO = @Telefono WHERE ID_cliente = @ID_cliente";
            Cmm.Parameters.AddWithValue("@ID_cliente", updCliente.Numero);
            Cmm.Parameters.AddWithValue("@Nombre", updCliente.Nombre);
            Cmm.Parameters.AddWithValue("@Fecha_nac", updCliente.Fecha_Nacimiento);
            Cmm.Parameters.AddWithValue("Telefono", updCliente.Telefono);

            Cmm.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
