using System;

namespace Polimorfismo___Sobrecarga_de_métodos_.Classes
{
    public class Funcionario
    {
        public string[] lista = { "Marcos, Vinicius, Silva, Jesus" };

        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int indice)
        {
            Console.WriteLine( "Busca por índice : " + lista[indice]);
        }
            public void Mostrar(string busca)
            {
                    foreach (var item in lista)
            { 
                if (item == busca){
                    Console.WriteLine("Resultado da busca : " + item);
                }  
            }
        }
        
    }
}