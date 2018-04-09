using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        public Cliente (int numero, string nombre, string telefono, DateTime fecha_nacimiento)
        {
            this.Nombre = nombre;
            this.Numero = numero;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Telefono = telefono;
        }
    }

}
