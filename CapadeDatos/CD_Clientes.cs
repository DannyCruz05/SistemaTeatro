using CapadeDatos.Core;
using CapadeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapadeDatos.CD_Clientes;

namespace CapadeDatos
{
    public class CD_Clientes
    {
        Repository<ClientesModel> _repository;
        public CD_Clientes()
        {
            _repository = new Repository<ClientesModel>();
        }
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }

        public List<ClientesModel> TodosLosClientes()
        {
            return _repository.Consulta().ToList();
        }
        public int Guardar(ClientesModel cliente)
        {
            cliente.FechaCreacion = DateTime.Now;
            cliente.FechaModificacion = DateTime.Now;
            _repository.Guardar(cliente);

            return 1;
        }
        public int Actualizar(ClientesModel cliente)
        {
            var clienteInDb = _repository.Consulta().FirstOrDefault(C => C.ClienteId == cliente.ClienteId);

            if (clienteInDb != null)
            {
                clienteInDb.FechaModificacion = DateTime.Now;
                clienteInDb.Codigo = cliente.Codigo;
                clienteInDb.DNI = cliente.DNI;
                clienteInDb.Nombres = cliente.Nombres;
                clienteInDb.Apellidos = cliente.Apellidos;
                clienteInDb.FechaCreacion = cliente.FechaCreacion;
                clienteInDb.Estado = cliente.Estado;
                _repository.Actualizar(clienteInDb);
                return 1;

            }
            return 0;
        }
        public int Eliminar(int clienteId)
        {
            var clienteInDb = _repository.Consulta().FirstOrDefault(C => C.ClienteId == clienteId);
            if (clienteInDb != null)
            {
                _repository.Eliminar(clienteInDb);
                return 1;
            }
            return 0;
        }

    }
}