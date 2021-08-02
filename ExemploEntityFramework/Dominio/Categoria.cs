﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Dominio
{
    class Categoria
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
