using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from b in context.Cars
                             join c in context.Brands
                             on b.BrandId equals c.BrandId
                             join d in context.Colors
                             on b.ColoredId equals d.ColorId
                             select new CarDetailDto 
                             { 
                                 BrandName=c.BrandName,
                                 ModelYear=b.ModelYear,
                                 Id=b.Id,
                                 ColorName=d.ColorName,
                                 DailyPrice=b.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
