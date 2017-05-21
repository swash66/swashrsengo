using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication25
{
    class Airlane
    {
        public int capacity=0;
        public string name;
        private List<Plane> allplane = new List<Plane>();
        public List<Plane> Allplane
        {
            get
            {
                return allplane;
            }
        }
        public int Capacity
        {
            get
            {
                int n=0;
                Boing sp3 = new Boing();
                Airbus sp4 = new Airbus();
                for (int i=0;i<this.Allplane.Count();i++)
                {

                    if (this.Allplane[i].GetType() == sp3.GetType())
                    {
                        Boing b = (Boing)(this.Allplane[i]);
                        n += b.Capacity;
                    }
                    if (this.Allplane[i].GetType() == sp4.GetType())
                    {
                        Airbus b = (Airbus)(this.Allplane[i]);
                        n += b.Capacity;
                    }
                }
                return n;
            }
            set
            {
                capacity += value;
            }
        }
            
    }
}
