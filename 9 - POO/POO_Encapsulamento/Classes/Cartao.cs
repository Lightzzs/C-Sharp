using System;

namespace POO_Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{ 
            get{return numero;}
            set{numero = value;}
        }
        private string nomeTitular;
        public string NomeTitular{
            get{return numero;}
            set{numero = value;}
        }
        private string bandeira;
        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        protected string token = "qwertyui";
        public string Token{ 
            get{return token;}
            set{token = value;}
        }
        private string cvv;
        public string Cvv{get;set;}
        
        protected float limite = 5000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

        public string RegistrarComprar(bool validado) {
            return "";
        }
        public string ReceberNome(string nomeDigitado){
            return this.nomeTitular = nomeDigitado;
        }
        public void ExibirNome(){
           Console.WriteLine(nomeTitular);
        }
    }
}