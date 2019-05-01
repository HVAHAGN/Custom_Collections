using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionIList_01
{
    class Program
    {
        static void Main()
        {
            var collection = new UserCollection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 2));

            var array = new object[collection.Count];

            collection.CopyTo(array, 0);

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
