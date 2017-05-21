using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class Bomber:Military
    {
        private static string nameclass = "Military:Bomber: ";
        public string Nameclass
        {
            set
            {
                this.Name = nameclass + this.Name.ToString();
            }
        }
    }
}
