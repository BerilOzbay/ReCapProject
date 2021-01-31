﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {   
            _cars = new List<Car> {

                new Car{CarId=1,BrandId=2,ColorId=3,DailyPrice=4856,ModelYear="2013",Description="Reno"},
                new Car{CarId=2,BrandId=3,ColorId=1,DailyPrice=400,ModelYear="2019",Description="Volvo"},
                new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=80,ModelYear="2020",Description="Peugeot"},
                new Car{CarId=4,BrandId=4,ColorId=3,DailyPrice=585,ModelYear="2016",Description="Audi"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;

            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}