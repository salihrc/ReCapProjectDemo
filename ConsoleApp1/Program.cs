using Business.Concrate;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() {CarId=5,BrandId=4,ColorId=2,DailyPrice=512000,Description = " Mercedes-Benz C 200 d Blue TEC AMG ",ModelYear=2016};
            Car car2 = new Car() { CarId = 6, BrandId = 4, ColorId = 1, DailyPrice = 1670000, Description = " Mercedes-Benz 350 ", ModelYear = 2015 };
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Delete(car1);
            carManager.Update(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description+"-" + car.ModelYear + "-" + car.DailyPrice);
            }
            foreach (var car in carManager.GetById(6))
            {
                Console.WriteLine("\n Bu Araba Id Ye Göre Gelmiştir:\n "+car.Description +"-"+car.ModelYear+"-"+car.DailyPrice);
            }
        }
    }
}
