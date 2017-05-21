using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    abstract class Cargo:Plane
    {
        private int lifting=0;
        public int Lifting
        {
            get
            {
                return lifting;
            }
            set
            {
                lifting = value;
            }
        }
    }
}
