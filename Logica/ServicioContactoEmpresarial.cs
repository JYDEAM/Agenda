using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioContactoEmpresarial : IServices<Empresarial>
    {
        List<Empresarial> empresarials;
        RepositorioContactosEmpresarial repositorioContactosEmpresarial;
        public ServicioContactoEmpresarial()
        {
            repositorioContactosEmpresarial = new RepositorioContactosEmpresarial("Empresarios.dat");
            empresarials = repositorioContactosEmpresarial.GetAll();
        }
        public string Delete(Empresarial contacto)
        {
            empresarials.Remove(contacto);
            repositorioContactosEmpresarial.Update(empresarials);
            Refresh();
            return $"el contacto se elimino correctamente con el nombre {contacto.RazonSocial}";
        }
        void Refresh()
        {
            empresarials = repositorioContactosEmpresarial.GetAll();
        }
        public string Edit(Empresarial oldContacto, Empresarial UpdateContacto)
        {
            //oldContacto.Id = UpdateContacto.Id;
            oldContacto.Nombre = UpdateContacto.Nombre;
            oldContacto.Telefono = UpdateContacto.Telefono;
            oldContacto.RazonSocial = UpdateContacto.RazonSocial;
            oldContacto.Correo = UpdateContacto.Correo;
            var estado = repositorioContactosEmpresarial.Update(empresarials);
            Refresh();
            return estado ? $"se actulizo el contacto {UpdateContacto.RazonSocial}" : 
                $"ERROR al actulizar el contacto {UpdateContacto.RazonSocial}";
        }

        public bool Exist(Empresarial Contacto)
        {
            throw new NotImplementedException();
        }

        public List<Empresarial> GetAll()
        {
            return empresarials;
        }

        public Empresarial GetById(int id)
        {
            foreach (var item in empresarials)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Empresarial GetByPhone(string phone)
        {
            foreach (var item in empresarials)
            {
                if (item.Telefono == phone)
                {
                    return item;
                }
            }
            return null;
        }

        public string Save(Empresarial contacto)

        {

            //validar
            if (GetByPhone(contacto.Telefono) != null)
            {
                return "contacto ya existe con este numero de telefono";
            }
            // fin validar

            var estado = repositorioContactosEmpresarial.Guardar(contacto);

            Refresh();

            return estado ? $"el contacto se agrego correctamente con el nombre {contacto.Nombre}" :
                                 $"ERROR al Guardar el contacto con el nombre {contacto.Nombre}";
        }
    }
}
