using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class ServicioContactosFamiliar : IServices<Familiar>
    {
        List<Familiar> familiars;
        RepositorioContactosFamiliar repositorioContactosFamiliar;
        public ServicioContactosFamiliar()
        {
            repositorioContactosFamiliar = new RepositorioContactosFamiliar("Familiares.txt");

            familiars = repositorioContactosFamiliar.GetAll();
        }
        void Refresh()
        {
            familiars = repositorioContactosFamiliar.GetAll();
        }
        public string Save(Familiar contacto)
        {
            //validar
            if (GetByPhone(contacto.Telefono)!= null)
            {
                return "contacto ya existe con este numero de telefono";
            }
            // fin validar

            var estado= repositorioContactosFamiliar.Guardar(contacto);

            Refresh();
            
           return estado ?  $"el contacto se agrego correctamente con el nombre {contacto.Nombre}" :
                                $"ERROR al Guardar el contacto con el nombre {contacto.Nombre}";
        }

        public string Delete(Familiar contacto)
        {
            familiars.Remove(contacto);
            repositorioContactosFamiliar.Update(familiars);
            Refresh();
            return $"el contacto se elimino correctamente con el nombre {contacto.Nombre}";
        }

        public string Edit(Familiar oldContacto, Familiar UpdateContacto)
        {
            //oldContacto.Id = UpdateContacto.Id;
            oldContacto.Nombre = UpdateContacto.Nombre;
            oldContacto.Telefono = UpdateContacto.Telefono;
            oldContacto.FechaNacimiento = UpdateContacto.FechaNacimiento;
            var estado= repositorioContactosFamiliar.Update(familiars);
            Refresh();
            return estado ? $"se actulizo el contacto {UpdateContacto.Nombre}" :
                $"ERROR al actulizar el contacto {UpdateContacto.Nombre}";
        }

        public bool Exist(Familiar contacto)
        {
            foreach (var item in familiars)
            {
                if (item.Id == contacto.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Familiar> GetAll()
        {
            return familiars;
        }

        public Familiar GetById(int id)
        {
            foreach (var item in familiars)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }

        public Familiar GetByPhone(string phone)
        {
            foreach (var item in familiars)
            {
                if (item.Telefono == phone)
                {
                    continue;
                }
                return item;
            }
            return null;
        }

        
    }
}
