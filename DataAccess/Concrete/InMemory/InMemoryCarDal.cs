using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=775000,Description=" Audi A8 3.0 TDI Quattro Long ",ModelYear=2013},
                new Car{CarId=2,BrandId=1,ColorId=2,DailyPrice=330000,Description=" Audi A4 Sedan 2.0 TDI ",ModelYear=2015},
                new Car{CarId=3,BrandId=2,ColorId=1,DailyPrice=133500,Description=" Fiat Doblo Combi ",ModelYear=2016},
                new Car{CarId=4,BrandId=3,ColorId=3,DailyPrice=1015000,Description=" Toyota Supra 2.0 ",ModelYear=2020},
            };
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetById(int carId)
        {
           return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
