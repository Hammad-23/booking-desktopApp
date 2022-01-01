using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace bookme.pk
{
    class Auth:User
    {
      

        public void registration(string name, string email, long contact, string pass,Form frm1, Form frm2)
        {
            if (name == "" || email == "" || pass == "")
            {
                MessageBox.Show("Fields required");
            }
            else if (!string.IsNullOrWhiteSpace(email))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(email))
                {
                
                    MessageBox.Show("Email is not valid");
                }
                else
                {
                    userName = name;
                    userEmail = email;
                    userContact = contact;
                    userPassword = pass;
                

                    frm1.Hide();
                    frm2.Show();

                }
            }
           /* else
            {
                userName = name;
                userEmail = email;
                userContact = contact;
                userPassword = pass;
                MessageBox.Show(userName + " " + userEmail);

                frm1.Hide();
                frm2.Show();

            }*/
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
