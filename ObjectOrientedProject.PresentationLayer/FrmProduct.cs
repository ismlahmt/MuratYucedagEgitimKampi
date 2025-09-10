using ObjectOrientedProject.BusinessLayer.Concrete;
using ObjectOrientedProject.DataAccessLayer.EntityFramework;
using ObjectOrientedProject.BusinessLayer;
using ObjectOrientedProject.DataAccessLayer;
using ObjectOrientedProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedProject.BusinessLayer.Abstract;

namespace ObjectOrientedProject.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IPorductService _productService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        
        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
