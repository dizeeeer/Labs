using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
        public class SimpleListItem<T>
        {
            public T data { get; set; }

            public SimpleListItem<T> next { get; set; }

            public SimpleListItem(T param)
            {
                this.data = param;
            }
        }

        public class SimpleList<T> : IEnumerable<T>
            where T : IComparable
        {
            protected SimpleListItem<T> first = null;
            protected SimpleListItem<T> last = null;
            public int Count
            {
                get { return _count; }
                protected set { _count = value; }
            }
            int _count;

            public void Add(T element)
            {
                SimpleListItem<T> newItem = new SimpleListItem<T>(element);
                this.Count++;
                if (last == null)
                {
                    this.first = newItem;
                    this.last = newItem;
                }
                else
                {
                    this.last.next = newItem;
                    this.last = newItem;
                }
            }

            public SimpleListItem<T> GetItem(int number)
            {
                if ((number < 0) || (number >= this.Count))
                {
                    throw new Exception("Выход за границу индекса");
                }

                SimpleListItem<T> current = this.first;
                int i = 0;
                while (i < number)
                {
                    current = current.next;
                    i++;
                }

                return current;
            }

            public T Get(int number)
            {
                return GetItem(number).data;
            }

            public IEnumerator<T> GetEnumerator()
            {
                SimpleListItem<T> current = this.first;

                while (current != null)
                {
                    yield return current.data;
                    current = current.next;
                }
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void Sort()
            {
                Sort(0, this.Count - 1);
            }

            private void Sort(int low, int high)
            {
                int i = low;
                int j = high;
                T x = Get((low + high) / 2);
                do
                {
                    while (Get(i).CompareTo(x) < 0) ++i;
                    while (Get(j).CompareTo(x) > 0) --j;
                    if (i <= j)
                    {
                        Swap(i, j);
                        i++; j--;
                    }
                } while (i <= j);

                if (low < j) Sort(low, j);
                if (i < high) Sort(i, high);
            }

            private void Swap(int i, int j)
            {
                SimpleListItem<T> ci = GetItem(i);
                SimpleListItem<T> cj = GetItem(j);
                T temp = ci.data;
                ci.data = cj.data;
                cj.data = temp;
            }
        }  
}
