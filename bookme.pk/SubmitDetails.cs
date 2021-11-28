using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookme.pk
{
    class SubmitDetails:ProfileDetails
    {
        public void details(string userAdress, string userContact, string userCity)
        {
            long userNumber = Convert.ToInt64(userContact);
            adress = userAdress;
            number = userNumber;
            city = userCity;
        }

    }
}
