using GamingTest.Abstract;
using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Concrate
{
    class CampaignManager : ICampaignService
    {
        public void CampaignDelete(Campaigns campaigns)
        {
            Console.WriteLine("CampaignDelete");
        }

        public void CampaignSave(Campaigns campaigns)
        {
            Console.WriteLine("CampaignSave");
        }

        public void CampaignUpdate(Campaigns campaigns)
        {
            Console.WriteLine("CampaignUpdate");
        }
    }
}
