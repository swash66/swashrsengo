using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class _65_120T:Cargo
    {
        private static string nameclass = "Cargo:65-120T: ";
        public string Nameclass
        {
            set
            {
                this.Name = nameclass+this.Name.ToString();
            }
        }
    }
}
