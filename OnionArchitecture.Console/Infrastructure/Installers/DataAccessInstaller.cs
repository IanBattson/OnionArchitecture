using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace OnionArchitecture.ConsoleApp.Infrastructure.Installers
{
    public class DataAccessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromAssemblyNamed("OnionArchitecture.Dapper")
                                  .Where(type => type.Name.EndsWith("Query"))
                                  .WithService.DefaultInterfaces());
        }
    }
}
