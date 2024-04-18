using CapadeDatos;
using CapadeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        CD_Clientes dCLiente;
        public CN_Clientes()
        {
            dCLiente = new CD_Clientes();
        }

        public List<ClientesModel> obtenerCliente()
        {
            return dCLiente.TodosLosClientes();
        }
        public List<ClientesModel> obtenerClientesGrid()
        {
            var clientes = dCLiente.TodosLosClientes()
                                   .ToList()
                                   .Select(c => new { c.ClienteId, c.Codigo, c.DNI, c.Nombres, c.Apellidos, c.FechaCreacion, c.Estado });
            return dCLiente.TodosLosClientes();
        }

        public List<ClientesModel> obtenerClientesInactivos()
        {
            var clientes = dCLiente.TodosLosClientes();
            return clientes.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(ClientesModel cliente)
        {
            if (cliente.ClienteId == 0)
            {
                return dCLiente.Guardar(cliente);
            }
            else
            {
                return dCLiente.Actualizar(cliente);
            }

        }

        public int Eliminar(int clienteId)
        {
            return dCLiente.Eliminar(clienteId);
        }
    }
}
