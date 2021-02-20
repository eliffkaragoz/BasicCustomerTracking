using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstruct
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
