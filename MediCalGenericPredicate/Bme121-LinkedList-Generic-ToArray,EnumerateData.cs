using System.Collections.Generic;

namespace Bme121
{
    partial class LinkedList< TData >
    {
        // Convert the linked list to an array of its data elements.

        public TData[ ] ToArray( )
        {
            TData[ ] result = new TData[ Count ];

            int i = 0;
            Node? currentNode = Head;
            while( currentNode != null )
            {
                result[ i ] = currentNode.Data;

                i ++;
                currentNode = currentNode.Next;
            }

            return result;
        }

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
