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
    public partial class HotelsView : Form
    {
        public HotelsView()
        {
            InitializeComponent();
        }

        private void HotelsView_Load(object sender, EventArgs e)
        {
            FlightsDetails fd = new FlightsDetails();
            fd.dropdown(comboBoxHotels, FlightInformation.hotels);
            fd.dropdown(comboBoxBeds, FlightInformation.noOfBeds);
            fd.dropdown(comboBoxRooms, FlightInformation.noOfRooms);
            fd.dropdown(comboBoxDays, FlightInformation.days);
        }
    }
}
