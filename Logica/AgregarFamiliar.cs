using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgregarFamiliar
    {
        public void Agregar(int l, int t, String nom, String tel/*, String fechaN*/)
        {
            List<String> Nombres = new List<String>();
            

            familia.Nombre = nom;
            familia.Telefono = tel;
            //familia.FechaNacimiento = DateTime.Parse(fechaN);

            Nombres.Add(familia.Nombre);
            Nombres.Add(familia.Telefono);
            //Nombres.Add(String.Format("{0:d}", familia.FechaNacimiento));

            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("El nombre es: ");
            Console.SetCursorPosition(l, t + 3);
            Console.WriteLine("El telefono es: ");
            Console.SetCursorPosition(l, t + 4);
            Console.WriteLine("La fecha es: ");

            foreach (String familiares in Nombres)
            {
                Console.SetCursorPosition(l + 14, t + 2);
                Console.WriteLine(familiares);
                l = l+2;
                t++;
            }


        }

        
    }
}
