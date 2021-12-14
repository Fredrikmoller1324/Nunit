using NUnit.Framework;
using System;

namespace HouseFB.Tests
{
    public class HouseTest
    {
        [Test]
        [TestCase(0,1)]
        [TestCase(1,2)]
        [TestCase(4,5)]
        public void AddNoOfRooms_GivenInputIsPositiveNumber_ReturnsTotalNoOfRooms(int roomsAdded, int expectedNoOfRooms)
        {
            House testHouse = House.Builder.AddNoOfRooms(roomsAdded).Build();
            int result = testHouse.NoOfRooms;

            Assert.AreEqual(expectedNoOfRooms, result);
        }

        [Test]
        public void AddNoOfRooms_GivenInputIsNegativeNumber_ThrowNewArgumentOutOfRangeException()
        {
            int negativeTestValue = -1;
            
            Assert.Throws<ArgumentOutOfRangeException>(() => House.Builder.AddNoOfRooms(negativeTestValue).Build());
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        public void SetNoOfWindows_GivenInputIsPositiveNumber_ReturnsTotalNoOfWindows(int setNoOfWindows, int expectedNoOfWindows)
        {
            House testHouse = House.Builder.SetNoOfWindows(setNoOfWindows).Build();
            int result = testHouse.NoOfWindows;

            Assert.AreEqual(expectedNoOfWindows, result);
        }

        [Test]
        public void SetNoOfWindows_GivenInputIsNegativeNumber_ThrowNewArgumentOutOfRangeException()
        {
            int negativeTestValue = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => House.Builder.SetNoOfWindows(negativeTestValue).Build());
        }

        [Test]
        [TestCase("TestStreet 5", "TestStreet 5")]
        [TestCase("TestStreet 2", "TestStreet 2")]
        [TestCase("TestStreet6", "TestStreet6")]
        public void SetStreetAdress_GivenAnAdress_ReturnsSameAdress(string inputAdress, string expectedAdress)
        {
            House testHouse = House.Builder.SetStreetAdress(inputAdress).Build();
            string result = testHouse.StreetAdress;

            Assert.AreEqual(expectedAdress, result);
        }

        [Test]
        public void HasSwimmingPool_GivenTrue_ReturnsTrue()
        {
            House testHouse = House.Builder.HasSwimmingpool(true).Build();
            bool result = testHouse.HasSwimmingPool;

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        public void SetNoOfParkingSpots_GivenZeroOrPositiveNumber_ReturnsTotalNoOfParkingSpots(int setNoOfParkingSpots, int expectedNoOfParkingSpots)
        {
            House testHouse = House.Builder.SetNoOfParkingSpots(setNoOfParkingSpots).Build();
            int result = testHouse.ParkingSpotsInGarage;

            Assert.AreEqual(expectedNoOfParkingSpots, result);
        }

        [Test]
        public void SetNoOfParkingSpots_GivenNegativeNumber_ThrowNewArgumentOutOfRangeException()
        {
            int negativeTestValue = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => House.Builder.SetNoOfParkingSpots(negativeTestValue).Build());
        }

        [Test]
        public void SetNoOfParkingSpots_GivenZero_HasGarageIsFalse()
        {
            House testHouse = House.Builder.SetNoOfParkingSpots(0).Build();
            bool result = testHouse.HasGarage;

            Assert.IsFalse(result);
        }
    }
}