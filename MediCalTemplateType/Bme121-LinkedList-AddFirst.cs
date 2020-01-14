using System;
using MediCal;

namespace Bme121
{
    partial class LinkedList<TData>
    {
        // Add a new item at the beginning of the linked list.

        public void Prepend( TData newData ) { AddFirst( newData ); }

        public void AddFirst( TData newData )
        {
            if( newData == null ) throw new ArgumentNullException( nameof( newData ) ); //not possible for int to be null

            Node  newNode = new Node( newData );
            Node? oldHead = Head;

            if( Tail == null ) Tail = newNode;
            else newNode.Next = oldHead;
            Head = newNode;

            Count ++;
        }
    }
}
