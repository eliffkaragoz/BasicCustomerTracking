using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstruct
{
    class GameManager : ICRUDOperation<Game>
    {

        public void Save(Game game)
        {
            Console.WriteLine("The game saved in the system : " + game.GameName + " " + game.GamePrice);

        }

        public void Update(Game game)
        {
            Console.WriteLine("The game update in the system : " + game.GameName + " " + game.GamePrice);

        }
        public void Delete(Game game)
        {
            Console.WriteLine("The game delete in the system : " );

        }


    }
}
