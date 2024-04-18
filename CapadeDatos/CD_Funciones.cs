using CapadeDatos.Core;
using CapadeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos
{
    public class CD_Funciones
    {
        Repository<FuncionesModel> _repository;
        public CD_Funciones()
        {
            _repository = new Repository<FuncionesModel>();
        }
        public int FuncionId { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaFuncion { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public bool Estado { get; set; }

        public List<FuncionesModel> TodasLasFunciones()
        {
            return _repository.Consulta().ToList();
        }
        public int Guardar(FuncionesModel funcion)
        {
            funcion.FechaCreacion = DateTime.Now;
            funcion.FechaModificacion = DateTime.Now;
            _repository.Guardar(funcion);

            return 1;
        }
        public int Actualizar(FuncionesModel funcion)
        {
            var funcionInDb = _repository.Consulta().FirstOrDefault(C => C.FuncionId == funcion.FuncionId);

            if (funcionInDb != null)
            {
                funcionInDb.FechaModificacion = DateTime.Now;
                funcionInDb.Nombre = funcion.Nombre;
                funcionInDb.FechaFuncion = funcion.FechaFuncion;
                funcionInDb.HoraInicio = funcion.HoraInicio;
                funcionInDb.HoraFin = funcion.HoraFin;
                funcionInDb.Estado = funcion.Estado;
                _repository.Actualizar(funcionInDb);
                return 1;

            }
            return 0;
        }
        public int Eliminar(int funcionId)
        {
            var funcionInDb = _repository.Consulta().FirstOrDefault(C => C.FuncionId == funcionId);
            if (funcionInDb != null)
            {
                _repository.Eliminar(funcionInDb);
                return 1;
            }
            return 0;
        }
    }
}