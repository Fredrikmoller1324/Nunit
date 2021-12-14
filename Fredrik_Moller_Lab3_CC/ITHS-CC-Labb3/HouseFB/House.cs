using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class House
    {
        public int NoOfRooms { get; set; } = 1;

        public int NoOfWindows { get; set; } = 0;

        /// <summary>This field includes the street name and the street number</summary>
        public string StreetAdress { get; set; }

        public bool HasSwimmingPool { get; set; }

        public int ParkingSpotsInGarage { get; set; }

        public bool HasGarage => ParkingSpotsInGarage > 0;

        public static HouseBuilder Builder => new HouseBuilder();

        private House() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"This house is located at {StreetAdress}.");
            sb.AppendLine($"It has {NoOfRooms} rooms and {NoOfWindows} windows");
            if (HasSwimmingPool & HasGarage)
            {
                sb.Append($"It is very fancy and have both a swimming pool, and a garage with place for {ParkingSpotsInGarage} car");
                if (ParkingSpotsInGarage > 1)
                {
                    sb.Append("s");
                }
                sb.AppendLine(".");
            }
            else if (HasSwimmingPool)
            {
                sb.AppendLine("It has a nice swimming pool");
            }
            else if (HasGarage)
            {
                sb.AppendLine($"It has a garage with place for {ParkingSpotsInGarage} cars");
            }
            return sb.ToString();
        }

        public class HouseBuilder
        {
            private House _house;
            public HouseBuilder()
            {
                _house = new House();
            }

            public HouseBuilder AddNoOfRooms(int noOfRooms)
            {
                _house.NoOfRooms += noOfRooms;
                return this;
            }

            public HouseBuilder SetNoOfWindows(int noOfWindows)
            {
                _house.NoOfWindows = noOfWindows;
                return this;
            }
            public HouseBuilder SetStreetAdress(string streetAdress)
            {
                _house.StreetAdress = streetAdress;
                return this;
            }

            /// <summary>
            ///    decides if the new house should have a pool or not.
            /// </summary>
            /// <param name="poolOption"> true if house should have a pool</param>
            public HouseBuilder HasSwimmingpool(bool poolOption)
            {
                _house.HasSwimmingPool = poolOption;
                return this;
            }
            public HouseBuilder SetNoOfParkingSpots(int noOfParkingSpots)
            {
                _house.ParkingSpotsInGarage = noOfParkingSpots;

                return this;
            }

            public House Build()
            {
                if (_house.NoOfRooms <= 0) throw new ArgumentOutOfRangeException("You cannot add a negative number of rooms");
                if (_house.NoOfWindows < 0) throw new ArgumentOutOfRangeException("Negative amount of windows are not allowed!");
                if (_house.ParkingSpotsInGarage < 0) throw new ArgumentOutOfRangeException("Negative amount of parkingspots are not allowed!");

                return _house;
            }
        }
    }
}
