using System;

namespace POO_Encapsulamento.Classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;
        
        
        public void ExibirLimite(){
            Console.WriteLine(this.limite);
        }
    }
}