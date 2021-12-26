using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookme.pk
{
    class FlightsDetails
    {
        public static string selectedAirlines;
        public static string selectedDeparture;
        public static string selectedDestination;
        public static string selectedClass;
        public static string flightTicketPrice;
        public static int qty;
        public static int sum;
        




        public void dropdown(ComboBox cb, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                cb.Items.Add(arr[i]);
            }
        }

        public void selectedAirlineName(ComboBox cb)
        {
            selectedAirlines = cb.SelectedItem.ToString();
            /* MessageBox.Show(selectedAirlines);*/
        }
        public void selectedDepartureName(ComboBox cb)
        {
            selectedDeparture = cb.SelectedItem.ToString();
        }

        public void selectedDestinationName(ComboBox cb)
        {
            selectedDestination = cb.SelectedItem.ToString();
        }
        public void selectedFlightsClassName(ComboBox cb)
        {
            selectedClass = cb.SelectedItem.ToString();
        }

        public void checkFlightDetails()
        {
            for (int i = 0; i < FlightInformation.airlines.Length; i++)
            {
                if (selectedAirlines == FlightInformation.airlines[0] && selectedDeparture == FlightInformation.departure[0] && selectedDestination == FlightInformation.destination[0])
                {
                    flightTicketPrice = FlightInformation.ticketPrice[0];
                }else if(selectedAirlines == FlightInformation.airlines[1] && selectedDeparture == FlightInformation.departure[1] && selectedDestination == FlightInformation.destination[1])
                {
                    flightTicketPrice = FlightInformation.ticketPrice[1];
                }
                else if (selectedAirlines == FlightInformation.airlines[2] && selectedDeparture == FlightInformation.departure[2] && selectedDestination == FlightInformation.destination[2])
                {
                    flightTicketPrice = FlightInformation.ticketPrice[2];
                }
                else if (selectedAirlines == FlightInformation.airlines[3] && selectedDeparture == FlightInformation.departure[3] && selectedDestination == FlightInformation.destination[3])
                {
                    flightTicketPrice = FlightInformation.ticketPrice[3];
                }
            }

        }
        public virtual void PriceCal()
        {
            sum = qty * int.Parse(flightTicketPrice);
        }
    }
}
