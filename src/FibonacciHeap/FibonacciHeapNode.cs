namespace FibonacciHeap
{
    public class FibonacciHeapNode<T>
    {
        public FibonacciHeapNode(T data, double key)
        {
            Right = this;
            Left = this;
            Data = data;
            Key = key;
        }

        public T Data { get; }
        public FibonacciHeapNode<T> Child { get; set; }
        public FibonacciHeapNode<T> Left { get; set; }
        public FibonacciHeapNode<T> Parent { get; set; }
        public FibonacciHeapNode<T> Right { get; set; }
        public bool Mark { get; set; }
        public double Key { get; set; }
        public int Degree { get; set; }
    }
}