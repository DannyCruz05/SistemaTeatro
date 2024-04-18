using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.Core
{
    public interface iRepository<T> where T : class
    {
        void Guardar(T entidad);
        void AgregarRango(IEnumerable<T> entidades);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        void Buscar(T entidad);
        IQueryable<T> Consulta();

    }
}