namespace Sitecore.Support.XA.Foundation.IoC.ServiceCollection
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.DependencyInjection;
  using Sitecore.XA.Feature.Navigation.Repositories.LinkList;

  public class RegisterSupportLinkListRepository : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddTransient<ILinkListRepository, Sitecore.Support.XA.Feature.Navigation.Repositories.LinkList.LinkListRepository>();
    }
  }
}