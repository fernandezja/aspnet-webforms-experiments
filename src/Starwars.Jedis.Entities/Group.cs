using System;
using System.Collections.Generic;
using System.Text;

namespace Starwars.Jedis.Entities
{
    public class Group
    {
        public ItemLocalizable ItemLocalizable { get; set; }
        public Jedi Jedi { get; set; }
    }
}
