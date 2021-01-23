using System;

namespace CalculadoraSimplesTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pergunta a operação
            Console.WriteLine("Qual a operação deseja realizar? \nSoma, Subtracao, Multiplicao, Divisao");
            string operacao = Console.ReadLine().ToLower();

            // Pedir o 1º numero
            Console.WriteLine("Digite o 1º numero: ");
            float num1 = float.Parse(Console.ReadLine());

            // Pedir o 2º 
            Console.WriteLine("Digite o 2º numero: ");
            float num2 = float.Parse(Console.ReadLine());

            // Fazer o cálculo
            float resultado = 0;
        
            // if(operacao == "Soma")
            // {
            //     resultado = num1 + num2;
            // }
            // else if(operacao == "Subtracao")
            // {
            //     resultado = num1 - num2;   
            // }
            // else if(operacao == "Multiplicao")
            // {
            //     resultado = num1 * num2;
            // } 
            // else if(operacao == "Divisao")
            // { 
            //     resultado = num1 / num2;
            // }
            // else{
            //     Console.WriteLine("Operação Inválida");
            // }

            switch(operacao){

                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtracao":
                    resultado = num1 - num2;
                    break;

                case "multiplicacao":
                    resultado = num1 * num2;
                    break;

                case "divisao":
                    resultado = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Operação Inválida! :(");
                    break;
            }

            // Mostrar o resultado

            //Concatenação
            //Console.WriteLine("Calculo :"+ num1 +" com "+ num2 +" ="+ resultado);

            // Interpolação
            Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}");

        }
    }
}
