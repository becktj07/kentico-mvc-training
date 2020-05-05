using Business.Services.Context;

namespace Business.DependencyInjection
{
    public class BusinessDependencies : IBusinessDependencies
    {
        public ISiteContextService SiteContextService { get; }

        public BusinessDependencies(
            ISiteContextService siteContextService
            )
        {
            SiteContextService = siteContextService;
        }
    }
}
