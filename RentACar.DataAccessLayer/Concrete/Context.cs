using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.EntityLayer.Concrete;

namespace RentACar.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //Pluralize
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
