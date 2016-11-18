namespace FibonacciHeap
{
    /// <summary>
    /// Implements the Fibonacchi heap class with the key of type double.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FibonacciHeapDoubleKey<T> : FibonacciHeap<T, double>
    {
        /// <summary>
        /// Constructor. 
        /// Initializes the new instance.
        /// Declares the double.NegativeInfinity as minimum possible key value.
        /// </summary>
        public FibonacciHeapDoubleKey( ) : base( double.NegativeInfinity )
        {
        }
    }
}
