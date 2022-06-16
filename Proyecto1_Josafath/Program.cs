using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_menu
{
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Opción 1: Usuario Regular");
                    Console.WriteLine("2. Opción 2: Usuario Administrador");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            menuUsuario();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            menuAdministrador();
                            break;
                        case 3:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 3");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
        public static void menuAdministrador()
        {

            Console.WriteLine("menu administrador");
        }

        public static void menuUsuario()
        {
            Console.WriteLine("menu usuario");

        }
    }
}
