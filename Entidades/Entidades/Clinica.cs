﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Clinica")]
    public class Clinica 
    {
        public int Id { get; set; }
        [Column(TypeName ="varchar"), StringLength(50), Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar"), StringLength(150), Required]
        public string Domicilio { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar"), StringLength(100)]
        public string Email { get; set; }



    }
}
