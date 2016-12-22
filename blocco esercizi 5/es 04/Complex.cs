using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_04
{
    public class Complex
    {
        private int a; //parte reale
        private int b; //parte immaginaria

        public int A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public int B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.a + z2.a, z1.b + z2.b);
        }
        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.a - z2.a, z1.b - z2.b);
        }
        public static Complex operator *(Complex z1, Complex z2)
        {
            int real = z1.a * z2.a - z1.b * z2.b;
            int imaginary = z1.a * z2.b + z1.b * z2.a;

            return new Complex(real, imaginary);
        }
        public static Complex operator /(Complex z1, Complex z2)
        {
            int real = (z1.a * z2.a + z1.b * z2.b) / (z2.a * z2.a + z2.b * z2.b);
            int imaginary = (z1.b * z2.a - z1.a * z2.b) / (z2.a * z2.a + z2.b * z2.b);
            return new Complex(real, imaginary);
        }
        public static Complex operator ~(Complex z1)
        {
            return new Complex(z1.a, - z1.b);
        }
        public string ToStringForm()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(a);
            if (b>0)
            {
                sb.Append(" +");
                sb.Append(b);
                sb.Append('i');
            }
            if (b<0) {
                sb.Append(" ");
                sb.Append(b);
                sb.Append('i');
            }
         
            return sb.ToString();
        }
    }
}

