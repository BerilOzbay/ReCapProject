﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //GetById, GetAll, Add, Update, Delete
    public interface ICarDal: IEntityRepository<Car>
    {
        

    }
}
