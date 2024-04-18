
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.Modelos
{
    [Table("Clientes")]
    public class ClientesModel : EntidadBase
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(15)]
        public string DNI { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(50)]
        public string Apellidos { get; set; }
        public DateTime FechaCreacion{ get; set; }
        public bool Estado { get; set; }
    }
}

