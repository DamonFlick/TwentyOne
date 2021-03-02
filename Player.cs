using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
    
        }

        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool isActivelyPlaying  { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        
         
        // Add Player 
        public static Game operator+ (Game game, Player player)   
        {
            game.Players.Add(player);
            return game;
        }

        // Remove Player
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
