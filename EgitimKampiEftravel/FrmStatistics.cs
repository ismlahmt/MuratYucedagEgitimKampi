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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        OOPegitimkampi_EntityfwtraveldbEntities db = new OOPegitimkampi_EntityfwtraveldbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x=> x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvarageCapacity.Text = (db.Location.Average(x=> x.Capacity).ToString());
            lblAvaragePrice.Text = String.Format("{0:0.00}", db.Location.Average(x => x.Price), 2);

            int LastCountryid = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId== LastCountryid).Select(y=> y.Country).FirstOrDefault();
            
            
            lblJpnAvarageCap.Text = db.Location.Where(x => x.Country == "Japonya").Average(x => x.Capacity).ToString();

            var MaxKapasite = db.Location.Max(y => y.Capacity); 
            lblMaxCapacityTour.Text = db.Location.Where(x=> x.Capacity == MaxKapasite).Select(y=> y.Country).FirstOrDefault().ToString();

        }

        private void lblLocationCount_Click(object sender, EventArgs e)
        {

        }
    }
}
