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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form1 f1 = new Form1();
            Auth authentication = new Auth();
            long contactNo = Convert.ToInt64(textBoxContact.Text);
            authentication.registration(textBoxName.Text, textBoxEmail.Text, contactNo, textBoxPassword.Text,f1,f2);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
