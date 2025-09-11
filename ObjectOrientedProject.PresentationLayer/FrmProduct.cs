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
using ObjectOrientedProject.EntityLayer.Concrete;
using System.Windows.Markup;

namespace ObjectOrientedProject.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IPorductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService= new CategoryManager(new EfCategoryDal());
        }
        
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            comboBox1.DataSource = values;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
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
            Product product = new Product();
            product.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductDescription = txtDescription.Text;
            product.ProductId = int.Parse(txtProductId.Text);
            product.ProductName = txtProductName.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TInsert(product);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id); 
            _productService.TDelete(value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int .Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            value.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
            value.ProductDescription = txtDescription.Text;
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductName = txtProductName.Text;
            value.ProductStock = int.Parse (txtProductStock.Text);
            _productService.TUpdate(value);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values = _productService.TGetById(id);
            dataGridView1.DataSource = values;
        }
    }
}
