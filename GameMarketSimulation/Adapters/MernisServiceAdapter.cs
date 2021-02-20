using GameMarketSimulation.Abstruct;
using GameMarketSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NatioanalityId), gamer.FirstName.ToUpper() , 
                gamer.LastName.ToUpper() , gamer.DateOfBirth.Year ))).Result.Body.TCKimlikNoDogrulaResult;





        }
    }
}
