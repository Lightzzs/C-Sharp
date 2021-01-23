namespace POO_Herenca.Classes
{
    public class PessoaJuridica
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento)
        {
            if(documento !=""){
                return(true);
            }
            return(false);
        }
    }
}