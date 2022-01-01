using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookme.pk
{
    public partial class ParticularHotel : Form
    {
        public ParticularHotel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ParticularHotel_Load(object sender, EventArgs e)
        {
            ShowBookingdetails showbook = new ShowBookingdetails(labelNoBeds, labelRooms, labelDays, labelHotel,"b");
        }
    }
}
