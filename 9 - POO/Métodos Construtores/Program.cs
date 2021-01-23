using System;

namespace Métodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            string nome;
            string descricao;
            int estoque;

            Console.WriteLine("Cadastro de produtos");

            Console.WriteLine("Codigo de produto: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("Descrição do produto: ");
            descricao = Console.ReadLine();

            Console.Write("Quantidade no estoque: ");
            estoque = int.Parse(Console.ReadLine());

            produtos produto1 = new produtos(codigo, nome, descricao, estoque);

            Console.WriteLine("\nInformações do produto:");
            Console.WriteLine("");
            Console.WriteLine($"Código: {produto1.Codigo}");
            Console.WriteLine($"Nome: {produto1.Nome}");
            Console.WriteLine($"Descrição: {produto1.Descricao}");
            Console.WriteLine($"Estoque: {produto1.Estoque}");
            Console.WriteLine("");
        }
    }
}
