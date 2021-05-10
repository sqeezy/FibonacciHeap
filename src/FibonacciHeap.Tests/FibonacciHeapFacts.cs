using Xunit;

namespace FibonacciHeap.Tests
{
    public class FibonacciHeapFacts
    {
        private FibonacciHeapNode<int, int> _nodeGeneric;
        private FibonacciHeap<int, int> _sutGeneric;
        private FibonacciHeapDoubleKey<int> _sut;
        private FibonacciHeapNodeDoubleKey<int> _nodeDoubleKey;

        [Fact]
        public void It_can_be_constructed()
        {
            WhenSutIsCreated();
        }

        [Fact]
        public void It_can_store_an_element_of_data()
        {
            WhenSutIsCreated();
            _sut.Insert(GivenDoubleKeyNode());
        }

        [Fact]
        public void IsEmpty_works()
        {
            WhenSutIsCreated();
            Assert.True(_sut.IsEmpty());
            _sut.Insert(GivenDoubleKeyNode());
            Assert.False(_sut.IsEmpty());
            _sut.Insert(GivenDoubleKeyNode());
            Assert.False(_sut.IsEmpty());
            _sut.RemoveMin();
            Assert.False(_sut.IsEmpty());
            _sut.RemoveMin();
            Assert.True(_sut.IsEmpty());
        }

        [Fact]
        public void It_can_be_constructed_generic()
        {
            WhenSutIsCreatedGeneric();
        }

        [Fact]
        public void It_can_store_an_element_of_data_generic()
        {
            GivenNodeGeneric();
            WhenSutIsCreatedGeneric();
            _sutGeneric.Insert(_nodeGeneric);
        }

        private static FibonacciHeapNodeDoubleKey<int> GivenDoubleKeyNode()
        {
            return new FibonacciHeapNodeDoubleKey<int>(0, 0);
        }

        private void WhenSutIsCreated()
        {
            _sut = new FibonacciHeapDoubleKey<int>();
        }

        private void GivenNodeGeneric()
        {
            _nodeGeneric = new FibonacciHeapNode<int, int>(0, 0);
        }

        private void WhenSutIsCreatedGeneric()
        {
            _sutGeneric = new FibonacciHeap<int, int>(int.MinValue);
        }
    }
}
