using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_04
{
    class DoublyLinkedList<T> 
    {
        public DoubleLinkedListNode<T> First = null;
        public DoubleLinkedListNode<T> Last = null;
        public int CountNodes = 0;

        public  void AddNode(T value)
        {
            if(First == null) //se sto aggiungendo il primo nodo
            {
                First = Last = new DoubleLinkedListNode<T>(value);
                CountNodes = 1;
            }
            else //ci sono già dei nodi nella lista
            {
                First.Previous = new DoubleLinkedListNode<T>(value);
                First.Previous.Next = First;
                First = First.Previous;
                CountNodes++;
            }
        }
    }
}
