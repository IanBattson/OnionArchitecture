using System;
using OnionArchitecture.ConsoleApp.Infrastructure;
using OnionArchitecture.Domain.Services;

namespace OnionArchitecture.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = CastleEntry.Configure();

            var monkeyService = container.Resolve<IMonkeyService>();

            var monkeys = monkeyService.GetMonkeys();

            foreach (var m in monkeys)
            {
                Console.WriteLine(string.Format("{0} - {1}", m.Id, m.Name));
            }

            System.Console.ReadLine();
        }
    }
}
