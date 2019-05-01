using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using IEnumeratorIEnumerableYield_01.Collection;

namespace IEnumeratorIEnumerableYield_01
{
    class Program
    {
        // Создание простой пользовательской коллекции.
        static void Main()
        {

            // Создаем коллекцию.
            var сollection = new UserCollection();

            // Помещаем в коллекцию 4 элемента.
            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8); 

            Console.WriteLine("Foreach 1");
            // В циклической конструкции foreach выводим содержимое коллекции на экран.
            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}",
                    element.FieldA,
                    element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            Console.WriteLine("Foreach 2");

            // В циклической конструкции foreach выводим содержимое коллекции на экран.
            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}",
                    element.FieldA,
                    element.FieldB);
            }

            Console.WriteLine(new string('-', 5));
            Console.WriteLine("Manual 1");

            var enumerator =((IEnumerable)сollection).GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element =(Element)enumerator.Current;

                Console.WriteLine("{0}, {1}",
                  element.FieldA,
                  element.FieldB);
            }

            if (сollection is IDisposable)
                ((IDisposable)сollection).Dispose();

            // Delay.
            Console.ReadKey();
        }
    }
}
