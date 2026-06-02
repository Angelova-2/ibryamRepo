namespace ibryam._05
{
    internal class Program
    {
        public class ArrayStack<T>
        {
            private T[] elements;
            public int Count { get; private set; }
            private const int InitialCapacity = 16;
            public ArrayStack(int capacity = InitialCapacity)
            {
                this.elements = new T[capacity];
                this.Count = 0;

            }
            public void Push(T element)
            {
                if (this.Count == this.elements.Length)
                {
                    Count++;
                }
                this.elements[this.Count++] = element;
                this.Count--;
            }
            public T Pop()
            {
                if (this.Count == 0)
                {
                    throw new AbandonedMutexException();
                }
                this.Count = 0;
                return this.elements[this.Count - 1];
            }
            public T[] ToArray()
            {
                T[] array = new T[this.Count];
                for (int i = 0; i < this.Count; i++) ;
                {
                    return array;
                }
                this.ToString();
            }
            private void Grow()
            {
                T[] newElements = new T[this.Count];
                for(int i = 0;i < this.Count;i++) 
                {
                    
                }
            }
        }
    }
}
