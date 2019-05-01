using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorIEnumerableYield_03.Collection
{
    // Создание простой пользовательской коллекции с использованием оператора yield.
    // Класс, представляющий собой содержимое коллекции.
    class Element
    {
        public int FieldA { get; set; }
        public int FieldB { get; set; }

        public Element(int fieldA, int fieldB)
        {
            FieldA = fieldA;
            FieldB = fieldB;
        }
    }
}
