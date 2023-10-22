using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se agregan al arreglo la cantidad de empleados que se nececiten.
            ClsMenu menu = new ClsMenu(10);
            bool salir = false;

            // Metodo diferente para aplicar el Switch y me funcionó.
            while (!salir)
            {
                menu.MostrarMenu();
                Console.Write("Seleccione una opción: ");

                int opcion;
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        menu.AgregarEmpleado();
                        break;
                    case 2:
                        menu.ConsultarEmpleados();
                        break;
                    case 3:
                        menu.ModificarEmpleado();
                        break;
                    case 4:
                        menu.BorrarEmpleado();
                        break;
                    case 5:
                        menu.InicializarArreglos();
                        break;
                    case 6:
                        menu.Reportes();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.Write("¿Desea realizar otra operación? (S/N): ");
                char continuar = Console.ReadLine().ToUpper()[0];
                if (continuar != 'S')
                {
                    salir = true;
                }
            }

        }
    }
}

