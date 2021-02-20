using GameMarketSimulation.Abstruct;
using GameMarketSimulation.Adapters;
using GameMarketSimulation.Concrete;
using GameMarketSimulation.Entities;
using System;

namespace GameMarketSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer = new Gamer { DateOfBirth = new DateTime(2000, 2, 14), FirstName = "Elif", LastName = "Karagöz", NatioanalityId = "43597864310" };
           
            gamerManager.Save(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Console.WriteLine("------------------------");

            GameManager gameManager = new GameManager();
            Game game = new Game { GameName = "Cyberpunk", GamePrice = "325" };
            gameManager.Save(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            Console.WriteLine("------------------------");

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { CampaignName = "Bayram Kampanyası", CampaignRate = "%50" };
            campaignManager.Save(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine("------------------------");

            SaleManager saleManager = new SaleManager();
            saleManager.NormalSale(game, gamer);
            saleManager.CampaignSale(game, gamer, campaign);

            Console.ReadLine();
        }
    }
}
