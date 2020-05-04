using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace MedioClinic
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(IApplicationBuilder builder)
        {
            // Enable required Kentico features

            // Uncomment the following to use the Page builder feature
            builder.UsePreview();
            builder.UsePageBuilder();

            builder.UsePageRouting(new PageRoutingOptions
            {
                EnableAlternativeUrls = true
            });
        }
    }
}