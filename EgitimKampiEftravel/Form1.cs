using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimKampiEftravel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        OOPegitimkampi_EntityfwtraveldbEntities db = new OOPegitimkampi_EntityfwtraveldbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            
            var values = db.Guide.ToList();
            dataGridView1.DataSource= values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Kaydedildi.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x=> x.GuideId==id).ToList();
            dataGridView1.DataSource = values;

        }
    }
}




// eğer her seferinde OOPegitimkampi_EntityfwtraveldbEntities db = new OOPegitimkampi_EntityfwtraveldbEntities(); yazmak istemiyorsan
// süslü parantezin dışına birkez yaz hepsini algılasın.
// Message Box birden fazla parametreyle kullanılır mesajdan sonraki ilk parametre başlıktır.
//2. parmetre ise buttonu belirler 
//3. parametre ise ikonu belirler.


// getbyid kısmında yaptıgımız şey ise pythondaki lambda fonksiyonu yazmayla birebir aynı => işareti ise manasına gelir
// xguide id eşitse id ye listele demek olur bu.