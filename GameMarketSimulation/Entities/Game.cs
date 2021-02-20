using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GamePrice { get; set; }
    }
}
