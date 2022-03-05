using Mvp.Feature.ExternalContent.Models;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Mvp.Feature.ExternalContent.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureExternalContent(this RenderingEngineOptions options)
        {
            options.AddModelBoundView<StackExchangeUsers>("StackExchangeUsers");

            return options;
        }
    }
}