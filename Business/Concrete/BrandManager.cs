using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;
        public BrandManager(IBrandDal iBrandDal)
        {
            _iBrandDal = iBrandDal;
        }

        public List<Brand> GetAll()
        {
            return _iBrandDal.GetAll();
        }

        public List<Brand> GetCarByColorId()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }
    }
}
