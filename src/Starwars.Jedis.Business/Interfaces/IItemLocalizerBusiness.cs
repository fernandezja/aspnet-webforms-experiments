using Starwars.Jedis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starwars.Jedis.Business.Interfaces
{
    public interface IItemLocalizerBusiness
    {
        List<ItemLocalizable> List();
        ItemLocalizable GetByEndpoint(string language, string itemEndpoint);
        ItemLocalizable GetByKey(string language, string itemKey);
    }
}
