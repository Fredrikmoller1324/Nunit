using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class BudgetHouse : House
    {
        public BudgetHouse()
        {
            NoOfWindows = 2;
            NoOfRooms = 2;
            HasSwimmingPool = false;
            ParkingSpotsInGarage = 0;
            StreetAdress = "BudgetStreet 1";
        }
    }
}
