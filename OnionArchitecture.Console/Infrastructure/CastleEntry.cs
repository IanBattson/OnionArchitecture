using Castle.Windsor;
using OnionArchitecture.ConsoleApp.Infrastructure.Installers;

namespace OnionArchitecture.ConsoleApp.Infrastructure
{
    public class CastleEntry
    {
        public static IWindsorContainer Configure()
        {
            IWindsorContainer container = new WindsorContainer();

            container.Install(
                new DataAccessInstaller(),
                new ServicesInstaller());

            return container;
        }
            
    }
}
