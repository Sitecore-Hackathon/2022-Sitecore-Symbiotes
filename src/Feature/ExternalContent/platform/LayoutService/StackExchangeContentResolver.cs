//using Mvp.Feature.abc.Services;
using Mvp.Feature.ExternalContent.Services;
using Newtonsoft.Json.Linq;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;

namespace Mvp.Feature.ExternalContent.LayoutService
{
    public class StackExchangeContentResolver : RenderingContentsResolver
    {
        private readonly IStackExchangeAPIService _stackExchangeAPIService;

        public StackExchangeContentResolver(IStackExchangeAPIService stackExchangeAPIService)
        {
            this._stackExchangeAPIService = stackExchangeAPIService;
        }

        public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {
            object obj= _stackExchangeAPIService.GetstackExchangeUsers();
            return obj;


        }

        
    }
}