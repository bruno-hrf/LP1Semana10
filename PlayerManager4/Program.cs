using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Player> players = new List<Player>() {new Player("Jonny", 500), new Player ("Macaroni", 600)};
            


            IEnumerable<Player> GetPlayersWithScoreGreaterThan(int score)
            {               
                foreach (Player player in players)
                {
                    if (player.Score>score)
                    {
                        yield return player;
                        
                    }                   
                }               
            }



    
            int score= 0;
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("\n\nMenu:\n1-Inserir jogador(nome e score)\n2-Listar jogadores\n3-Listar jogadores com Score maior que o inserido\n4-Sair");
                
                int opcao= Convert.ToInt32(Console.ReadLine());
                string name;

                

                switch (opcao)
                {
                    
                    case 1:
                    {   
                        
                        Console.WriteLine("Nome do jogador:");
                        name = Console.ReadLine();
                        Console.WriteLine($"Score de {name}:");
                        score = Convert.ToInt32(Console.ReadLine());

                        players.Add(new Player(name, score));
                        
                        players.Sort();
                        break;
                    }

                    case 2:
                    {     
                        Console.WriteLine("\n1-Ordenar  por Score, descrescente\n2-Ordenar por ordem alfabetica Nome\n3-Ordenar por ordem contra-alfabetica ");
                        int opcao2 = Convert.ToInt32(Console.ReadLine());
                        switch (opcao2)
                        {
                            case 1:
                            {
                                foreach (Player player in players) Console.WriteLine($"{player.Name} : {player.Score}");
                                break;
                            }
                            

                        }                  
                        break;
                    }

                    case 3:
                    {                   
                        foreach (Player player in GetPlayersWithScoreGreaterThan(score))
                        {
                            Console.WriteLine($"{player.Name} : {player.Score}");
                        }
                        break;
                    }
                    
                    
                    case 4:
                    {
                        loop = false;
                        break;
                    }                   
                }
                

            }
            
            
        }       
    }
}
