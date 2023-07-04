﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Repositories;
using RentACar.EntityLayer.Concrete;

namespace RentACar.DataAccessLayer.EntityFramework
{
    internal class EfCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
    }
}
