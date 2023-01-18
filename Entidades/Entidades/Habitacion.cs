using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Habitacion")]
    public class Habitacion  
    {
        public int Id { get; set; }
        [Range(1, 500),Required]
        public int Numero { get; set; }
        [Column(TypeName = "varchar"), StringLength(100), Required]
        public string Estado { get; set; }



    }
}
