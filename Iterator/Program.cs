﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_01.Pattern;
using System.Collections;

// Iterator Design Pattern.

namespace Iterator_01
{
    class Program
    {
        static void Main()
        {
            Aggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Element A";
            aggregate[1] = "Element B";
            aggregate[2] = "Element C";
            aggregate[3] = "Element D";

            Iterator iterator = aggregate.CreateIterator();


            Console.WriteLine("Первый элемент коллекции:");

            object element = iterator.First();
            Console.WriteLine(element);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Итерация по коллекции:");
            while (!iterator.IsDone())
            {
                Console.WriteLine(element);
                element = iterator.Next();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
