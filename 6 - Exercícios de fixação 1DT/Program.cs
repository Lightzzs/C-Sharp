using System;

namespace _23_11___Exercícios_de_fixação_1DT
{
    class Program
    {
        static float CalcularMedia( float[] numeros){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                // Soma = soma + numeros[i]
                soma += numeros[i];
            };

            float resultado = soma / numeros.Length;

            return resultado;
        }
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            float[] medias = new float[7];
            float[] notas = new float[4];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite os nomes dos alunos: ");
                nomes[i] = Console.ReadLine();

                for (int n = 0; n < notas.Length; n++)
                {
                    Console.WriteLine("Digite a "+(n+1)+"º nota: ");
                    notas[n] = float.Parse(Console.ReadLine());
                }    

                medias[i] = CalcularMedia(notas);
            }
            

            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

                Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome: {nomes[i]} Média: {medias[i]}");
            }

            Console.ResetColor();

        }
    }
}
