﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumeratorIEnumerableYield_04.Collection
{
    // Создание простой пользовательской коллекции с явной реализацией функций оператора yield.
    // Класс, представляющий собой пользовательскую коллекцию.
    public class UserCollection<T>
    {
        T[] elements;

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        public UserCollection()
        {
            this.elements = new T[4];
            this.position = -1;
        }

        int position = -1;

        // Создаем метод Reset().
        public void Reset()
        {
            position = -1;
        }

        // Создаем метод GetEnumerator().
        public IEnumerator GetEnumerator()
        {
            Enumerator enumerator = new Enumerator(0);

            enumerator.@this = (UserCollection<T>)this;

            return enumerator;
        }

        // Создаем вложенный класс Enumerator.
        private sealed class Enumerator : IEnumerator<object>, IEnumerator, IDisposable
        {
            // Поля класса:
            private int state;
            private object current;
            public UserCollection<T> @this;


            // Методы класса:
            public Enumerator(int state)
            {
                this.state = state;
            }

            public bool MoveNext()
            {
                switch (this.state)
                {
                    case 0:
                        this.state = -1;
                        break;

                    case 1:
                        this.state = -1;
                        break;

                    default:
                        goto Label_00A0;
                }

                if (this.@this.position < (this.@this.elements.Length - 1))
                {
                    this.@this.position++;
                    this.current = this.@this.elements[this.@this.position];
                    this.state = 1;
                    return true;
                }
                this.@this.Reset();

            Label_00A0:
                return false;
            }

            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {
            }

            // Свойства класса:
            object IEnumerator<object>.Current
            {
                get
                {
                    return this.current;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.current;
                }
            }
        }
    }
}
