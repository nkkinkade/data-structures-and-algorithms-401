using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class Stack<T>
    {
        private Node top;

        public void Push(T value)
        {
            Node newNode = new Node(value);
        }
        class Node
        {
            public T Value { get; set; }

            private string stringValue;

            public Node(T value)
            {
                Value = value;
            }

            public Node Next { get; set; }
        }
    }
}
