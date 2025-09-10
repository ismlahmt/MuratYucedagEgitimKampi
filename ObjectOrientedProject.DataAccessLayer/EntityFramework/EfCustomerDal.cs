using ObjectOrientedProject.DataAccessLayer.Abstract;
using ObjectOrientedProject.DataAccessLayer.Repositories;
using ObjectOrientedProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal: GenericRepository<Customer>, ICustomerDal
    {
    }
}
