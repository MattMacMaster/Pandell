using System;
using System.Linq;

namespace Pandell
{
    class PandellProgram
    {
        static void Main(string[] args)
        {
            //generates a list of 10,000 numbers in random order each time it is run. 
            // Each number in the list must be unique and be between 1 and 10,000(inclusive)

            //All numbers in the list are present and only oncem, so we can simply create the 1 to 10,000 list
            // and promply randomize the organized list.
            const int listSize = 10000;
            var rand = new Random();
            //Using a random number to order the list by, and randomizing the list that contains all the values needed.
            var randomList = Enumerable.Range(1, listSize).OrderBy(e => rand.Next()).ToList();

            var listOutput = string.Join(", ", randomList);
            Console.WriteLine(listOutput);

            //Tests to see if any duplicates exist by comparing the list count to the total unique entries which should be equal
            if (randomList.Count != randomList.Distinct().Count())
            {
                Console.WriteLine("Found Duplicates");
            };
        }
    }
}
