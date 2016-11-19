using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    class Display
    {
        private float inches = 0;
        private decimal colors = 0;

        public Display(float inches, decimal colors) : this(inches, colors)
        {
            this.inches = inches;
            this.colors = colors;
        }

        public float Inches
        {
            get
            {
                return this.inches;
            }
            set
            {
                this.inches = value;
            }
        }

        public decimal Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }
    }
}
