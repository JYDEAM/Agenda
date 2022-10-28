using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioContactosEmpresarial : Archivos, ICrudArchivos<Empresarial>
    {
        public RepositorioContactosEmpresarial(string fileName) : base(fileName)
        {

        }

        public List<Empresarial> GetAll()
        {
            try
            {
                List<Empresarial> empresarials = new List<Empresarial>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    empresarials.Add(Mapper(sr.ReadLine()));
                }
                sr.Close();
                return empresarials;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public Empresarial Mapper(string linea)
        {
            try
            {
                var contacto = new Empresarial();
                contacto.Id = int.Parse(linea.Split(';')[0]);
                contacto.Nombre = (linea.Split(';')[1]);
                contacto.Telefono = (linea.Split(';')[2]);
                contacto.Nit = (linea.Split(';')[3]);
                contacto.RazonSocial = (linea.Split(';')[4]);
                contacto.Correo = (linea.Split(';')[5]);

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

        public bool Update(List<Empresarial> contactos)
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