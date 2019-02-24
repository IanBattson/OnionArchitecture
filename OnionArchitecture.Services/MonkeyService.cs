using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Domain.DataAccess;
using OnionArchitecture.Domain.Models;
using OnionArchitecture.Domain.Services;

namespace OnionArchitecture.Services
{
    public class MonkeyService : IMonkeyService
    {
        private readonly IGetMonkeysQuery getMonkeysQuery;

        public MonkeyService(IGetMonkeysQuery getMonkeysQuery)
        {
            this.getMonkeysQuery = getMonkeysQuery;
        }

        public IEnumerable<MonkeyModel> GetMonkeys()
        {
            return this.getMonkeysQuery
                .GetMonkeys()
                .Select(x => new MonkeyModel {Id = x.Id, Name = x.Name})
                .ToList();
        }
    }
}