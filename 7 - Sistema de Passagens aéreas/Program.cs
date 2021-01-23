using System;

namespace _26_11___Sistema_de_Passagens_aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
                //Declarações de variaveis
                bool senhaValida;
                int escolha;
                int contador = 0;
                string resposta;

                //Dados Da Passagem
                string [] nomes = new string[5];
                string [] origem = new string[5];
                string [] destino = new string[5];
                string [] data = new string[5];

                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("----Sistema De Passagens---");
                Console.WriteLine("---------------------------");

            //Login
            do
            {
                Console.WriteLine("Digite Sua Senha Para Acessar o Sistema:  ");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);

            //Menu

            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecionar uma opção a baixo");        
                Console.WriteLine("[1] - Cadastrar Passagem");    
                Console.WriteLine("[2] - Listar Passagens");  
                Console.WriteLine("[0] - Sair");  
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                        
                        Console.WriteLine("Cadastrar Passageiro");
                        do
                        {   
                            if(contador <5)
                            {
                            Console.WriteLine($"Digite o nome do {contador+1}º passageiro: ");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o Destino: ");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a Origem: ");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a data do vôo: ");
                            data[contador] = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Limite Excedido");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastra um novo passageiro? s/n");
                            resposta = Console.ReadLine();     
                        } while(resposta == "s");
                        Console.Clear();
                        break;
                        
                    case 2:
                        Console.WriteLine("Listar Passagens");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiros {nomes[i]}, Origem {origem[i]} com Destino para {destino[i]} data do vôo: {data[i]}");
                        }
                            break;

                    case 0:
                        Console.WriteLine("Obrigado Bom Viajar Com a nossa empresa!");
                            break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (escolha !=0);

            Console.WriteLine("Continuando Com o Programa");

            //Funçoes
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    return true;

                }else{
                    Console.WriteLine("Senha Inválida, tente novamente.");
                    return false;
                }
            }
        }
    }
}
