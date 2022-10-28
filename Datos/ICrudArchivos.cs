using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public interface ICrudArchivos<T>
    {
       bool Update(List<T> contactos);// eleiminar y actualizar
        List<T> GetAll();
        T Mapper(string linea);

    }
}