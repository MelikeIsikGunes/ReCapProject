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
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=3000,ModelYear=2017,Description="Hyundai i20"},
                new Car{CarId=2,BrandId=1,ColorId=2,DailyPrice=5000,ModelYear=2004,Description="Hyundai Accent"},
                new Car{CarId=3,BrandId=2,ColorId=1,DailyPrice=2000,ModelYear=2008,Description="Toyota Auris"},
                new Car{CarId=4,BrandId=2,ColorId=2,DailyPrice=1000,ModelYear=1999,Description="Toyota Corolla"},
                new Car{CarId=5,BrandId=2,ColorId=2,DailyPrice=500,ModelYear=2011,Description="Toyota Avensis"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c=> c.BrandId==brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
