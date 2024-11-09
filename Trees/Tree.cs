namespace DSA.Trees
{
    public class Tree
    {
        public static void TraverseBFS(Node _root)
        {
            List<int> result = [];
            Queue<Node> myQueue = new();
            myQueue.Enqueue(_root);
            while (myQueue.Count > 0)
            {
                Node node = myQueue.Dequeue();
                result.Add(node.Value);
                if (node.Left != null)
                    myQueue.Enqueue(node.Left);
                if (node.Right != null)
                    myQueue.Enqueue(node.Right);
            }
            Console.WriteLine("Breadth First Search: " + string.Join(",", result));
        }
        public static void TravesePreOrder(Node _root) //Root, Left, Right
        {
            if (_root == null)
                return;
            List<int> result = [];
            Stack<Node> stack = new();
            stack.Push(_root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                result.Add(node.Value);

                if (node.Right != null)
                    stack.Push(node.Right);
                if (node.Left != null)
                    stack.Push(node.Left);
            }
            Console.WriteLine("PreOrder Tree Treversal: " + string.Join(",", result));
        }
        public static void TravesePostOrder(Node _root) // Left, Right, Root
        {
            if (_root == null)
                return;
            Stack<Node> stack1 = new();
            Stack<Node> stack2 = new();
            stack1.Push(_root);
            while (stack1.Count > 0)
            {
                var node = stack1.Pop();
                stack2.Push(node);
                if (node.Left != null)
                    stack1.Push(node.Left);
                if (node.Right != null)
                    stack1.Push(node.Right);
            }
            Console.WriteLine("PostOrder Tree Treversal: " + string.Join(",", stack2.Select(d => d.Value).ToList()));
        }
        public static void TraveseInOrder(Node _root) // Left, Root, Right
        {
            if (_root == null)
                return;

            Stack<Node> stack = new();
            List<int> result = [];
            Node Current = _root;
            while (Current != null || stack.Count > 0)
            {
                if (Current != null)
                {
                    stack.Push(Current);
                    Current = Current.Left;
                }
                if (Current == null)
                {
                    Current = stack.Pop();
                    result.Add(Current.Value);
                    Current = Current.Right;
                }
            }
            Console.WriteLine("InOrder Tree Treversal: " + string.Join(",", result));
        }
    }
}