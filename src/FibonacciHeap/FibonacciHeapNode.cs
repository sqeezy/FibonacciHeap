namespace FibonacciHeap
{
    public class FibonacciHeapNode<T, TKey> where TKey: System.IComparable
    {
        public FibonacciHeapNode(T data, TKey key)
        {
            Right = this;
            Left = this;
            Data = data;
            Key = key;
        }

        public T Data { get; }
        public FibonacciHeapNode<T, TKey> Child { get; set; }
        public FibonacciHeapNode<T, TKey> Left { get; set; }
        public FibonacciHeapNode<T, TKey> Parent { get; set; }
        public FibonacciHeapNode<T, TKey> Right { get; set; }
        public bool Mark { get; set; }
        public TKey Key { get; set; }
        public int Degree { get; set; }
    }
}