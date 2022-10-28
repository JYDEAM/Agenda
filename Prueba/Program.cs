using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entidades.Familiar familiar = new Entidades.Familiar();
            Entidades.Familiar familiar2 = new Entidades.Familiar();
            familiar.Id = 1;
            familiar.Nombre = "Carlos";
            familiar.Telefono = "3182945266";
            familiar.FechaNacimiento = new DateTime(1999,10,11);

            familiar2.Id = 2;
            familiar2.Nombre = "pedro";
            familiar2.Telefono = "6464646464";
            familiar2.FechaNacimiento = new DateTime(2001, 10, 11);

            Logica.ServicioContactosFamiliar servicioCF = new Logica.ServicioContactosFamiliar();
            Console.WriteLine(   servicioCF.Add(familiar));
            Console.WriteLine(   servicioCF.Add(familiar2));
            Console.WriteLine("nombre -- telefono");
            foreach (var item in servicioCF.GetAll())
            {
                Console.WriteLine(item.Nombre + " -- " + item.Telefono);
            }
            //Console.WriteLine("El nombre es: " + familiar.Nombre);
            //Console.WriteLine("Su fecha de nacimiento es: " + familiar.FechaNacimiento);
            Console.ReadKey();  

        }
    }
}
