using System;

namespace _19_11___Vetores__arrays__e_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"maçã", "batata", "cenoura"};
            double[] precos = {1.1, 2.3, 4.5};
            int[] idades = {16, 17, 17};

            int tamanho = 15;

            string[] nomesalunos = new string[tamanho];

            //Console.WriteLine(produtos[1]);

            //Console.WriteLine("Trocar batata por qual item?");

            //produtos[1] = Console.ReadLine();

            //Console.WriteLine(produtos[1]);

            for (int i = 0; i <precos.Length; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(precos[i]);
        }

        }
    }
}
