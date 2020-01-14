using System.Collections.Generic;
using MediCal;

namespace Bme121
{
    partial class LinkedList<TData>
    {
        // Return the data in the linked list as an enumeration, which
        // is the minimum type needed for use in a 'foreach' loop.
        // The 'yield return' gives one item in the enumeration and lets
        // the method execution pause at that point until the next item
        // in the enumeration is needed.
        // You do not need to understand this code for BME 121.

        public IEnumerable< TData > EnumerateData( )
        {
            Node? currentNode = Head;
            while( currentNode != null )
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;
            }
        }
    }
}
