using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_04
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode<T> Previous { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }
        public T value;

        
        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public DoubleLinkedListNode(T value)
        {
            this.Value = value;
        }

    }
}
