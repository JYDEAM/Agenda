using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        public void VerPrincipal(int l, int t)
        {
            

            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 65, t + 22);
                Console.WriteLine("ING. JEFFERZON ECHEVERRIA");

                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU PRINCIPAL DE AGENDA TELEFÓNICA");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. AGREGAR CONTACTO");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. VER LISTA DE CONTACTOS");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. BUSCAR CONTACTO");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. MOFICICAR CONTACTO");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. ELIMINAR CONTACTO");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. SALIR");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        new PresentacionCP().EjecutarAgregar(15, 5);
                        break;
                    case 2:
                        
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("GRACIAS, VUELVA PRONTO");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 6);
        }
    }
}
