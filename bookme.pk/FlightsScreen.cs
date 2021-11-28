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

        }

        private void FlightsScreen_Load(object sender, EventArgs e)
        {
          /*  FlightsDetails fd = new FlightsDetails();
            fd.airlines_dropdown(comboBoxAirlines);*/
        }
    }
}
