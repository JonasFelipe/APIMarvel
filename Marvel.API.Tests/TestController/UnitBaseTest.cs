using Marvel.Domain.Abstration.Repository.Base;
using Marvel.Ioc;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Marvel.API.Tests.TestController
{
    public abstract class UnitBaseTest
    {
        protected IServiceProvider provider;

        public UnitBaseTest()
        {
            Initialize();

        }

        public ServiceCollection collection { get; private set; }

        private void Initialize()
        {
            collection = new ServiceCollection();
            new RootBootstrapper().RootRegisterServices(collection);

            var repositoriesToSubstiture = new List<ServiceDescriptor>();
            foreach (var serviceDescriptor in collection)
            {
                var info = serviceDescriptor.ServiceType.GetTypeInfo();

                if (info.ImplementedInterfaces.Contains(typeof(IRepositoryBase)))
                    repositoriesToSubstiture.Add(serviceDescriptor);
            }

            foreach (var item in repositoriesToSubstiture)
            {
                collection.Remove(item);
                collection.AddScoped(item.ServiceType, x => Substitute.For(new Type[] { item.ServiceType }, null));
            }
        }


        protected T InstanceOf<T>()
        {
            return provider.GetService<T>();
        }

        protected T InstanceOf<T>(Type type)
        {
            return (T)provider.GetService(type);
        }


        protected void OverrideRegistration<T>(Func<IServiceProvider, T> expression) where T : class
        {

            collection.Remove(collection.FirstOrDefault(x => x.ImplementationType == typeof(T)));
            collection.AddScoped<T>(expression);
            provider = collection.BuildServiceProvider();
        }
    }
}