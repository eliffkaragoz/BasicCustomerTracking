using GameMarketSimulation.Abstruct;
using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Concrete
{
    class SaleManager : ISaleService
    {
        public void NormalSale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + "," + gamer.FirstName + "tarafından satın alındı.. " );
        }
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + "," + gamer.FirstName + "tarafından "+  campaign.CampaignRate + "kampanyası ile satın alındı.. " );

        }


    }
}
