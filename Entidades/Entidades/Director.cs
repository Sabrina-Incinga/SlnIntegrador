using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Director")]
	public class Director : Persona
	{
		[Column(TypeName = "varchar"), StringLength(50), Required]
        public string especialidad { get; set; }
		[Column(TypeName = "varchar"), StringLength(50), Required]
		public string matricula { get; set; }
	}
}
