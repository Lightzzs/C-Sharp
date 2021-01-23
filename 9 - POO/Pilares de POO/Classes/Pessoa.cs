using System;

namespace Pilares_de_POO.Classes
{
    public class Pessoa
    {
        public string nome = "Marcos";

        public PessoaFisica pessoaFisica;

        public PessoaJuridica pessoaJuridica;

        public void ExibirNome() {
                Console.WriteLine($"O Nome cadastrado é {this.nome}");
            
        }
    }
}