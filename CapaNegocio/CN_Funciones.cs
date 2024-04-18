using CapadeDatos.Modelos;
using CapadeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Funciones
    {
        CD_Funciones dFunciones;
        public CN_Funciones()
        {
            dFunciones = new CD_Funciones();
        }

        public List<FuncionesModel> obtenerFuncion()
        {
            return dFunciones.TodasLasFunciones();
        }
        public List<FuncionesModel> obtenerFuncionesGrid()
        {
            var clientes = dFunciones.TodasLasFunciones()
                                   .ToList()
                                   .Select(c => new { c.FuncionId, c.Nombre, c.FechaFuncion, c.HoraInicio, c.HoraFin,c.Estado });
            return dFunciones.TodasLasFunciones();
        }

        public List<FuncionesModel> obtenerFuncionesInactivos()
        {
            var clientes = dFunciones.TodasLasFunciones();
            return clientes.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(FuncionesModel cliente)
        {
            if (cliente.FuncionId == 0)
            {
                return dFunciones.Guardar(cliente);
            }
            else
            {
                return dFunciones.Actualizar(cliente);
            }

        }

        public int Eliminar(int FuncionId)
        {
            return dFunciones.Eliminar(FuncionId);
        }
    }
}
