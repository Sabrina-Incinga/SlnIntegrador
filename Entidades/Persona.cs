﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar"), StringLength(150), Required]
        public string Domicilio { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar"), StringLength(100), Required]
        public string Email { get; set; }

    }
}
