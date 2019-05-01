using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumeratorIEnumerableYield_03.Collection
{
    // Создание простой пользовательской коллекции с использованием оператора yield.
    // Класс, представляющий собой пользовательскую коллекцию.
    public class UserCollection<T>
    {
        readonly T[] elements = new T[4];

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        int position = -1;

        // Создаем метод Reset().
        public void Reset()
        {
            position = -1;
        }

        // Создаем метод GetEnumerator(), используем оператор yield.
        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < elements.Length - 1)
                {
                    position++;
                    yield return elements[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }

            //foreach (var element in elements)
            //{
            //    yield return element;
            //}

            //return elements.GetEnumerator();
        }
    }
}
