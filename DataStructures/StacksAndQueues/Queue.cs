using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class Queue<T>
    {
        private Node front;
        private Node rear;

        public void Enqueue(T value)
        {
            if (rear == null)
            {
                rear = new Node(value);
                front = rear;
            }
            else
            {
                Node newNode = new Node(value);
                rear.Next = newNode;
                rear = newNode;
            }

        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new ArgumentException();
            }

            Node frontValue = front;
            front = front.Next;

            return frontValue.Value;
        }

        public T Peek()
        {
            if (front == null)
            {
                throw new ArgumentException();
            }
            return front.Value;
        }

        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
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
