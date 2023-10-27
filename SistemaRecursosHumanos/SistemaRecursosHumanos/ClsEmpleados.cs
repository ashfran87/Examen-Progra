using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecursosHumanos
{
    internal class ClsEmpleados
    {
        //atributos
        static int cant = 10;
        static int indice = 0;
        static int posicion = 1;
        private static bool empleadoEncontrado;
        static string[] ID = new string[cant];
        static string[] Name = new string[cant];
        static string[] Direccion = new string[cant];
        static string[] Telefono = new string[cant];
        static double[] Salario = new double[cant];

        //Metodos
        public static void inicilaizar()
        {
            ID = Enumerable.Repeat("", cant).ToArray();
            Name = Enumerable.Repeat("", cant).ToArray();
            Direccion = Enumerable.Repeat("", cant).ToArray();
            Telefono = Enumerable.Repeat("", cant).ToArray();
            Salario = Enumerable.Repeat(0.0, cant).ToArray();
            Console.Clear();
            Console.WriteLine("Arreglos inicializados");
            Console.ReadLine();
        }





        public static void agregar()
        {
            char respuesta = ' ';

            do
            {
                Console.WriteLine($"Digite el nombre del empleado {posicion}: ");
                Name[indice] = Console.ReadLine();

                Console.WriteLine($"Digite la cédula del empleado {posicion}: ");
                ID[indice] = Console.ReadLine();

                Console.WriteLine($"Digite el teléfono del empleado {posicion}: ");
                Telefono[indice] = Console.ReadLine();

                Console.WriteLine($"Digite la dirección del empleado {posicion}: ");
                Direccion[indice] = Console.ReadLine();

                double salario;
                Console.WriteLine($"Digite el salario del empleado {posicion}: ");
                while (!double.TryParse(Console.ReadLine(), out salario) || salario < 0)
                {
                    Console.WriteLine("Por favor, digite un salario válido (número positivo).");
                }
                Salario[indice] = salario;

                indice++;
                posicion++;

                Console.WriteLine("Desea agregar otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            } while (respuesta == 'S' && posicion < cant);


        }
        public static void Borrar()
        {
            Console.Write("Digite el ID del empleado que desea eliminar: ");
            string idAEliminar = Console.ReadLine();

            for (int i = 0; i < cant; i++)
            {
                if (ID[i] == idAEliminar)
                {
                    // Eliminar empleado moviendo los empleados posteriores una posición hacia arriba
                    for (int j = i; j < cant - 1; j++)
                    {
                        ID[j] = ID[j + 1];
                        Name[j] = Name[j + 1];
                        Direccion[j] = Direccion[j + 1];
                        Telefono[j] = Telefono[j + 1];
                        Salario[j] = Salario[j + 1];
                    }

                    // Limpiar los datos del último empleado (duplicado al final debido al bucle)
                    ID[cant - 1] = "";
                    Name[cant - 1] = "";
                    Direccion[cant - 1] = "";
                    Telefono[cant - 1] = "";
                    Salario[cant - 1] = 0.0;

                    Console.WriteLine("Empleado con ID " + idAEliminar + " eliminado correctamente.");
                    empleadoEncontrado = true;
                    break;
                }
            }

            if (!empleadoEncontrado)
            {
                Console.WriteLine("Empleado con ID " + idAEliminar + " no encontrado.");
            }

            Console.ReadLine();

        }
        //Consultar a un empleado por la cedula = ID == Cedula
        public static void Consultar()
        {
            Console.Write("Digite la ID del empleado que desea consultar: ");
            string idAConsultar = Console.ReadLine();

            bool empleadoEncontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (ID[i] == idAConsultar)
                {
                    Console.WriteLine($"Empleado encontrado: ");
                    Console.WriteLine($"ID: {ID[i]}");
                    Console.WriteLine($"Nombre: {Name[i]}");
                    Console.WriteLine($"Dirección: {Direccion[i]}");
                    Console.WriteLine($"Teléfono: {Telefono[i]}");
                    Console.WriteLine($"Salario: {Salario[i]}");

                    empleadoEncontrado = true;
                    break;
                }
            }

            if (!empleadoEncontrado)
            {
                Console.WriteLine($"Lo sentimos! No se encontró ningún empleado con el ID {idAConsultar}.");
            }

            Console.ReadLine();
        }
        // Que el usuario pueda modificar nombre,telefono.direccion, cedula,salario
        public static void Modificar()
        {
            Console.Write("Digite la cédula del empleado que desea modificar: ");
            string cedulaAModificar = Console.ReadLine();

            bool empleadoEncontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (ID[i] == cedulaAModificar)
                {
                    Console.WriteLine($"Empleado encontrado: ");
                    Console.WriteLine("");
                    Console.WriteLine($"ID: {ID[i]}");
                    Console.WriteLine($"Nombre: {Name[i]}");
                    Console.WriteLine($"Dirección: {Direccion[i]}");
                    Console.WriteLine($"Teléfono: {Telefono[i]}");
                    Console.WriteLine($"Salario: {Salario[i]}");
                    Console.WriteLine("");

                    Console.WriteLine("Digite el nuevo nombre del empleado: ");
                    Name[i] = Console.ReadLine();

                    Console.WriteLine("Digite la nueva cedula del empleado: ");
                    Telefono[i] = Console.ReadLine();

                    Console.WriteLine("Digite el nuevo teléfono del empleado: ");
                    Telefono[i] = Console.ReadLine();

                    Console.WriteLine("Digite la nueva dirección del empleado: ");
                    Direccion[i] = Console.ReadLine();

                    Console.WriteLine("Digite el nuevo salario del empleado: ");
                    double nuevoSalario;
                    while (!double.TryParse(Console.ReadLine(), out nuevoSalario) || nuevoSalario < 0)
                    {
                        Console.WriteLine("Por favor, digite un salario válido (número positivo).");
                    }
                    Salario[i] = nuevoSalario;

                    Console.WriteLine("Empleado modificado correctamente.");
                    empleadoEncontrado = true;
                    break;
                }
            }

            if (!empleadoEncontrado)
            {
                Console.WriteLine($"No se encontró ningún empleado con la cédula {cedulaAModificar}.");
            }

            Console.ReadLine();
        }
           //hacer una lista de  los empleados por nombre
           public static void Reporte()
        {
            Console.WriteLine("==================== IReporte ======================");
            for (int i = 0; i < posicion; i++)
            {
                Console.WriteLine($"Cedula: {ID[i]}  Nombre: {Name[i]}");
                Console.WriteLine($"Direccion: {Direccion[i]}   Telefono: {Telefono[i]}   Salario: {Salario[i]}");
            }
            Console.WriteLine("====================Fin del reporte====================");
            Console.ReadLine();
            Console.Clear();
        }

        public static void PromSalarios ()
        {
            {
                double acum = 0;
                double promedio = 0;
                // EN todas las posiciones ya registradas se acumulan para luego dividirlo entre la cantidad de posiciones
                for (int i = 0; i < posicion; i++)
                {
                    acum = Salario[i] + acum;
                }
                promedio = acum / posicion;
                Console.WriteLine($"El promedio de salarios es de: {promedio}");
                Console.ReadLine();
            }
        }
        public static void MayoOMenor()
        {
            {
                double mayor = 0;
                double menor = 0;
                for (int i = 0; i < posicion; i++)
                {
                    if (Salario[i] > mayor)
                    {
                        mayor = Salario[i];
                    }
                    if (i == 1)
                    {
                        menor = mayor;
                    }
                    else if (Salario[i] < menor)
                    {
                        menor = Salario[i];
                    }


                }
                Console.WriteLine($"El salario mayor es {mayor} y el menor es {menor}]");
                Console.ReadLine();
            }

        }


    }

          
    }

