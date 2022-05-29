using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckGamerReal(Gamers gamers);
    }
}
