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
            CarManager carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 250, Description = "Mercedes" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description, car.DailyPrice);
            }

            
        }
    }
}
