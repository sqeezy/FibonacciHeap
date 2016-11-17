namespace FibonacciHeap
{
    public class FibonacciHeapNodeGenericKey<T, TKey> where TKey: System.IComparable
    {
        public FibonacciHeapNodeGenericKey(T data, TKey key)
        {
            Right = this;
            Left = this;
            Data = data;
            Key = key;
        }

        public T Data { get; }
        public FibonacciHeapNodeGenericKey<T, TKey> Child { get; set; }
        public FibonacciHeapNodeGenericKey<T, TKey> Left { get; set; }
        public FibonacciHeapNodeGenericKey<T, TKey> Parent { get; set; }
        public FibonacciHeapNodeGenericKey<T, TKey> Right { get; set; }
        public bool Mark { get; set; }
        public TKey Key { get; set; }
        public int Degree { get; set; }
    }
}