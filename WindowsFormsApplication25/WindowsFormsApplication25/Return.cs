using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class Return
    {
        public static Airlane airlane = new Airlane();
        public  static List<int> index1 = new List<int>();
        public static Airlane Airlane
        {
            get
            {
                
                return airlane;
            }
            set
            {
                airlane = value;
            }
        }
        public static List<int> Index1
        {
            get
            {
                return index1;
            }
            set
            {
                
            }
        }
    }
}
