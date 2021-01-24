namespace POO_Abstração.Classes
{
    public class Boleto : Pagamento 
    {
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }
        public override string Desconto(int valor)
        {
            return"";
        }

        public override string Juros(int parcelas)
        {
            return "";
        }
    }
}