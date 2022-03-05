using Microsoft.Extensions.DependencyInjection;
using Mvp.Feature.ExternalContent.Services;
using Sitecore.DependencyInjection;


namespace Mvp.Feature.ExternalContent
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IStackExchangeAPIService, StackExchangeAPIService>();
        }
    }
}