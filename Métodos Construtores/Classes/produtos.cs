using System;

namespace Métodos_Construtores.Classes
{
    public class produtos
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Descricao{get; set;}
        public int Estoque{get; set;}

        public produtos(int codigo, string nome, string descricao,int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }

        

    }
}