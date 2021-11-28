using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookme.pk
{
    class SubmitDetails:User
    {
        public void details(string userAdress, string userContact, string userCity)
        {
            long userNumber = Convert.ToInt64(userContact);
            adress = userAdress;
            number = userNumber;
            city = userCity;
            MessageBox.Show("Details Submit");
            
        }

    }
}
