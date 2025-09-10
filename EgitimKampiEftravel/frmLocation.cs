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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }
        OOPegitimkampi_EntityfwtraveldbEntities db = new OOPegitimkampi_EntityfwtraveldbEntities();
        private void frmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId


            }).ToList();

            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nmrcCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.DayNight = txtDaynight.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Eklendi.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse (txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight = txtDaynight.Text;
            updatedValue.Capacity = byte.Parse(nmrcCapacity.Text);
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.Country = txtCountry.Text;
            updatedValue.City = txtCity.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

//byte.Parse kullanma sebebimiz sql tarafında capaictyi tiny int olarak tanımlamamızdır.