using CalculatorApp.Logic;
using CalculatorApp.Logic.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    internal static class ServiceManager
    {
        public static ServiceProvider CreateServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider(
                new ServiceProviderOptions { ValidateOnBuild = true });
            return serviceProvider;
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton(typeof(ICalculatorService), 
                            typeof(CalculatorService));

            serviceCollection.AddSingleton<Calculator>();
        }
    }
}
