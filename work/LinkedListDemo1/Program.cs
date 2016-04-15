using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE19__LinkedLists
{
    // test class
    class Program
    {
        static void Main(string[] args)
        {
            // create a linked list
            LinkedList list = new LinkedList();

            // populate the list
            list.Add("This");
            list.Add("is");
            list.Add("a");
            list.Add("test");
            list.Add("of");
            list.Add("a");
            list.Add("linked");
            list.Add("list");

            // traverse the list
            list.Traverse();

			// Allows the console to display at the end.
			Console.ReadLine();
        }
    }
}
