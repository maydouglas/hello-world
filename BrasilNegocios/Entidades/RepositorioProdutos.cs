using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrasilNegocios.Entidades
{
    public class RepositorioProdutos
    {
        BdContext bdcontext = new BdContext();

        public List<Produtos> GetProdutos()
        {
            return bdcontext.Products.ToList();
        }

        public void InsertProdutos(Produtos produtos)
        {
            bdcontext.Products.Add(produtos);
            bdcontext.SaveChanges();
        }

        public void UpdateProdutos(Produtos produtos)
        {
            Produtos produtosToUpdate = bdcontext.Products.FirstOrDefault(x => x.IdProduto == produtos.IdProduto);
            produtosToUpdate.Produto = produtos.Produto;
            produtosToUpdate.Valor = produtos.Valor;
            produtosToUpdate.IdCategoriaProduto = produtos.IdCategoriaProduto;
            produtosToUpdate.IdFornecedor = produtos.IdFornecedor;
            produtosToUpdate.St = produtos.St;
            produtosToUpdate.Dsy = produtos.Dsy;
            bdcontext.SaveChanges();
        }

        public void DeleteProdutos(Produtos produtos)
        {
            Produtos produtosToDelete = bdcontext.Products.FirstOrDefault(x => x.IdProduto == produtos.IdProduto);
            bdcontext.Products.Remove(produtosToDelete);
            bdcontext.SaveChanges();
        }
    }
}