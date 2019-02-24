using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OnionArchitecture.Domain.Services;
using OnionArchitecture.Services;

namespace OnionArchitecture.ConsoleApp.Infrastructure.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IMonkeyService>().ImplementedBy<MonkeyService>());
        }
    }
}
