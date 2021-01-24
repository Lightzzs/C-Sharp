using System;

namespace Celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;


        public bool ligacoes;
        public bool desligado;
        public bool mensagens;


        public void ligar(bool ligado) {
            if(ligado == true){
                Console.WriteLine($"O Celular está ligado");
            }else{
                Console.WriteLine($"O Celular está desligado!");

            }
        }
        public void desligar(bool desligado) {
            if(desligado == true) {
                Console.WriteLine($"O Celular está ligado");
            }else{
                Console.WriteLine($"O Celular está desligado!");
            }
        }
        public void Mensagem(bool mensagem) {
            if(mensagem == true) {
                Console.WriteLine("Escreva sua mensagem: ");
                string mensagens = Console.ReadLine();
                Console.WriteLine("Mensagem Enviada Com Sucesso");
            }else{
                Console.WriteLine("Mensagem Não Enviada, Tente Novamente!");
            }
        }
        public void Ligacoes(bool ligacoes) {
            if(mensagens == true){ 
                Console.WriteLine("Pra quem deseja ligar: ");
            string quem = Console.ReadLine();
            Console.WriteLine("Ligando...");
            Console.WriteLine($"... {quem} recusou a ligação, grave uma mensagem ou você será tarifado após o sinal...");

                }else{
                    Console.WriteLine("Tente novamente mais tarde!");
            }
        }
    }
}