using MediCal;

namespace Bme121
{
    partial class LinkedList<TData> //make sure to convert all parts of the class to generic type
    {
        // Convert the linked list to an array of its data elements.

        public TData[ ] ToArray( )
        {
            TData[ ] result = new TData[ Count ] ;

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
    }
}
