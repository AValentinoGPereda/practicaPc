using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepasoPC.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Nombre { get; set; }

        [Column("email")]
        public string? CorreoElectronico { get; set; }

        [Column("consulta")]
        public string? Consulta { get; set; }

        [Column("intento")]
        public string? Intento { get; set; }
    }
}