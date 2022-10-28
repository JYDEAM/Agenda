using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Datos
{
    public class RepositorioContactosFamiliar: Archivos, ICrudArchivos<Familiar>
    {
        public RepositorioContactosFamiliar(string fileName):base( fileName)
        {
            
        }

        public List<Familiar> GetAll()
        {
            try
            {
                List<Familiar> familiars = new List<Familiar>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    familiars.Add(Mapper(sr.ReadLine()));
                }
                sr.Close();
                return familiars;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
       public Familiar Mapper(string linea)
        {
            try
            {
                var contacto = new Familiar();
                contacto.Id = int.Parse(linea.Split(';')[0]);
                contacto.Nombre = (linea.Split(';')[1]);
                contacto.Telefono = (linea.Split(';')[2]);
                contacto.FechaNacimiento = DateTime.Parse(linea.Split(';')[3]);
                return contacto;

            }
            catch (Exception)
            {
                return null;
            }
            
        }

       /* public string Save(Familiar contacto)
        {
            throw new NotImplementedException();
        }*/

        public bool Update(List<Familiar> contactos)
        {
            try
            {
                var sw = new StreamWriter(ruta, false);
                foreach (var item in contactos)
                {
                    sw.WriteLine(item.ToString());
                }

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
