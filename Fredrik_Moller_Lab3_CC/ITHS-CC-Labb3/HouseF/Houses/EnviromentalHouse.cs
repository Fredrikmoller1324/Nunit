using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class EnviromentalHouse : House
    {
        public EnviromentalHouse()
        {
            NoOfWindows = 6;
            NoOfRooms = 2;
            HasSwimmingPool = false;
            ParkingSpotsInGarage = 1;
            StreetAdress = "EnviromentStreet 1";
        }
    }
}
