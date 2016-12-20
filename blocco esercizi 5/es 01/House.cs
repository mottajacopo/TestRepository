using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    public class House : PrivateProperty 
    {

        protected double area;

        public House(string location, bool inCity, double area, decimal houseValue) :
            base(location, inCity, houseValue)
        {
            this.area = area;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

       
    }
}
