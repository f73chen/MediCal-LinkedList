using System;
using static System.Console;
using MediCal;

namespace Bme121
{
    partial class LinkedList< TData >
    {
        public bool Contains( Predicate< TData > IsTarget )
        {
			Node? currentNode = Head;
			while(currentNode != null) {
				if(IsTarget(currentNode.Data)) { return true; }
				currentNode = currentNode.Next;
			}
			return false;
        }

        public bool Remove( out TData removedData, Predicate< TData > IsTarget )
        {
			Node? previousNode = null!; //because currentNode is the first one
			Node? currentNode = Head;
			while(currentNode != null) {
				if(IsTarget(currentNode.Data)) { 
					removedData = currentNode.Data;
					if(currentNode == Head) { Head = currentNode.Next; }
					else previousNode.Next = currentNode.Next; //if currentNode == Head, previousNode is null and can't have a .Next property
					currentNode.Next = null; //in case it's accidentally called
					if(currentNode == Tail) { Tail = previousNode; }
					Count--;
					return true;
				}
				previousNode = currentNode; //when it stops, previousNode will reach Tail
				currentNode = currentNode.Next;
			}
            removedData = default( TData )!; //returns default if doesn't find it
            return false;
        }
    }

    static class Program
    {
        static void Main( )
        {
            // Get an array of 'Drug' objects for testing.

            Drug[ ] drugArray = Drug.ArrayFromFile( "RXQT1503-1.txt" );

            // Add the 'Drug' objects to a linked list then display it.

            LinkedList< Drug > drugList = new LinkedList< Drug >( );
            foreach( Drug d in drugArray) drugList.AddLast( d );
            WriteLine( );
            WriteLine( "drugList.Count = {0}", drugList.Count );
            WriteLine( "drugList" );
            foreach( Drug d in drugList.EnumerateData( ) ) WriteLine( d );

            // Test the 'Contains' method.

            bool answer;

            WriteLine( );
            WriteLine( "Does drugList contain a drug whose size is 100?" );
            answer = drugList.Contains( d => d.Size == 100 );
            WriteLine( "answer = {0}", answer );

            WriteLine( "Does drugList contain a drug whose name starts with 'KITTEN'?" );
            answer = drugList.Contains( d => d.Name.StartsWith( "KITTEN" ) );
            WriteLine( "answer = {0}", answer );

            // Test the 'Remove' method.
            Drug removedDrug;

            WriteLine( );
            WriteLine( "Can drugList remove a drug whose size is 100?" );
            answer = drugList.Remove( out removedDrug, d => d.Size == 100 );
            WriteLine( "answer = {0}", answer );
            WriteLine( "removedDrug = {0}", removedDrug );

            WriteLine( "Can drugList remove a drug whose name starts with 'KITTEN'?" );
            answer = drugList.Remove( out removedDrug, d => d.Name.StartsWith( "KITTEN" ) );
            WriteLine( "answer = {0}", answer );
            WriteLine( "removedDrug = {0}", removedDrug );

            WriteLine( );
            WriteLine( "drugList.Count = {0}", drugList.Count );
            WriteLine( "drugList" );
            foreach( Drug d in drugList.EnumerateData( ) ) WriteLine( d );

            WriteLine( );
        }
    }
}
