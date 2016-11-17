namespace FibonacciHeap
{
    public class FibonacciHeapNode<T> : FibonacciHeapNodeGenericKey<T, double>
    {
        public FibonacciHeapNode( T data, double key ) : base( data, key )
        {
        }
    }
}
