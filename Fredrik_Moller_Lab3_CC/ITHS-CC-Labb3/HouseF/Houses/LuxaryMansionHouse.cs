using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class LuxaryMansionHouse : House
    {
        public LuxaryMansionHouse()
        {
            NoOfWindows = 20;
            NoOfRooms = 10;
            HasSwimmingPool = true;
            ParkingSpotsInGarage = 4;
            StreetAdress = "RichStreet 1";
        }
    }
}
