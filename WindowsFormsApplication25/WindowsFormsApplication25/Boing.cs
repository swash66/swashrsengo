using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class Boing:Passenger
    {
        private static string nameclass = "Passanger:Boing: ";
        public string Nameclass
        {
            set
            {
                this.Name = nameclass + this.Name.ToString();
            }
        }
    }
}
