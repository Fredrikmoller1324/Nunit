using HouseFB;

House newHouse = House.Builder
    .AddNoOfRooms(3)
    .SetNoOfWindows(-1)
    .SetNoOfParkingSpots(0)
    .SetStreetAdress("Kodgatan 17")
    .HasSwimmingpool(true)
    .Build();

Console.WriteLine(newHouse.ParkingSpotsInGarage);
Console.WriteLine(newHouse.HasGarage);
Console.WriteLine(newHouse.ToString());
