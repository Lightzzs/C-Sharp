using System;

namespace PrimeiroPOO
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Personagem jogador1 = new Personagem();
            jogador1.nome = "Yasuo";
            jogador1.idade = 36;
            jogador1.armadura = "Armadura Solar";
            jogador1.IA = "Campeão";




            Personagem jogador2 = new Personagem();
            jogador2.nome = "Veigar";
            jogador2.idade = 22;
            jogador2.armadura = "Rabadon";

            Console.Clear();
            Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.IA} || Jogador 2 IA: {jogador2.IA}");

            int vidaDoJogador2 = jogador2.Defender(jogador1.Atacar2());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O Jogador Foi derrotado");
            }else{
                Console.WriteLine($"Jogador 2 Ficou com {jogador2.vida}");
            }
        }
    }
}