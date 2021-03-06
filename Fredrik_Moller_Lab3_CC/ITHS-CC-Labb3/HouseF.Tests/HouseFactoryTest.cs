using HouseF.Houses;
using NUnit.Framework;
using System.Collections.Generic;

namespace HouseF.Tests
{
    public class HouseFactoryTest
    {
        private HouseFactory _factory;
        [SetUp]
        public void Setup()
        {
            _factory = new HouseFactory();
        }

        [Test]
        public void BuildHouse_GivenValidHouseName_ReturnsCorrectHouseType()
        {
            var house = _factory.BuildHouse("budgetHouse");

            Assert.That(house, Is.TypeOf<BudgetHouse>());
        }

        [Test]
        public void BuildHouse_GivenInvalidHouseName_ThrowsKeyNotFoundException()
        {
            string nonExistingKey = "badhouse23";
            Assert.Throws<KeyNotFoundException>(() => _factory.BuildHouse(nonExistingKey));
        }

        [Test]
        public void BuildHouse_GivenHouseIsBudgetHouse_ReturnExpectedHousePropertyValues()
        {
            BudgetHouse expectedBudgetHouse = new BudgetHouse();

            var ActualHouse = _factory.BuildHouse("budgethouse");

            Assert.AreEqual(expectedBudgetHouse.StreetAdress, ActualHouse.StreetAdress);
            Assert.AreEqual(expectedBudgetHouse.NoOfWindows, ActualHouse.NoOfWindows);
            Assert.AreEqual(expectedBudgetHouse.ParkingSpotsInGarage, ActualHouse.ParkingSpotsInGarage);
            Assert.AreEqual(expectedBudgetHouse.NoOfRooms, ActualHouse.NoOfRooms);
            Assert.AreEqual(expectedBudgetHouse.HasGarage, ActualHouse.HasGarage);
            Assert.AreEqual(expectedBudgetHouse.HasSwimmingPool, ActualHouse.HasSwimmingPool);
        }

        [Test]
        public void BuildHouse_GivenHouseIsEnviromentalHouse_ReturnExpectedHousePropertyValues()
        {
            EnviromentalHouse expectedEnviromentalHouse = new EnviromentalHouse();

            var ActualHouse = _factory.BuildHouse("enviromentalHouse");

            Assert.AreEqual(expectedEnviromentalHouse.StreetAdress, ActualHouse.StreetAdress);
            Assert.AreEqual(expectedEnviromentalHouse.NoOfWindows, ActualHouse.NoOfWindows);
            Assert.AreEqual(expectedEnviromentalHouse.ParkingSpotsInGarage, ActualHouse.ParkingSpotsInGarage);
            Assert.AreEqual(expectedEnviromentalHouse.NoOfRooms, ActualHouse.NoOfRooms);
            Assert.AreEqual(expectedEnviromentalHouse.HasGarage, ActualHouse.HasGarage);
            Assert.AreEqual(expectedEnviromentalHouse.HasSwimmingPool, ActualHouse.HasSwimmingPool);
        }

        [Test]
        public void BuildHouse_GivenHouseIsLuxaryMansionHouse_ReturnExpectedHousePropertyValues()
        {
            LuxaryMansionHouse expectedLuxaryMansionHouse = new LuxaryMansionHouse();

            var ActualHouse = _factory.BuildHouse("luxarymansionhouse");

            Assert.AreEqual(expectedLuxaryMansionHouse.StreetAdress, ActualHouse.StreetAdress);
            Assert.AreEqual(expectedLuxaryMansionHouse.NoOfWindows, ActualHouse.NoOfWindows);
            Assert.AreEqual(expectedLuxaryMansionHouse.ParkingSpotsInGarage, ActualHouse.ParkingSpotsInGarage);
            Assert.AreEqual(expectedLuxaryMansionHouse.NoOfRooms, ActualHouse.NoOfRooms);
            Assert.AreEqual(expectedLuxaryMansionHouse.HasGarage, ActualHouse.HasGarage);
            Assert.AreEqual(expectedLuxaryMansionHouse.HasSwimmingPool, ActualHouse.HasSwimmingPool);
        }



    }
}