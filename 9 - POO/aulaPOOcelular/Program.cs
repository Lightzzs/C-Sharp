using System;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            string escolha;

            do
            {
                Console.Clear();
                Console.WriteLine("O celular está ligado: ");
                escolha = Console.ReadLine();

                if(escolha.ToLower() == "s") {
                    celular1.ligado = true;

                    Console.WriteLine("Digite a cor do aparelho: ");
                    celular1.cor = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do aparelho: ");
                    celular1.modelo = Console.ReadLine();

                    Console.WriteLine("Digite o tamanho do aparelho: ");
                    celular1.tamanho = Console.ReadLine();

                    Console.WriteLine("Deseja enviar alguma mensagem?");
                    string resposta = Console.ReadLine();

                    if(resposta.ToLower() == "s") {
                        celular1.mensagens = true;

                    }else{
                        celular1.mensagens = false;
                        celular1.Mensagem(celular1.mensagens);
                    }

                    Console.Write("Deseja fazer uma ligação? ");
                    string resposta2 = Console.ReadLine();                 
                    if(resposta2.ToLower() == "s") {
                        celular1.ligacoes = true;
                        celular1.Ligacoes(celular1.ligacoes);
                    }else{
                        celular1.ligacoes = false;
                        celular1.Ligacoes(celular1.ligacoes);
                    }
                    Console.Clear();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Informaçoes Do Aparelho");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("                       ");
                    Console.WriteLine("Cor Do Aparelho: " + celular1.cor);
                    Console.WriteLine("Modelo Do Aparelho: " + celular1.modelo);
                    Console.WriteLine("Tamanho Do Aparelho: "+ celular1.tamanho);
                    break;

                }else{
                    Console.WriteLine("Fechando Sistema");
                }

            }while (escolha.ToLower() == "s");

        }
    }
}
