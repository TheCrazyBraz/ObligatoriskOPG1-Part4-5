using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOPG1;
using ObligatoriskOPG1_Part4_5;
using ObligatoriskOPG1_Part4_5.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOPG1_Part4_5.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        Repository _repo;
        private List<Car> testListOfCars;
        private Car testCar;
        private int testCarId;
        private string testCarModel;
        private int testCarPrice;
        private string testCarLicensePlate;
        private int nextId;


        public RepositoryTests() {
            _repo = new();
            testCarId = 2;
            testCarModel = "Audi";
            testCarPrice = 890200;
            testCarLicensePlate = "ABC987";
            testCar = _repo.GetCarById(testCarId);
            testListOfCars = _repo.getAllCars();
        }
        [TestMethod()]
        public void getAllCarsTest()
        {
            Assert.IsNotNull(testListOfCars, "List of cars is null");
            Assert.AreEqual(testListOfCars.Count(), 4, "The list does not contain the right number of cars");
        }

        [TestMethod()]
        public void GetCarByIdTest()
        {
            Assert.IsNotNull(testCar, "Car is null");
            Assert.AreEqual(testCarId, testCar.Id, "The id of the car are not equal the given argument");
            Assert.AreEqual(testCarModel, testCar.Model, "The car model are not equal the given argument");
            Assert.AreEqual(testCarLicensePlate, testCar.Plate, "The licenseplate of the car are not equal the given argument");
            Assert.AreEqual(testCarPrice, testCar.Price, "The price of the car are not equal the given argument");
        }
    }
}