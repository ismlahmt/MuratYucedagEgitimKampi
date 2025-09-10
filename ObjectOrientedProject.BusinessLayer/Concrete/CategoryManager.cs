using ObjectOrientedProject.BusinessLayer.Abstract;
using ObjectOrientedProject.DataAccessLayer.Abstract;
using ObjectOrientedProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategorydal _categorydal;

        public CategoryManager(ICategorydal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TDelete(Category entity)
        {
            _categorydal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categorydal.GetAll();
        }

        public Category TGetById(int id)
        {
           return _categorydal.GetById(id);
        }

        public void TInsert(Category entity)
        {
             _categorydal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
             _categorydal.Update(entity);
        }
    }
}
