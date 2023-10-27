using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecursosHumanos
{
    internal class ClsMenu
    {
        //Atributo el usuario define
        static int opcion = 0;

        //Metodos
        public static void MostrarMenu()
        {
            int op = 0;
            do
            {
                
                Console.WriteLine("********************   Menu RCH          *******************************");
                Console.WriteLine("**********************  Opciones:   ************************************");
                Console.WriteLine("");
                Console.WriteLine("     1. Agregar empleados");
                Console.WriteLine("     2. Consultar empleado");
                Console.WriteLine("     3. Modificar empleado");
                Console.WriteLine("     4. Borrar empleado");
                Console.WriteLine("     5. Inicializar arreglos");
                Console.WriteLine("     6. Reportes");
                Console.WriteLine("     7. Salir del programa");
                Console.WriteLine("     Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out op);

                switch (op)
                {
                    case 1: ClsEmpleados.agregar(); break;
                    case 2: ClsEmpleados.Consultar(); break;
                    case 3: ClsEmpleados.Modificar(); break;
                    case 4: ClsEmpleados.Borrar(); break;
                    case 5: ClsEmpleados.inicilaizar(); break;
                    //case 6: submenuDeRepor(); break;
                   
                    default:
                        break;
                }

            }while (op !=7);


        }
        //Crear submenu para los reportes
        public static void SubMenuReport()
        {
            int op = 0;
            do
            {

                Console.WriteLine("********************   SubMenu de reportes         *******************************");
                Console.WriteLine("**********************  Opciones:   ************************************");
                Console.WriteLine("");
                Console.WriteLine("     1. Reporte general");
                Console.WriteLine("     2. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("     3. Calcular y mostrar el salario más alto y el más bajo de todos los empleados");
                Console.WriteLine("     4. Salir");
                Console.WriteLine("     Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out op);

                switch (op)
                {
                    case 1: ClsEmpleados.Reporte(); break;
                    case 2: ClsEmpleados.PromSalarios(); break;
                    case 3: ClsEmpleados.MayoOMenor(); break;
                    case 4: ClsEmpleados.Borrar(); break;
                    

                    default:
                        break;
                }

            } while (op !=4);
        }

    }
}
