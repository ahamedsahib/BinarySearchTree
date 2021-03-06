using System;
namespace BinarySearchTree
{
         class BinaryTree<T>
        {
            public T value;
            public BinaryTree<T> Left;
            public BinaryTree<T> Right;
            public BinaryTree(T value)
            {
                this.value = value;
                this.Left = null;
                this.Right = null;
            }
        }
        
        class BinarySearchTree<T> where T : IComparable
        {
            public BinaryTree<T> root;
            int leftCount = 0;
            int rightCount = 0;
            bool result;
        public void AddNode(T value)
            {
                BinaryTree<T> newNode = new BinaryTree<T>(value);
                
                if (root == null)
                {
                    root = newNode;
                }
                
                else
                {
                    BinaryTree<T> parent = root;
                    BinaryTree<T> current = root;
                    
                    while (true)
                    {
                    parent = current;
                    if (current.value.CompareTo(value) >= 0)
                        {
                            current = current.Left;
                            if (current == null)
                            {
                                parent.Left = newNode;
                                leftCount++;
                                break;
                            }
                        }

                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                rightCount++;
                                break;
                            }
                        }
                    }
                }
            }
        public bool SearchNode(BinaryTree<T> node, int value)
        {
           
            if (null == node)
            {
                return false;
            }
            // we found the value
            if (node.value.Equals(value))
            {
                result= true;
            }
            else if (value.CompareTo(node.value)<0)
                 SearchNode(node.Left, value);
            else if(value.CompareTo(node.value) >0)
            {
                 SearchNode(node.Right, value);
            }
            return result;
        }


        public void GetSize()
            {
                Console.WriteLine($"Size of Tree = {this.leftCount + this.rightCount + 1}");
            }

            public void Display(BinaryTree<T> parent)
            {
                if (parent != null)
                {
                    Display(parent.Left);
                    Console.WriteLine("The node :{0}", parent.value);
                    Display(parent.Right);
                }
            }


        }

}
