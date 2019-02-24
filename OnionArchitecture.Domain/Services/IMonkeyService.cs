using System.Collections.Generic;
using OnionArchitecture.Domain.Models;

namespace OnionArchitecture.Domain.Services
{
    public interface IMonkeyService
    {
        IEnumerable<MonkeyModel> GetMonkeys();
    }
}