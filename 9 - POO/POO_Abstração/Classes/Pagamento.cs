using System;

namespace POO_Abstração.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;
        public string Cancelar(){
            return "";
        }
        public abstract string Desconto(int valor);
        public abstract string Juros(int parcelas);
    }
}