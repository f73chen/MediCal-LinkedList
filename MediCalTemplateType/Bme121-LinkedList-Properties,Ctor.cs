namespace Bme121
{
    partial class LinkedList<TData>
    {
        // Define the properties (fields) and constructor for the linked list.

        Node? Tail { get; set; }
        Node? Head { get; set; }
        public int Count { get; private set; }

        public LinkedList( )
        {
            Tail = null;
            Head = null;
            Count = 0;
        }
    }
}
