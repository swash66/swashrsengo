using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class Military:Plane
    {
        private int thickness;
        public int Thickness
        {
            get
            {
                return thickness;
            }
            set
            {
                thickness = value;
            }
        }
    }
}
