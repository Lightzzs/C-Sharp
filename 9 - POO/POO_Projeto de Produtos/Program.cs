using System;
using POO_Projeto_de_Produtos.Classes;

namespace POO_Projeto_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario user = new Usuario();
            Console.WriteLine(user.Nome);

            Usuario user2 = new Usuario(2, "Marcos", "marcos@marcos.com", "098765");
            Console.WriteLine(user2.Email);
        }
    }
}
