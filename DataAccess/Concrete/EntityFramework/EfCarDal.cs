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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Proje1Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Proje1Context proje1Context = new Proje1Context())
            {
                var result = from c in proje1Context.Cars
                             join b in proje1Context.Brands
                             on c.BrandId equals b.BrandId
                             join color in proje1Context.Colors
                             on c.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice


                             };
                return result.ToList();
            }
        }
    }
}


