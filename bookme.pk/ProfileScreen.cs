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
    public partial class ProfileScreen : Form
    {
        public ProfileScreen()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           
            SubmitDetails sd = new SubmitDetails();
            sd.details(richTextBoxAdress.Text, textBoxContact.Text, textBoxCity.Text);
            
            this.Hide();
            Home home = new Home();
            home.Show();

        }
    }
}
