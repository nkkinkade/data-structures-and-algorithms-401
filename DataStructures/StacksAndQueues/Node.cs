using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    class Node
    {
        public T Value { get; set; }

        private string stringValue;

        public Node(T value)
        {
            Value = value;
        }

        // Value of this node
        

        // Pointer to the next node in the list
        public Node Next { get; set; }
    }
}
