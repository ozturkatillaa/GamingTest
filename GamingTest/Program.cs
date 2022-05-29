using GamingTest.Abstract;
using GamingTest.Adapter;
using GamingTest.Concrate;
using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers gamer1 = new Gamers() { Id = 1, FirstName = "PINAR", LastName = "ÖZTÜRK", NationalityId = "30190536096", DateOfBirth = new DateTime(2002, 4, 27) };

            Games game = new Games() { GameId = 1, GameName = "GTA5", GameKind = "Real Life" };
            Games game2 = new Games() { GameId = 1, GameName = "CallUfDuty", GameKind = "Action" };

            GamerManager register = new GamerManager(new MernisCheckAdapter()) ;
            register.GamerSave(gamer1);

            List<Games> games = new List<Games> { game, game2 };

            IGameService sell = new GameManager();
            sell.SellGame(games, gamer1);

            //// --------------------------

            Campaigns today = new Campaigns();
            today.CampaignName = "YılbasiOzel";

            ICampaignService kampanya = new CampaignManager();
            kampanya.CampaignSave(today);

            sell.SellGame(game2, gamer1, today);

            Console.ReadLine();
        }
    }
}
