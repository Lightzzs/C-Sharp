using System;
using POO_Encapsulamento.Classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao m = new Cartao();

            m.NomeTitular = "Marcos Vinicius Silva De Jesus";

            m.Numero = "12345678";

            m.Bandeira = "MasterCard";

            m.Token = "12312415";

            Console.WriteLine($"O Títular {m.NomeTitular} - Token {m.Token}");

            
        }
    }
}
