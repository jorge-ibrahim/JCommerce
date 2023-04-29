﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Dominio.Entidades
{
    public class EntidadBase
    {
        [Key]
        public int Id { get; set; }
        public bool EstaEliminado { get; set; }
        public byte[]? RowVersion { get; set; }
    }
}
