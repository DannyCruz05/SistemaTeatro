using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.Core
{
    internal interface iUnitofWork
    {

        iRepository<T> Repository<T>() where T : class;
        int Guardar();
        void ComenzarTransaccion();
        void ReversarTransaccion();
        void ConfirmarTransaccion();
    }
}
