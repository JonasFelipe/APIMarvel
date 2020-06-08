using Marvel.Ioc.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Ioc
{
    public class RootBootstrapper
    {
        public void RootRegisterServices(IServiceCollection services)
        {
            new AbstrationServiceBootstrapper().ChildServiceRegister(services);
        }
    }
}
