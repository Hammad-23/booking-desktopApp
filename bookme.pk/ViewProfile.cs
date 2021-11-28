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
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            labelUserName.Text = User.userName;
            labelUserEmail.Text = User.userEmail;
            labelContact.Text = Convert.ToString(User.number);
            labelAdress.Text = User.adress;
            labelCity.Text = User.city;
        }
    }
}
