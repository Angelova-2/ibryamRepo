using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
            public class CustomArrayList
        {
            private object[] arr;
            private int count;

            public int Count
            {
                get { return count; }
            }

            private static readonly int INITIAL_CAPACITY = 4;

            public CustomArrayList()
            {
                arr = new object[INITIAL_CAPACITY];
                count = 0;
            }

            private void Resize()
            {
                object[] newArr = new object[arr.Length * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }

            public void Add(object item)
            {
                if (count == arr.Length)
                {
                    Resize();
                }

                arr[count] = item;
                count++;
            }

            public void Insert(int index, object item)
            {
                if (index < 0 || index > count)
                    throw new ArgumentOutOfRangeException();

                if (count == arr.Length)
                {
                    Resize();
                }

                for (int i = count; i > index; i--)
                {
                    arr[i] = arr[i - 1];
                }

                arr[index] = item;
                count++;
            }

            public int IndexOf(object item)
            {
                for (int i = 0; i < count; i++)
                {
                    if (arr[i].Equals(item))
                        return i;
                }
                return -1;
            }

            public void Clear()
            {
                arr = new object[INITIAL_CAPACITY];
                count = 0;
            }

            public bool Contains(object item)
            {
                return IndexOf(item) != -1;
            }

            public object this[int index]
            {
                get
                {
                    if (index < 0 || index >= count)
                        throw new ArgumentOutOfRangeException();

                    return arr[index];
                }
                set
                {
                    if (index < 0 || index >= count)
                        throw new ArgumentOutOfRangeException();

                    arr[index] = value;
                }
            }

            public object Remove(int index)
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException();

                object removed = arr[index];

                for (int i = index; i < count - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                count--;
                return removed;
            }

            public int Remove(object item)
            {
                int index = IndexOf(item);
                if (index == -1)
                    return -1;

                Remove(index);
                return index;
            }
        }
    }
}

