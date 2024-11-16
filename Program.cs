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

            var myLinkedList = new LinkedList();
            myLinkedList.Add(1);
            myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Add(4);
            myLinkedList.Display();
            myLinkedList.Remove(1);
            myLinkedList.Display();
            myLinkedList.Remove(3);
            myLinkedList.Display();
            myLinkedList.Remove(4);
            myLinkedList.Display();
            myLinkedList.Remove(2);
            myLinkedList.Display();
            Console.ReadLine();
        }
    }
}