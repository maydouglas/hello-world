﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrasilNegocios.Entidades
{
    [Table("Testes")]
    public class Teste
    {
        [Key]
        public int ITeste { get; set; }
    }
}