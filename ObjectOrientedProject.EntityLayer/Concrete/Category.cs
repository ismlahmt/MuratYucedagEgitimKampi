using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject.EntityLayer.Concrete
{
    public class Category
    {
        

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }




    }
}


// classın içinde direkt tanımlanan field olur int x;
// classın içinde get ve set ile tanımlanan property olur public int y {get; set;}
// classın içindeki bir fonksiyonun altında tanımlanırsa variable olur void test() { int z;}

//bir sınıfın birincil anahtar oldugunu ve otomatik artan oldugunu belirtmek için sınıfın ismi aynı yazılmalı sonuna Id eklenmeli.
//örnek Category sınıfı için CategoryId
