using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace bookme.pk
{
    public partial class ParticularFlight : Form
    {
        public ParticularFlight()
        {
            InitializeComponent();
        }

        private void ParticularFlight_Load(object sender, EventArgs e)
        {
            ShowBookingdetails showBokDet = new ShowBookingdetails(labelDeparture, labelDestination, labelPrice,labelAirline);
           
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
           

            ShowBookingdetails shbokdt = new ShowBookingdetails("a");
            int qtytick = int.Parse(textBoxQty.Text);
            FlightsDetails.qty = qtytick;
            shbokdt.PriceCal();
            this.Hide();
            ThankyouScreen ts = new ThankyouScreen();
            ts.Show();


            /*shbokdt.PriceCal(textBoxQty);*/
           /* try
            {
                WebClient client = new WebClient();
                string to, message;
                to = "03007044599";
                message = "Hello World";
                string baseURL = "http://api.clickatell.com/http/sendmsg?user=zisan94268&password=OYeNLVUHTNIHbD&api_id=3528011&to='" + to + "'&text='" + message + "'";
                client.OpenRead(baseURL);
                MessageBox.Show("Successfully sent message");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }*/
        }
    }
}
