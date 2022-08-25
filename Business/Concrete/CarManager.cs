using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal )
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length>2&&car.DailyPrice>0)
            {
                _iCarDal.Add(car);
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Eklenmedi");
            }
        }

        

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }
      

        public List<Car> GetCarByBrandId(int Brandid)
        {
            return _iCarDal.GetAll(c => c.BrandId == Brandid);
        }

        public List<Car> GetCarByColorId(int Colorid)
        {
            return _iCarDal.GetAll(c => c.ColoredId == Colorid);
        }
    }
}
