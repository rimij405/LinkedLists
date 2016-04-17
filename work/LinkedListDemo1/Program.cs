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
			// Random object.
			Random r = new Random();

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
			Console.WriteLine("\nTraverse:");
            list.Traverse();

			// get the data
			Console.WriteLine("\nData Collection:");

			int lowerLimit = 0; // Inclusive.
			int upperLimit = list.Count; // Exclusive.
			int loopCount = 10; // Change this to affect the number of lines to print.

			for (int i = 1; i <= loopCount; i++)
			{
				int indexValue = r.Next(lowerLimit, (upperLimit - 1));
				Console.WriteLine("Loop #" + i + ":\"" + list.GetData(indexValue) + "\" - from index value: " + indexValue + ".");
			}

			// Allows the console to display at the end.
			Console.ReadLine();
        }
    }
}
