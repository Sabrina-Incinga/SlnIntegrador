using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Medico")]
    public class Medico:Persona
    {
        [Column(TypeName = "varchar"), StringLength(100), Required]
        public string Especialidad { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Matricula { get; set; }

        public List <Paciente> Pacientes { get; set; }
    }
}
