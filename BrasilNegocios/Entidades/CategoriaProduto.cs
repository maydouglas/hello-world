using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrasilNegocios.Entidades
{
    [Table("CategoriaProdutos")]
    public class CategoriaProdutos
    {
        [Key]
        public int IdCategoriaProduto { get; set; }

        [MaxLength(255)]
        public string Categoria { get; set; }

        public int St { get; set; }

        public DateTime Dsy { get; set; }

        public ICollection<Produtos> Produtos { get; set; }
    }
}