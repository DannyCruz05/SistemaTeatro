using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.Modelos
{
    [Table("Reservaciones")]
    public class ReservacionesModel:EntidadBase
    {
        [Key]
        public int ReservacionId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int FuncionesId { get; set; }
        [Required]
        public string Asiento { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public decimal PagoReserva { get; set; }
        public bool Estado { get; set; }
    }
}
