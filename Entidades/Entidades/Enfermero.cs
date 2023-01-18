using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Enfermero")]
	public class Enfermero : Persona 
	{
		[Column(TypeName = "varchar"), StringLength(50), Required]
		public string cuil { get; set; }
	}
}
