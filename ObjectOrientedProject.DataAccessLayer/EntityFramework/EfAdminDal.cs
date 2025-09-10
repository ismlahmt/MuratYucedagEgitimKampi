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
    public class EfAdminDal: GenericRepository<Admin>, IAdminDal
    {


    }
}


/*
Ekle Sil Güncelle Listele İd ye göre getir her entity için geçerli komutlardır.
içinde a harfi geçmeyen kullanıcıları listele sadece 1 entity için çalışan komuttur mesela.
 
 
 */