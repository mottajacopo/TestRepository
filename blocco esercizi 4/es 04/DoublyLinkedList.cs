using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_04
{
    public class DoubleLinkedList<T> where T : IComparable
    {
        
        private DoubleLinkedListNode<T> first;
        private DoubleLinkedListNode<T> last;
        public DoubleLinkedListNode<T> First
        {
            get
            {
                return first;
            }
            private set
            {
                first = value;
            }
        }
        public DoubleLinkedListNode<T> Last
        {
            get
            {
                return last;
            }
            private set
            {
                last = value;
            }
        }
        
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }
        public DoubleLinkedList()
        {
            Count = 0;
            First = null;
            Last = null;
        }
        public DoubleLinkedList(params T[] values) : this()
        {
            for (int i = 0; i < values.Length; i++)
            {
                InsertElement(values[i], i);
            }
        }
        public DoubleLinkedList<T> AddElementToStart(T value)
        {
            DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(value);

            if (First != null)
            {
                First.Previous = node;
            }

            node.Next = First;
            First = node;
            Count++;

            return this;
        }
        public DoubleLinkedList<T> AddElementToLast(T value)
        {
            DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(value);

            if (Last != null)
            {
                Last.Next = node;
            }

            node.Previous = Last;
            Last = node;
            Count++;

            return this;
        }

        public DoubleLinkedList<T> InsertElement(T value, int index)
        {
            int counter = 0;
            DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(value);
            DoubleLinkedListNode<T> iterator = First;
            DoubleLinkedListNode<T> prev = null;

            while (iterator != null && counter < index)
            {
                counter++;
                prev = iterator;
                iterator = iterator.Next;
            }

            node.Previous = prev;
            node.Next = iterator;
            if (prev != null)
            {
                prev.Next = node;
            }
            if (iterator != null)
            {
                iterator.Previous = node;
            }

            if (counter == 0)
            {
                First = node;
            }

            Count++;

            if (counter == Count - 1)
            {
                Last = node;
            }

            return this;
        }

        public DoubleLinkedListNode<T> FindElement(T value)
        {
            DoubleLinkedListNode<T> iterator = First;

            while (iterator != null && iterator.Value.CompareTo(value) != 0)
            {
                iterator = iterator.Next;
            }

            return iterator;
        }

        public DoubleLinkedList<T> RemoveElement(T value)
        {
            DoubleLinkedListNode<T> node = FindElement(value);
            DoubleLinkedListNode<T> previous = node.Previous;
            DoubleLinkedListNode<T> next = node.Next;

            if (previous != null)
            {
                previous.Next = next;
            }
            else
            {
               First = node.Next;
            }

            if (next != null)
            {
                next.Previous = previous;
            }
            else
            {
                Last = node.Previous;
            }

            Count--;

            return this;
        }

        public T[] ReturnToArray()
        {
            T[] array = new T[Count];

            DoubleLinkedListNode<T> iterator = First;
            int counter = 0;
            while (iterator != null)
            {
                array[counter++] = iterator.Value;
                iterator = iterator.Next;
            }

            return array;
        }
    }
}
