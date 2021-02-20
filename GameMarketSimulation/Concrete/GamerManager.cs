using GameMarketSimulation.Abstruct;
using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Concrete
{
    class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService) //!
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Save(Gamer gamer) //Sadece kayıt yaparken doğrulama kullandım. Diğerleri kalıtımla otomtik gidiyor:)
        {

            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);

            }
            else
            {
                throw new Exception("Not a valid person");
            }


        }
        
        


    }
}
