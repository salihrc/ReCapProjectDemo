using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.AddCar(car);
        }

        public void Delete(Car car)
        {
            _carDal.DeleteCar(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int carId)
        {
           return _carDal.GetById(carId);
        }

        public void Update(Car car)
        {
            _carDal.UpdateCar(car);
        }
    }
}
