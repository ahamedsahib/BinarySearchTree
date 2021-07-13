using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.AddNode(56);
            bst.AddNode(30);
            bst.AddNode(70);
            bst.AddNode(60);
            bst.AddNode(3);
            bst.AddNode(11);
            bst.AddNode(22);
            bst.AddNode(40);
            bst.AddNode(65);
            bst.AddNode(95);
            bst.AddNode(63);
            bst.AddNode(67);
            bst.AddNode(16);
            bst.Display(bst.root);
            bst.GetSize();
        }
    }
}
