using GameMarketSimulation.Abstruct;
using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Concrete
{
    class CampaignManager : ICRUDOperation<Campaign>
    {
        public void Save(Campaign campaign)
        {
            Console.WriteLine("The campaign saved : "  + campaign.CampaignName);

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The campaign update ");

        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("The campaign delete ");
        }

        
    }
}
