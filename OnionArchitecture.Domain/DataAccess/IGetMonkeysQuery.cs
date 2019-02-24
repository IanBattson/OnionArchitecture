using System.Collections.Generic;
using OnionArchitecture.Domain.Dtos;

namespace OnionArchitecture.Domain.DataAccess
{
    public interface IGetMonkeysQuery
    {
        IEnumerable<MonkeyDto> GetMonkeys();
    }
}