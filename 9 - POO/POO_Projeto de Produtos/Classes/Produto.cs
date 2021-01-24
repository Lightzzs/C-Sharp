using System;
using System.Collections.Generic;

namespace POO_Projeto_de_Produtos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set;}
        public string NomeCodigo { get; private set; }

        public Marca Marca = new Marca();
        public Usuario CadastradorPor = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();
        private Produto novaProduto;

        public void Cadastrar(){

            Produto novoProduto = new Produto();

            System.Console.WriteLine($"Digite o código do presente: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeCodigo = Console.ReadLine();

            System.Console.WriteLine($"Digite o preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            

            ListaDeProdutos.Add(novaProduto);

        }
        public void Listar(){

        }
        public void Deletar(){

        }
    }
}