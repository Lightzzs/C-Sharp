using System;
using Polimorfismo___Sobrecarga_de_métodos_.Classes;

namespace Polimorfismo___Sobrecarga_de_métodos__overload_.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Paulo");
            fun.Mostrar(2);

            Console.Beep(900, 5000);
        }
    }
}
