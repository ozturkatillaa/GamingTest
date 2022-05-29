using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Abstract
{
    interface IGamerService
  // kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği
    {
        void GamerSave(Gamers gamers);
        void GamerDelete(Gamers gamers);
        void GamerUpdate(Gamers gamers);
    }
}
