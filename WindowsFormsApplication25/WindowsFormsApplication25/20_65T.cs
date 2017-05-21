using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class _20_65T:Cargo
    {
        private static string nameclass = "Cargo:20-65T: ";
        public string Nameclass
        {
            set
            {
                this.Name = nameclass + this.Name.ToString();
            }
        }
    }
}
