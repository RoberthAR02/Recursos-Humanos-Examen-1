using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class ClsMenu
    {
        private ClsEmpleado[] empleados;
        private int cantidadEmpleados;

        public ClsMenu(int maxEmpleados)
        {
            empleados = new ClsEmpleado[maxEmpleados];
            cantidadEmpleados = 0;
        }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("********************** Sistema de Recursos Humanos ***********************");
            Console.WriteLine("1- Agregar Empleados");
            Console.WriteLine("2- Consultar Empleados");
            Console.WriteLine("3- Modificar Empleados");
            Console.WriteLine("4- Borrar Empleados");
            Console.WriteLine("5- Inicializar Arreglos");
            Console.WriteLine("6- Reportes");
            Console.WriteLine("**************************************************************************");
        }

        public void AgregarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Agregar un empleado");
            Console.Write("Ingrese la Cedula: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese el Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la Direccion: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el Telefono: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese el Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            // La variable "cantidadEmpleados" es un entero que se utiliza para llevar un registro,
            // del número de objetos de la clase "ClsEmpleado",
            // que se han agregado a la lista. El arreglo "empleados" es una lista de objetos de la clase "ClsEmpleado".
            // La primera línea de código crea un nuevo objeto de la clase "ClsEmpleado",
            // utilizando los valores de las variables "cedula", "nombre", "direccion", "telefono" y "salario".
            // El nuevo objeto se agrega a la lista de objetos "empleados" en la posición "cantidadEmpleados".
            // La segunda línea de código incrementa el valor de la variable "cantidadEmpleados" en uno.
            // Esto se hace para llevar un registro del número de objetos de la clase "ClsEmpleado" que se han agregado a la lista.
            empleados[cantidadEmpleados] = new ClsEmpleado(cedula, nombre, direccion, telefono, salario);
            cantidadEmpleados++;
            Console.WriteLine("El empleado se ha agregado con éxito.");
        }

        public void ConsultarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: Consultar Empleados");
            Console.Write("Ingrese el número de cédula del empleado: ");
            string cedulaBuscada = Console.ReadLine();

            // La variable "empleados" es una lista de objetos de la clase "Empleado".
            // El método "FirstOrDefault" se utiliza para buscar el primer objeto de la lista que cumpla con una condición específica.
            // En este caso, la condición es que la propiedad "Cedula" del objeto "Empleado",
            // sea igual al valor de la variable "cedulaBuscada".
            // El operador "=>" se utiliza para definir una expresión lambda que se utiliza como condición de búsqueda.
            // La expresión lambda se compone de dos partes: el parámetro "e" que representa cada objeto de la lista,
            // Y la condición de búsqueda "e.Cedula == cedulaBuscada".
            var empleadoEncontrado = empleados.FirstOrDefault(e => e != null && e.Cedula == cedulaBuscada);
            if (empleadoEncontrado != null)
                {
              Console.WriteLine("Información del Empleado:");
              Console.WriteLine($"Cedula: {empleadoEncontrado.Cedula}");
              Console.WriteLine($"Nombre: {empleadoEncontrado.Nombre}");
              Console.WriteLine($"Dirección: {empleadoEncontrado.Direccion}");
              Console.WriteLine($"Teléfono: {empleadoEncontrado.Telefono}");
              Console.WriteLine($"Salario: {empleadoEncontrado.Salario:F2} Colones");
            }
            else
            {
                    Console.WriteLine("Empleado no encontrado.");
            }
        }

        public void ModificarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: Modificar un empleado");
            Console.Write("Ingrese el número de cédula del empleado a modificar: ");
            string cedulaModificar = Console.ReadLine();

            var empleadoAModificar = empleados.FirstOrDefault(e => e != null && e.Cedula == cedulaModificar);
            if (empleadoAModificar != null)
            {
                Console.Write("Nuevo nombre de empleado: ");
                empleadoAModificar.Nombre = Console.ReadLine();
                Console.Write("Nueva dirección del empleado: ");
                empleadoAModificar.Direccion = Console.ReadLine();
                Console.Write("Nuevo número teléfono del empleado: ");
                empleadoAModificar.Telefono = Console.ReadLine();
                Console.Write("Nuevo salario del empleado: ");
                empleadoAModificar.Salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El empleado se ha modificado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public void BorrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: Para borrar Empleado");
            Console.Write("Ingrese el número de cédula del empleado a borrar: ");
            string cedulaBorrar = Console.ReadLine();

            int indiceABorrar = -1;
            for (int i = 0; i < cantidadEmpleados; i++)
            {
                if (empleados[i].Cedula == cedulaBorrar)
                {
                    indiceABorrar = i;
                    break;
                }
            }

            if (indiceABorrar != -1)
            {
                for (int i = indiceABorrar; i < cantidadEmpleados - 1; i++)
                {
                    empleados[i] = empleados[i + 1];
                }

                cantidadEmpleados--;
                Console.WriteLine("El empleado se ha borrado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public void InicializarArreglos()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: inicializar Arreglos");
            empleados = new ClsEmpleado[10];
            cantidadEmpleados = 0;
            Console.WriteLine("Arreglos inicializados satisfactoriamente.");
        }

        public void Reportes()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: Reportes");
            Console.WriteLine("1. Consultar empleados con número de cédula");
            Console.WriteLine("2. Lista de todos los empleados ordenados por nombre");
            Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
            Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo de todos los empleados");
            Console.Write("Seleccione una opción de reporte: ");
            int opcionReporte = Convert.ToInt32(Console.ReadLine());

            switch (opcionReporte)
            {
                case 1:
                    ConsultarEmpleados();
                    break;
                case 2:
                    ListarEmpleadosOrdenadosPorNombre();
                    break;
                case 3:
                    CalcularPromedioSalarios();
                    break;
                case 4:
                    CalcularSalariosExtremos();
                    break;
                default:
                    Console.WriteLine("Opción de reporte no válida.");
                    break;
            }
        }

        public void ListarEmpleadosOrdenadosPorNombre()
        {
            Console.Clear();
            Console.WriteLine("A continuación la lista de los empleados ordenados por nombre");
            // La variable "empleados" es una lista de objetos de la clase "Empleado".
            // El método "Where" se utiliza para filtrar los elementos nulos de la lista.
            // El método "OrderBy" se utiliza para ordenar los elementos de la lista por el campo "Nombre".
            // Finalmente, el método "ToList" se utiliza para crear una nueva lista ordenada,
            // Y almacenarla en la variable "empleadosOrdenados".
            var empleadosOrdenados = empleados.Where(e => e != null).OrderBy(e => e.Nombre).ToList();

            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}, Nombre: {empleado.Nombre}");
            }
        }

        public void CalcularPromedioSalarios()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: Calcular el promedio de los salarios");
            // La variable "empleados" es una lista de objetos de la clase "Empleado".
            // El método "Where" se utiliza para filtrar los elementos nulos de la lista.
            // El método "Select" se utiliza para seleccionar el campo "Salario" de cada objeto de la lista,
            // Y crear una nueva lista con los valores de salario.
            var salarios = empleados.Where(e => e != null).Select(e => e.Salario);
            double promedio = salarios.Average();

            Console.WriteLine($"El promedio de los salarios es: {promedio:F2} Colones");
        }

        public void CalcularSalariosExtremos()
        {
            Console.Clear();
            Console.WriteLine("Seleccionó: Calcular Salario más Alto y más Bajo");
            var salarios = empleados.Where(e => e != null).Select(e => e.Salario);
            double salarioMaximo = salarios.Max();
            double salarioMinimo = salarios.Min();

            var empleadoConSalarioMaximo = empleados.FirstOrDefault(e => e != null && e.Salario == salarioMaximo);
            var empleadoConSalarioMinimo = empleados.FirstOrDefault(e => e != null && e.Salario == salarioMinimo);

            Console.WriteLine($"El salario más alto es: {salarioMaximo:F2} colones y corresponde a {empleadoConSalarioMaximo?.Nombre}");
            Console.WriteLine($"El salario más bajo es: {salarioMinimo:F2} colones y corresponde a {empleadoConSalarioMinimo?.Nombre}"); 
        }
    }
}
