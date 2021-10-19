using System.Collections.Generic;
using System.Linq;
using PS.Domain;

namespace PS.Service
{
    public class ManagerProvider
    {
        public IList<Provider> providers { get; set; }
        public IList<Provider>GetProviderByName(string name)
        {
            return (IList<Provider>)(from p in providers where p.UserName.Contains(name) select p);
        }
        public Provider GetFirstProviderByName(string name)
        {
            var query = from provider in providers
                where provider.UserName.StartsWith(name)
                select provider;

            return query.FirstOrDefault();
        }

        public Provider GetProviderById(int id)
        {
            var query = from provider in providers
                where provider.Id == id
                select provider;

            return query.FirstOrDefault();
        }
    }
}