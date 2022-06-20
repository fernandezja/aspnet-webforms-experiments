using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Starwars.Jedis.Business
{
    public class BusinessAutofacModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(typeof(JediBusiness).GetTypeInfo().Assembly)
               .Where(t => t.Name.EndsWith("Business"))
               .AsImplementedInterfaces()
               .InstancePerDependency();

            builder.RegisterType<JediFactory>()
                .InstancePerDependency();
        }
    }
}
