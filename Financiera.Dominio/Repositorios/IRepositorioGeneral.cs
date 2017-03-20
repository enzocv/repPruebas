using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Financiera.Dominio.Repositorios
{
    public interface IRepositorioGeneral<T>
    {
        IList<T> Listar(Expression<Func<T, bool>> ao_llaves = null);
        T Buscar(params object[] ao_parametros);
        void Insertar(T ao_objeto);
        void GuardarCambios();
    }
}
