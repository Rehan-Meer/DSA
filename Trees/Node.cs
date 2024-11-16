namespace DSA.Trees
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int _value, Node? _leftNode = null, Node? _rightNode = null)
        {
            Value = _value;
            Left = _leftNode;
            Right = _rightNode;
        }
    }
}