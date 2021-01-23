using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estadocivil;

            do{
                Console.WriteLine("Insira seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Insira sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu salario: ");
                salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Insira seu estado civil: s - solteira; c - casado; v - viuva; d - divorciado");
                estadocivil = Console.ReadLine();

            if(nome == ""){Console.WriteLine("Insire um nome valido!");}

            if(idade <0 || idade >100){Console.WriteLine("Insira uma idade valida!");}

            if(salario == 0){Console.WriteLine("Insira um valor valido");}

            if(estadocivil == "s" || estadocivil == "c" || estadocivil == "v" || estadocivil == "d"){}

            else{
                Console.WriteLine("Defina um estadocivi valido!");
                estadocivil = "";
                }
            }while(nome == "" || idade == 1 || salario == 0 || estadocivil == "");
                Console.WriteLine("Confirme Seus Dados: ");
                Console.WriteLine("Nome: + nome");
                Console.WriteLine("Idade: + idade");
                Console.WriteLine("Salario: + salario");
                Console.WriteLine("Estado Civil + estadoCivil");

                Console.WriteLine("Validação Aprovada Com sucesso");   
        }
    }
}
