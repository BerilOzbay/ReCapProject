using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, Proje1Context>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetail()
        {
            using (Proje1Context context = new Proje1Context())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.CarId
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.Id equals user.UserId
                             select new RentalDetailDto
                             {
                                 FirstName = user.UserFirstName,
                                 LastName = user.UserLastName,
                                 CarName = car.Description,
                                 CarId = car.CarId,
                                 DailyPrice = car.DailyPrice,
                                 ReturnDate = rental.ReturnDate,
                                 RentDate = rental.RentDate
                             };
                
                return result.ToList();
            }

        }

    }
}
