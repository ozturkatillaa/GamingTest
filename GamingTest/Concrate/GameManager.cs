using GamingTest.Abstract;
using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Concrate
{
    class GameManager : IGameService
    {
        public void SellGame(Games game, Gamers gamers)
        {
            Console.WriteLine(gamers.FirstName + "bought Game" + game.GameName);
        }

        public void SellGame(List<Games> games, Gamers gamers)
        {
            
            foreach (Games game in games)
            {
                Console.WriteLine(game.GameName + "has a new owner");
            }

            Console.WriteLine(gamers.FirstName + "bought the game" );
        }



        public void SellGame(Games games, Gamers gamers, Campaigns campaigns)
        {
            Console.WriteLine("Game Name:" + games.GameName + "  " + "Player Name: " + gamers.FirstName + "Campaigns Name: " + campaigns.CampaignName);
        }
    }
}
