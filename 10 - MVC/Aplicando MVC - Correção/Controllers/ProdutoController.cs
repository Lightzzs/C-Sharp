using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        produtoView produtoView = new produtoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();
            produtoView.Listar( );
        }
    }
}