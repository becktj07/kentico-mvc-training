using Business.Services.Context;

namespace Business.DependencyInjection
{
    public interface IBusinessDependencies
    {
        ISiteContextService SiteContextService { get; }
    }
}
