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
    public class ColorManager : IColorService
    {
        IColorDal _iColorDal;
        public ColorManager(IColorDal iColorDal)
        {
            _iColorDal = iColorDal;
        }

        public List<Color> GetAll()
        {
            return _iColorDal.GetAll();
        }

        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
