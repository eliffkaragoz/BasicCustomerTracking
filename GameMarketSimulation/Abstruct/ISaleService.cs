using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstruct
{
    interface ISaleService
    {
        void NormalSale(Game game, Gamer gamer);
        void CampaignSale(Game game, Gamer gamer, Campaign campaign);
    }
}
