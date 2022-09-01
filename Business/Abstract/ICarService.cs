using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarByColorId(int Colorid);
        List<Car> GetCarByBrandId(int Brandid);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
