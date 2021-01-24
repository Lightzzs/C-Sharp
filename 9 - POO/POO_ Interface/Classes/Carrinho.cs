using System;
using System.Collections.Generic;

namespace POO__Interface.Classes
{
    public class Carrinho : ICarrinho
    {
        
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _codigo, Produto produto)
        {
           carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
           carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            foreach (Produto itemCarrinho in carrinho){
                Console.WriteLine($"Produto : {itemCarrinho.Nome} \n Preco: R$ {itemCarrinho.Preco} \n Código: {itemCarrinho.Codigo}");
            }
        }
    }
}