using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PhaniResumeAPi.App_Start;

namespace PhaniResumeAPi.DependencyResolution
{
    public static class AutoMapperConfiguration
    {

        public static void Init()
        {
            var container = StructuremapMvc.StructureMapDependencyScope.Container;
            if(container == null) return;
            var profiles = container.GetAllInstances<Profile>();
            var config = new MapperConfiguration(
                cfg =>
                {
                    foreach (var profile in profiles)
                    {
                        cfg.AddProfile(profile);
                    }
                });
            var mapper = config.CreateMapper();
            container.Configure(c=>c.For<IConfigurationProvider>().Use(config));
            container.Configure(c=>c.For<IMapper>().Use(mapper));
        }
    }
}