namespace DSA.LinkedLists
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }

        public Node(int _value, Node? _next = null)
        {
            Value = _value;
            Next = _next;
        }
    }
}
