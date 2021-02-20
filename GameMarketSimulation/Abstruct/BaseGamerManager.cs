using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstruct
{
    public abstract class BaseGamerManager : ICRUDOperation<Gamer>
    {

        public virtual void Save(Gamer gamer) 
        {
            Console.WriteLine("The gamer saved in the system : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The gamer update in the system : " + gamer.FirstName + " " + gamer.LastName);

        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("The gamer deleted in the system : " + gamer.FirstName + " " + gamer.LastName );
        }

        
    }
}
