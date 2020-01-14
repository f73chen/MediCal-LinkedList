using System;
using static System.Console;

using MediCal;

namespace Bme121
{
	class Cat {
		public String Name { get; private set; }
		public Cat(String name) { Name = name; }
		public override string ToString() { return Name; }
	}

    static class Program
    {
        static void Main( )
        {
            // Read the drug data from a file into an array of 'Drug' objects.
            // This uses a method we wrote called 'ArrayFromFile' in our 'Drug' class.

            Drug[ ] drugArray = Drug.ArrayFromFile( "RXQT1503-10.txt" );
            WriteLine( "drugArray.Length = {0}", drugArray.Length );

            // Put the 'Drug' objects of the array onto our linked list.
            // This uses a method we wrote called 'AddFirst' in our 'LinkedList' class.

            LinkedList<Drug> myList = new LinkedList<Drug>( ); //linked list has to be told it's type when initialized
            foreach( Drug d in drugArray )
            {
                myList.AddLast( d );
            }
            WriteLine( "myList.Count = {0}", myList.Count );

            // Create another array from the 'Drug' objects on our linked list.
            // This uses a method we wrote called 'ToArray' in our 'LinkedList' class.
            // We do this to see if we get back the expected content.

            Drug[ ] myArray = myList.ToArray( );
            WriteLine( "myArray.Length = {0}", myArray.Length );
            if( myArray.Length > 0 ) WriteLine( "myList content:" );
            foreach( Drug d in myList.EnumerateData())
            {
                WriteLine( d );
            }

			LinkedList<Cat> myCats = new LinkedList<Cat>();
			myCats.AddLast(new Cat("Suzie"));
			myCats.AddLast(new Cat("Char"));
			myCats.AddLast(new Cat("Mojo"));
			myCats.AddLast(new Cat("Ouzou"));
			if(myCats.Count > 0) { WriteLine("My cats: "); }
			foreach(Cat c in myCats.EnumerateData()) {
				WriteLine(c);
			}
        }
    }
}
