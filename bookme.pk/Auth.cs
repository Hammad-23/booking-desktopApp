using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookme.pk
{
    class Auth:User
    {
      

        public void registration(string name, string email, long contact, string pass)
        {
            if (name == "" || email == "" || pass == "")
            {
                MessageBox.Show("Fields required");
            }
            else
            {
                userName = name;
                userEmail = email;
                userContact = contact;
                userPassword = pass;
                /* MessageBox.Show(userName + " " + userEmail);*/
                Form2 f2 = new Form2();
                Form1 f1 = new Form1();
                f1.Close();
                f2.Show();

            }
        }
        public void login(string email,string password)
        {
            if (userEmail == email && userPassword == password)
            {
                Form2 f2 = new Form2();
                f2.Hide();
                Home home = new Home();
                home.Show();

            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
