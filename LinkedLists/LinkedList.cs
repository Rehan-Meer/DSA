using DSA.LinkedLists;

namespace DSA
{
    public class LinkedList
    {
        private Node? Head;
        public LinkedList() => Head = null;

        public void Add(int value)
        {
            Node newNode = new(value, null);
            if (Head == null)
                Head = newNode;
            else
            {
                Node Current = Head;
                while (Current.Next != null)
                    Current = Current.Next;
                Current.Next = newNode;
            }
        }

        public void Remove(int _value)
        {
            if (Head == null) return;

            if (Head.Value == _value)
            {
                Head = Head.Next;
                return;
            }
            Node? iterator = Head;
            while (iterator?.Next!= null)
            {
                if (iterator.Next?.Value == _value)
                {
                    iterator.Next = iterator.Next?.Next;
                    return;
                }
                iterator = iterator.Next;
            }
        }

        public void Display()
        {
            Node? current = Head;
            while (current?.Next != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            Console.WriteLine(current?.Value + " -> null");
        }
    }
}
