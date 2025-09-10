using ObjectOrientedProject.BusinessLayer.Abstract;
using ObjectOrientedProject.DataAccessLayer.Abstract;
using ObjectOrientedProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerdal;
        public void TDelete(Customer entity)
        {
            _customerdal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerdal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerdal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerSurname != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null)
            {
                _customerdal.Insert(entity);
            }
            else
            {
                // hata mesajı ver.
            }
        }

        public void TUpdate(Customer entity)
        {
            _customerdal.Update(entity);
        }
    }
}
