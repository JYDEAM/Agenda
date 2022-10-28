using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionCP
    {
        public void EjecutarAgregar(int l, int t)
        {
            Console.Clear();

            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("Digite el nombre del contacto: ");
            Console.SetCursorPosition(l + 31, t - 2);
            string nom = Console.ReadLine();

            Console.SetCursorPosition(l, t - 1);
            Console.WriteLine("Digite el telefono del contacto: ");
            Console.SetCursorPosition(l + 34, t - 1);
            string tel = Console.ReadLine();

            //Console.SetCursorPosition(l, t + 0);
            //Console.WriteLine("Digite la fecha de nacimiento: ");
            //Console.SetCursorPosition(l + 31, t + 0);
            //String fechaNacimiento = Console.ReadLine();
            //String fechaN = Console.ReadLine();

            //new Logica.AgregarFamiliar().Agregar(l, t, nom, tel);

            Console.SetCursorPosition(l, t + 5);
            Console.ReadKey();

        }


    }
}
