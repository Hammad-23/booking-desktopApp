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
    public partial class FlightsScreen : Form
    {
        public FlightsScreen()  
        {
            InitializeComponent();
        }

        private void comboBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlightsDetails fd = new FlightsDetails();
            fd.selectedAirlineName(comboBoxAirlines);
        }
     
        private void FlightsScreen_Load(object sender, EventArgs e)
        {

            FlightsDetails fd = new FlightsDetails();
            fd.dropdown(comboBoxAirlines,FlightInformation.airlines);
            fd.dropdown(comboBoxDeparture,FlightInformation.departure);
            fd.dropdown(comboBoxArrival,FlightInformation.destination);
            fd.dropdown(comboBoxClass,FlightInformation.selectClass);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void comboBoxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlightsDetails fd = new FlightsDetails();
            fd.selectedDepartureName(comboBoxDeparture);
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlightsDetails fd = new FlightsDetails();
            fd.selectedFlightsClassName(comboBoxClass);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            FlightsDetails fd = new FlightsDetails();
            fd.checkFlightDetails();
            this.Hide();
            ParticularFlight pf = new ParticularFlight();
            pf.Show();
        }

        private void comboBoxArrival_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlightsDetails fd = new FlightsDetails();
            fd.selectedDestinationName(comboBoxArrival);
        }
    }
}
