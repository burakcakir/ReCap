using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;

        public InMemoryCarDal()
        {
            _carList = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2014,DailyPrice=300000,Explanation="bu araba mercedestir" },
                new Car{Id=2,BrandId=2,ColorId=3,ModelYear=1997,DailyPrice=20000,Explanation="bu araba tofaş" },
                new Car{Id=3,BrandId=3,ColorId=1,ModelYear=2006,DailyPrice=40000,Explanation="bu araba wolkswagen" },
                new Car{Id=4,BrandId=4,ColorId=2,ModelYear=1972,DailyPrice=1000000,Explanation="bu araba ferrai" },
            };
        }

        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(c =>c.Id == car.Id);

            _carList.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filtre)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _carList.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Explanation = car.Explanation;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
