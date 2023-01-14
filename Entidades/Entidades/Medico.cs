using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Medico:Persona
    {
        /*
         Id
        Nombre
        Apellido
        Domicilio
        Telefono
        Email
        Especialidad
        Matricula
         */

        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }
}
