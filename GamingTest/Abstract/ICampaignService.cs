using GamingTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTest.Abstract
{
    interface ICampaignService
    {
        void CampaignSave(Campaigns campaigns);
        void CampaignDelete(Campaigns campaigns);
        void CampaignUpdate(Campaigns campaigns);
    }
}
