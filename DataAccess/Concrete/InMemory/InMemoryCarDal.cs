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
            { new Car{Id=1, BrandId=100 , ColorId=17,DailyPrice=20000, ModelYear=1990,Description="Benzin"},
            new Car{Id=2, BrandId=101 , ColorId=10,DailyPrice=101000, ModelYear=2008,Description="Dizel"},
            new Car{Id=3, BrandId=101 , ColorId=11,DailyPrice=200000, ModelYear=2020,Description="Benzin/Lpg"},
            new Car{Id=4, BrandId=102 , ColorId=13,DailyPrice=152000, ModelYear=2005,Description="Dizel"},
            new Car{Id=5, BrandId=103 , ColorId=12,DailyPrice=71500, ModelYear=2007,Description="Benzin"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandId == c.BrandId);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
            
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;


        }

        ICarDal ICarDal.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
