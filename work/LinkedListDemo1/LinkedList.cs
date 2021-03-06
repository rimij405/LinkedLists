﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE19__LinkedLists
{
    // implement a singly linked list
    class LinkedList
    {
        // attributes
        private Node head = null; // initially nothing in the list
        private int count = 0;

		public int Count
		{
			get { return this.count; }
		}

        // add an item to the list
        public void Add(string str)
        {
            // create the new node
            Node newNode = new Node(str);

            // special case - nothing in the list
            if(head == null)
            {
                head = newNode;
                count++;
                return;
            }

            // if we get here there's something in the list
            Node current = head;
            while(current.Next != null)
            {
                // move to next node in the list
                current = current.Next;
            }

            // now at end of the list
            current.Next = newNode; // add the new node at the end of the list
            count++; // We add the count on addition, instead of calculating it each time.
        }

        // traverse the list, printing all data
        public void Traverse()
        {
            // special case - no list
            if(head == null)
            {
                Console.WriteLine("No data in the list");
                return;
            }

            // loop through all of the items in the list
            Node current = head;
            while(current.Next != null)
            {
                // list the current node
                Console.WriteLine(current);

                // move to next node
                current = current.Next;
            }

            // still need to list the last node in the list
            Console.WriteLine(current);
        }

		// Assignment information:
		/*************************
		
		Create a method called GetData.
		It should take an int as a parameter.
		It should return a string.

		Check to see if index input is invalid.

		**************************/
		public string GetData(int index)
		{
			// If the index is invalid (less than zero or >= the count) return null.
			if ((index < 0) || (index >= count)) { return null; }

			// Else, if index is valid:
			// Double check to see if the first node is null.
			if (head == null)
			{
				Console.WriteLine("No data in the list");
				return null;
			}

			// Loop through, starting at the head node.
			Node current = head;
			for(int i = 0; i <= index; i++)
			{
				// move to next node
				current = current.Next;
			}

			// Get and return the collected data.
			return current.Data;			
		}
    }
}
