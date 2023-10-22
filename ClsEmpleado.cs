using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class ClsEmpleado
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double Salario { get; set; }

        // Constructor de la clase "ClsEmpleado" con los parámetros mencionados anteriormente.
        // El constructor es público ("public"), lo que significa que puede ser accedido desde cualquier parte del programa.
        // Los parámetros del constructor se definen como cadenas de texto ("string") para "cedula", "nombre", "direccion" y "telefono",
        // Y como un número de punto flotante ("double") para "salario".

        public ClsEmpleado (string cedula, string nombre, string direccion, string telefono, double salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
        }


    }
}
