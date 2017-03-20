using Financiera.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructura.Datos.Repositorios
{
    public class RepositorioGeneral<T> : IRepositorioGeneral<T> where T : class
    {
        readonly FinancieraContexto io_contexto;
        public RepositorioGeneral()
        {
            io_contexto = new FinancieraContexto();
        }

        public T Buscar(params object[] ao_parametros)
        {
            return io_contexto.Set<T>().Find(ao_parametros);
        }

        public void GuardarCambios()
        {
            io_contexto.SaveChangesAsync();
        }

        public void Insertar(T ao_objeto)
        {
            io_contexto.Set<T>().Add(ao_objeto);
        }

        public IList<T> Listar(Expression<Func<T, bool>> ao_llaves = null)
        {
            if (ao_llaves == null)
                return io_contexto.Set<T>().ToList();
            else
                return io_contexto.Set<T>().Where(ao_llaves).ToList();
        }
    }
}
