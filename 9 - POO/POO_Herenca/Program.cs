using System;
using POO_Herenca.Classes;

namespace POO_Herenca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.cpf = "123.456.789-12";

            pf.nome = "Marcos";

            Console.WriteLine( pf.DarBoasVindas(pf.nome));

            Console.WriteLine( pf.ValidarCPF(pf.cpf));
        }
    }
}
