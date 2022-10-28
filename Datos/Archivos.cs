using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Datos
{
    public class Archivos
    {
       protected string ruta;
        public Archivos(string fileNme)
        {
            ruta = fileNme;
        }
        public Archivos()
        {
            ruta = "contactos.TXT";
        }
        public bool Guardar(Entidades.Persona contacto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(contacto.ToString());
                sw.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        
    }
}
