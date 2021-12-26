using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookme.pk
{
    class Bill:FlightsDetails
    {
        public Bill(Label lb1)
        {
            lb1.Text = Convert.ToString(sum);
        }
    }
}
