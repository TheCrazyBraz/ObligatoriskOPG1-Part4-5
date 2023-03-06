using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using ObligatoriskOPG1;
using System.Collections.Generic;
using System;

namespace ObligatoriskOPG1_Part4_5
{
    public class Repository
    {
        static int nextId = 0;
        static List<Car> cars = new List<Car>()
        {
            new Car() {Id = nextId++, Model = "Ford", Plate = "ABC123", Price = 89000},
            new Car() {Id = nextId++, Model = "Kia", Plate = "XYZ123", Price = 890030},
            new Car() {Id = nextId++, Model = "Audi", Plate = "ABC987", Price = 890200},
            new Car() {Id = nextId++, Model = "Mercedes", Plate = "XYZ987", Price = 895000}
        };  
        public List<Car> getAllCars()
        {
            return cars;
        }
        [HttpGet("{id:int}")]
        public Car GetCarById(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            return car;
        }

        public Car AddCar(Car car)
        {
            car.Id= nextId++;
            cars.Add(car);
            return car;
        }

        public Car DeleteCar(int id)
        {
            var car = cars.Find(c => c.Id == id);
            cars.Remove(car);


            return car;
        }
        public Car UpdateCar(int id, Car car)
        {

            Car findCar = GetCarById(id);

            findCar.Model = car.Model;
            findCar.Plate = car.Plate;
            findCar.Price = car.Price;

            return findCar;

        } 
       
    }
}
