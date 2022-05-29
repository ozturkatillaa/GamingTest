using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Abstract
{
    interface IGameService

    {
        void SellGame(Games game, Gamers gamers);
        void SellGame(List<Games> games, Gamers gamers);
        void SellGame(Games games, Gamers gamers, Campaigns campaigns);
        

    }
}
