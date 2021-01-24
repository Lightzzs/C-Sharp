using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoViews
    {
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Codigo : {item.Codigo}");
                Console.WriteLine($"Produto : {item.Nome}");
                Console.WriteLine($"Preco : R$ {item.Preco}");
            }
        }
    }
}