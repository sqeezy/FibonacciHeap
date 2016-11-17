using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FibonacciHeap;

namespace FibonacciHeap.Tests
{
    public class FibonacciHeapFacts
    {
        private FibonacciHeapNode<int, double> _node;
        private FibonacciHeap<int, double> _sut;

        [Fact]
        public void It_can_be_constructed()
        {
            WhenSutIsCreated();
        }

        [Fact]
        public void It_can_store_an_element_of_data()
        {
            GivenNode();
            WhenSutIsCreated();
            _sut.Insert(_node);
        }

        private void GivenNode()
        {
            _node = new FibonacciHeapNode<int, double>(0, 0);
        }

        private void WhenSutIsCreated()
        {
            _sut = new FibonacciHeap<int, double>(double.NegativeInfinity);
        }
    }
}
