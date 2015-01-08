using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BrasilNegocios.Entidades
{
    public class BdContext : DbContext
    {
        public BdContext()
            : base("name=TesteBenner")
        {
            Database.SetInitializer<BdContext>(new CreateDatabaseIfNotExists<BdContext>());
        }
        
        public DbSet<Produtos> Products { get; set; }
        public DbSet<CategoriaProdutos> ProductCategories { get; set; }
        public DbSet<Teste> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>().MapToStoredProcedures(
                p => p.Insert(i => i.HasName("Insere_Produtos")
                    .Parameter(n => n.Produto,"PRODUTO")
                    .Parameter(n=> n.Valor,"VLR")
                    .Parameter(n=> n.St,"ATIVO")
                    .Parameter(n=> n.IdCategoriaProduto,"CATEGORIA")
                    .Parameter(n=> n.IdFornecedor,"FORNECEDOR")
                    .Parameter(n=> n.Dsy,"DATA_CADASTRO"))
                .Update(i => i.HasName("Atualiza_Produtos").Parameter(n => n.IdProduto,"ID_PRODUTO")
                    .Parameter(n => n.Produto,"PRODUTO")
                    .Parameter(n=> n.Valor,"VLR")
                    .Parameter(n=> n.St,"ATIVO")
                    .Parameter(n=> n.IdCategoriaProduto,"CATEGORIA")
                    .Parameter(n=> n.IdFornecedor,"FORNECEDOR")
                    .Parameter(n=> n.Dsy,"DATA_CADASTRO"))
                .Delete(i => i.HasName("Deleta_Produtos").Parameter(n => n.IdProduto,"ID_PRODUTO")));
            base.OnModelCreating(modelBuilder);
        }
    }
}