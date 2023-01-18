using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Paciente")]
    public class Paciente:Persona
    {
        [Column(TypeName = "varchar"), StringLength(500)]
        public string NroHistoriaClinica { get; set; }
    }
}
