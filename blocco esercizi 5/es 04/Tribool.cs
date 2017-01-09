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

        public static implicit operator TriBool(bool t)
        {
            if (t == true)
            {
                return new TriBool(1);
            }
            else
            {
                return new TriBool(-1);
            }
        }

        public static explicit operator bool (TriBool t)
        {
            if (t.value == 0)
            {
                throw new InvalidOperationException();
            }
            if (t.value == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static TriBool operator ==(TriBool t1, TriBool t2)
        {
            if (t1.value == t2.value)
            {
                return new TriBool(1); //se sono uguali ritorna true
            }
            else
            {
                return new TriBool(-1); //se sono diversi ritorna false
            }
        }

        public static TriBool operator !=(TriBool t1, TriBool t2)
        {
            if (t1.value != t2.value)
            {
                return new TriBool(1); //se sono diversi ritorna true
            }
            else
            {
                return new TriBool(-1); //se sono uguali ritorna false
            }

        }

        public static TriBool operator !(TriBool t)
        {
            return new TriBool(-t.value); //ritorna valore opposto, se indeterminato lo lascia invariato
        }

        public static TriBool operator &(TriBool t1, TriBool t2)
        {
            if (t1.value == 1 && t2.value == 1)
            {
                return new TriBool(1); //la AND da true solo se entrambi sono true
            }
            else
            {
                return new TriBool(-1); //altrimenti restituisce false
            }

        }

        public static TriBool operator |(TriBool t1, TriBool t2)
        {
            if (t1.value >= t2.value)
            {
                return new TriBool(t1.value);
            }
            else
            {
                return new TriBool(t2.value);
            }
        }

        public static bool operator true(TriBool t)
        {
            return t.value > 0;
        }

        public static bool operator false(TriBool t)
        {
            return t.value < 0;
        }
        public override bool Equals(object o)
        {
            try
            {
                return (bool)(this.value == ((TriBool)o).value);
            }
            catch
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return value;
        }
        public override string ToString()
        {
            if (value == -1)
            {
                return "false";
            }
            else if (value == 1)
            {
                return "true";
            }
            else
            {
                return "indeterminate";
            }
        }

    }
}