using System.Collections.Generic;
using OnionArchitecture.Domain.DataAccess;
using OnionArchitecture.Domain.Dtos;

namespace OnionArchitecture.InMemory
{
    public class GetMonkeysQuery: IGetMonkeysQuery
    {
        public IEnumerable<MonkeyDto> GetMonkeys()
        {
            var m1 = new MonkeyDto()
            {
                Id = 1,
                Name = "One"
            };
            var m2 = new MonkeyDto()
            {
                Id = 2,
                Name = "Two"
            };
            return new List<MonkeyDto> {m1, m2};
        }
    }
}