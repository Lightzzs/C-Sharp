using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            string senha;

            while(true){
            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            if(email == senha){

            Console.WriteLine("Sua senha nao pode ser igual seu email!!");
            }else{break;}

            }
            Console.WriteLine("Seu cadastro foi efetuado com sucesso!!");
        }
    }
}
