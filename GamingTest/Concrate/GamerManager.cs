using GamingTest.Abstract;
using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Concrate
{
    class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void GamerSave(Gamers gamers)
        {
            if (_gamerCheckService.CheckGamerReal(gamers))
            {
                Console.WriteLine("Gamer Added." + gamers.FirstName);
            }
            else
            {
                Console.WriteLine("Gamer NOT Added" + gamers.FirstName);
            }
        }

        public void GamerDelete(Gamers gamers)
        {
            Console.WriteLine("gamer deleted");
        }

        public void GamerUpdate(Gamers gamers)
        {
            Console.WriteLine("gamer updated");
        }


    }
}
