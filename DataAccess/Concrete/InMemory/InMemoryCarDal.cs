using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
            List<Car> _cars;
            public InMemoryCarDal()
            {
                _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColoredId=3,DailyPrice=1000,Description="Pahalı Araba",ModelYear=2021},
                new Car{Id=2,BrandId=1,ColoredId=1,DailyPrice=1000,Description="Güzel Araba",ModelYear=2021},
                new Car{Id=3,BrandId=3,ColoredId=2,DailyPrice=1000,Description="Eski Araba",ModelYear=1980},
                new Car{Id=4,BrandId=2,ColoredId=6,DailyPrice=1000,Description="Yeni Araba",ModelYear=2022},
                new Car{Id=5,BrandId=1,ColoredId=4,DailyPrice=1000,Description="Kazalı Araba",ModelYear=2013},
                new Car{Id=6,BrandId=2,ColoredId=5,DailyPrice=1000,Description="Hasarsız Araba",ModelYear=2018},
            };
            }

            public void Add(Car car)
            {
                _cars.Add(car);
            }

            public void Delete(Car car)
        {
            Car CarToDelete =_cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
            {
            return _cars;
            }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
            {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColoredId=car.ColoredId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
            }
        
    }
}

