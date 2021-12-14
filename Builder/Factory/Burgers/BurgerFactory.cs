using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Burgers
{
    public class BurgerFactory
    {
        private Dictionary<string, Type> _burgers;

        public BurgerFactory()
        {
            _burgers = LoadBurgerByReflektion();
        }

        public Burger CreateBurger(string burgerName)
        {

            return GetBurgerFromDictionary(burgerName.ToLower());
        }

        private Burger GetBurgerFromDictionary(string burgerName)
        {
            Type type = _burgers[burgerName];
            if (type is null) throw new Exception("Can't find burger");

            return (Burger)Activator.CreateInstance(type);
        }
        //private Dictionary<string, Type> LoadBurgers()
        //{
        //    Dictionary<string, Type> AvailableBurgers = new Dictionary<string, Type>();

        //    AvailableBurgers.Add("cheeseburger", typeof(CheeseBurger));
        //    AvailableBurgers.Add("plainburger", typeof(PlainBurger));
        //    AvailableBurgers.Add("superdeluxeburger", typeof(SuperDeluxeBurger));

        //    return AvailableBurgers;
        //}

        private Dictionary<string, Type> LoadBurgerByReflektion()
        {
            var availableTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(Burger)));

            Dictionary<string, Type> availableBurgers = new Dictionary<string, Type>();

            foreach (Type t in availableTypes)
            {
                availableBurgers.Add(t.Name.ToLower(), t);
            }

            return availableBurgers;
        }
    }
}
