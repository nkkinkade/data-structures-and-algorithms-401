using System;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void Append(int nodeValue)
        {
            Node newNode = new Node(nodeValue);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node curr = Head;
            while (curr.Next != null)
                curr = curr.Next;

            curr.Next = newNode;
        }

        public void InsertBefore(int value, int newVal)
        {
            Node newNode = new Node(newVal);
            Node curr = Head;

            while (curr.Next != null)
                if (curr.Next.Value == value)
                {
                    newNode.Next = curr.Next;
                    curr.Next = newNode;
                    break;
                }
            curr = curr.Next;
        }

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }

        public bool Includes(int value)
        {
            Node current = Head;
            int input = value;
            while (current != null)
            {
                if (current.Value == input)
                    return true;

                current = current.Next;
            }
            return false;
        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }
            return result + "NULL";
        }

        public int Search(int value)
        {
            Node current = Head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            if (value > count)
            {
                throw new NullReferenceException();
            }
            current = Head;
            for (int i = 0; i < count - value; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }
}

