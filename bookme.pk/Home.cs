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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            labelName.Text = User.userName;
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            Home home = new Home();
            this.Hide();
            f1.Hide();
            f2.Hide();
            home.Hide();
            FlightsScreen fs = new FlightsScreen();
            fs.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileScreen ps = new ProfileScreen();
            ps.Show();
        }
    }
}
