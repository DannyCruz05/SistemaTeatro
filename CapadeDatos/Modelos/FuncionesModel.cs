using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.Modelos
{
    [Table("Funciones")]
    public class FuncionesModel:EntidadBase
    {
        [Key]
        public int FuncionId { get; set; }
        [Required]
        [MaxLength(70)]
        public string Nombre { get; set; }
        [Required]
        public DateOnly FechaFuncion{ get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin{ get; set; }
        public bool Estado { get; set; }
    }
}
