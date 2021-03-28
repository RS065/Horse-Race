using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public static class Factory
    {
        public static int count;

        public static Punter MakePunter(string name, RadioButton radiobtn, TextBox txtBox)
        {

            if (name == "Jack")
            {
                count++;
                return new Jack(name, 50, radiobtn, txtBox);
            }
            else if (name == "Robin")
            {
                count++;
                return new Robin(name, 50, radiobtn, txtBox);
            }
            else if (name == "Marina")
            {
                count++;
                return new Marina(name, 50, radiobtn, txtBox);
            }

            return null;
        }
    }
}
