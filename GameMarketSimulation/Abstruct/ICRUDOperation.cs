using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstruct
{
    interface ICRUDOperation<TEntity>
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
