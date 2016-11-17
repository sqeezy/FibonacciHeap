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
        private FibonacciHeapNodeGenericKey<int, int> _nodeGeneric;
        private FibonacciHeapGenericKey<int, int> _sutGeneric;
        private FibonacciHeap< int > _sut;
        private FibonacciHeapNode< int > _node;

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

        private void GivenNode( )
        {
            _node = new FibonacciHeapNode< int >( 0, 0 );
        }

        private void WhenSutIsCreated( )
        {
            _sut = new FibonacciHeap< int >(  );
        }

        private void GivenNodeGeneric()
        {
            _nodeGeneric = new FibonacciHeapNodeGenericKey<int, int>(0, 0);
        }

        private void WhenSutIsCreatedGeneric()
        {
            _sutGeneric = new FibonacciHeapGenericKey<int, int>(int.MinValue);
        }
    }
}
