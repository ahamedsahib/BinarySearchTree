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
            bst.AddNode(79);
            bst.Display(bst.root);
        }
    }
}
