using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookme.pk
{
    class ShowBookingdetails : FlightsDetails
    {
       
        public ShowBookingdetails(Label lb1, Label lb2, Label lb3, Label lb4)
        {
            lb1.Text = selectedDeparture;
            lb2.Text = selectedDestination;
            lb3.Text = flightTicketPrice;
            lb4.Text = selectedAirlines;
        }
        public ShowBookingdetails(string a)
        {

        }

        public override void PriceCal()
        {
            base.PriceCal();
            MessageBox.Show(" "+sum);
        }

    }
}
