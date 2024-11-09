using DSA.Trees;

namespace DSA
{
    public class DataStructures
    {
        public static void Main()
        {
            var input = new Node(7,
            new Node(5, new Node(4), new Node(6)),
            new Node(9, new Node(8), new Node(10)));
            Tree.TraverseBFS(input);
            Tree.TravesePreOrder(input);
            Tree.TravesePostOrder(input);
            Tree.TraveseInOrder(input);
            Console.ReadLine();
        }
    }
}