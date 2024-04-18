using CapadeDatos.BaseDeDatos;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.Core
{
    public class Repository<T> : iRepository<T> where T : class
    {
        public TeatroContext dbcontext;

        public Repository()
        {
            this.dbcontext = new TeatroContext();
        }
        public void Guardar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
        }
        public void AgregarRango(IEnumerable<T> entidades)
        {
            dbcontext.Set<T>().AddRange(entidades);
        }
        public void Actualizar(T entidad)
        {
            dbcontext.Set<T>();
        }
        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
        }
        public void Buscar(T entidad)
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }


    }
}
