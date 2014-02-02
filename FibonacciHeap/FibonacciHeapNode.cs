using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciHeap
{
    internal class FibonacciHeapNode<T>
    {
        private readonly T _element;

        private FibonacciHeapNode<T> _child;

        private int _degree;

        private FibonacciHeapNode<T> _left;

        private bool _marked;

        private FibonacciHeapNode<T> _parent;

        private FibonacciHeapNode<T> _right;

        public FibonacciHeapNode(T element)
        {
            _degree = 0;
            _left = this;
            _right = this;
            _marked = false;
            this._element = element;
        }

        public int Degree
        {
            get { return _degree; }
        }

        public T Element
        {
            get { return _element; }
        }

        public bool Marked
        {
            get { return _marked; }
            set { _marked = value; }
        }

        internal FibonacciHeapNode<T> Child
        {
            get { return _child; }
            set { _child = value; }
        }

        internal FibonacciHeapNode<T> Left
        {
            get { return _left; }
            set { _left = value; }
        }

        internal FibonacciHeapNode<T> Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        internal FibonacciHeapNode<T> Right
        {
            get { return _right; }
            set { _right = value; }
        }

        public void DecreaseDegree()
        {
            _degree--;
        }

        public void IncreaseDegree()
        {
            _degree++;
        }
    }
}