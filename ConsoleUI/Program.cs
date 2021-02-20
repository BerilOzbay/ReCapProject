using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //ColorTest();
            //CarTest();
            RentalTest();

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { UserFirstName = "Sule",UserLastName = "Yasar",UserEmail ="yasar@gmail.com",UserPassword="895642"});

        }


        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
               
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAllRentalDetail();
            if (result.Success)
            {

                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.FirstName + "/" + rental.LastName + "/"
                        + rental.CarName + "/" + rental.DailyPrice + "/"
                        + rental.RentDate + "/" + rental.ReturnDate + "/");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


    }
}
