using System;

namespace MyBinarySearchTreeWithBFS_DFS
{
    public static class TreePrinter<T> where T: IComparable
    {
        static readonly int COUNT = 10;  
        private static void Print(Node<T> root, int space)  
        {  
            if (root == null)  
                return;  
            space += COUNT;  

            Print(root.RightChild, space);  

            Console.Write("\n");  
            for (int i = COUNT; i < space; i++)  
                Console.Write(" ");  
            Console.Write(root.Value + "\n");  

            Print(root.LeftChild, space);  
        }
        
        public static void Print(IAbstractBinarySearchTree<T> tree)  
        {  
            Print(tree.Root, 0);  
        }
    }
}