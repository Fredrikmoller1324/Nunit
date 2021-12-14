using HouseF.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private Dictionary<string, Type> _houses;

        public HouseFactory()
        {
            _houses = LoadHouses();
        }

        public House BuildHouse(string houseName)
        {
            return GetHouseFromDictionary(houseName);
        }

        private Dictionary<string,Type> LoadHouses()
        {
           var availableTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(House)));

            Dictionary<string, Type> availableHouses = new Dictionary<string, Type>();

            foreach (var t in availableTypes)
            {
                availableHouses.Add(t.Name, t);
            }

            return availableHouses;
        }

        private House GetHouseFromDictionary(string houseName)
        {
            var comparer = StringComparison.OrdinalIgnoreCase;

            Type type = _houses.FirstOrDefault(x => String.Equals(x.Key, houseName,comparer)).Value;
            if (type is null) throw new KeyNotFoundException("Could not find house with name " + houseName);

            return (House)Activator.CreateInstance(type);
        }
    }
}
