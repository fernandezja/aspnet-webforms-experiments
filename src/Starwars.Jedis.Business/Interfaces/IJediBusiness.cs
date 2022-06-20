using Starwars.Jedis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starwars.Jedis.Business.Interfaces
{
    public interface IJediBusiness
    {
        List<Jedi> List();
        Jedi GetByEndpoint(string jediEndpoint);
        Jedi GetById(int id);
    }
}
