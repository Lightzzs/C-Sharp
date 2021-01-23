using System;

namespace _17_11___Laços_while__do_while___for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja ver a tabuada de qual numero?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 0; contador <= 10; contador++)
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
            }


            // do
            // {
            //     // Executado pelo menos uma vez
            //     Console.WriteLine("Bom Dia!");

            //     Console.WriteLine("Ainda deseja receber um bom dia? ");

            //     numeroDeVezes++;

            //     resposta = Console.ReadLine();

            // } while(resposta == "Sim");

            // while(resposta == "Sim") {
            //     // Executando quando condição é verdadeira
            //     Console.WriteLine("Bom Dia!!");

            //     // numeroDeVezes = numeroDeVezes + 1;
            //     numeroDeVezes++;

            //     Console.WriteLine("Ainda deseja receber um bom dia?");
            //     resposta = Console.ReadLine();
            // }

            // Console.WriteLine($"Numero de vezes: {numeroDeVezes}");
            //  Console.WriteLine("Fim Da Programação!");
        }
    }
}
