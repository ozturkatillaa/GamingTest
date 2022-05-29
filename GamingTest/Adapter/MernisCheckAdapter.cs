using GamingTest.Abstract;
using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingTest.MernisCheck;

namespace GamingTest.Adapter
{
    class MernisCheckAdapter : IGamerCheckService
    {
        public bool CheckGamerReal(Gamers gamers)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamers.NationalityId),
                gamers.FirstName.ToUpper(), gamers.LastName.ToUpper(),
                gamers.DateOfBirth.Year);
        }
    }
}
