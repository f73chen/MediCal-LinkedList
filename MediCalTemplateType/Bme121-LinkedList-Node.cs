using System;
using MediCal;

namespace Bme121
{
    partial class LinkedList<TData> //carries generic type
    {
        // Define the 'Node' class used to form the linked list.

        class Node
        {
            public Node? Next { get;         set; }
            public TData  Data { get; private set; } //replaces all instances of "Drug" with TData

            public Node( TData newData )
            {
                if( newData == null ) throw new ArgumentNullException( nameof( newData ) );

                Next = null;
                Data = newData;
            }
        }
    }
}
