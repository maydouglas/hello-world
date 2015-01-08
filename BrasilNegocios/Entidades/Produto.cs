using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrasilNegocios.Entidades
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        public int IdProduto { get; set; }

        [Required]
        [MaxLength(255)]
        public string Produto { get; set; }

        public Nullable<double> Valor { get; set; }

        public int IdCategoriaProduto { get; set; }

        public int IdFornecedor { get; set; }

        public int St { get; set; }

        public DateTime Dsy { get; set; }

        public virtual CategoriaProdutos categoriaProdutos { get; set; }
    }
}