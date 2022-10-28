using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IServices<T>
    {
        /// <summary>
        /// Metodo para agregar contactos
        /// </summary>
        string Save(T contacto);
        string Delete(T contacto);
        string Edit(T oldContacto, T UpdateContacto);
        List<T> GetAll();
       T GetById(int id);
        T GetByPhone(string phone);
        bool Exist(T Contacto);

    }
}