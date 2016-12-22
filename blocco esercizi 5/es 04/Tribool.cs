using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_04
{
    public class TriBool
    {
        private int value; // -1 = false, 0 = indet, 1 = true

        public TriBool(int value)
        {
            this.value = value;
        }

        public static implicit operator TriBool(bool x)
        {
            if (x == true)
            {
                return new TriBool(1);
            }
            else
            {
                return new TriBool(-1);
            }
        }

        public static explicit operator bool (TriBool x)
        {
            if (x.value == 0)
            {
                throw new InvalidOperationException();
            }
            if (x.value == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static TriBool operator ==(TriBool x, TriBool y)
        {
            if (x.value == y.value)
            {
                return new TriBool(1); //se sono uguali ritorna true
            }
            else
            {
                return new TriBool(-1); //se sono diversi ritorna false
            }
        }

        public static TriBool operator !=(TriBool x, TriBool y)
        {
            if (x.value != y.value)
            {
                return new TriBool(1); //se sono diversi ritorna true
            }
            else
            {
                return new TriBool(-1); //se sono uguali ritorna false
            }

        }

        public static TriBool operator !(TriBool x)
        {
            return new TriBool(-x.value); //ritorna valore opposto, se indeterminato lo lascia invariato
        }

        public static TriBool operator &(TriBool x, TriBool y)
        {
            if (x.value == 1 && y.value == 1)
            {
                return new TriBool(1); //la AND da true solo se entrambi sono true
            }
            else
            {
                return new TriBool(-1); //altrimenti restituisce false
            }

        }

        public static TriBool operator |(TriBool x, TriBool y)
        {
            if (x.value >= y.value)
            {
                return new TriBool(x.value);
            }
            else
            {
                return new TriBool(y.value);
            }
        }

        public static bool operator true(TriBool x)
        {
            return x.value > 0;
        }

        public static bool operator false(TriBool x)
        {
            return x.value < 0;
        }

        public override string ToString()
        {
            switch (value)
            {
                case -1:
                    return "false";
                case 0:
                    return "indeterminate";
                case 1:
                    return "true";
                default:
                    throw new InvalidOperationException();
            }
        }

    }
}