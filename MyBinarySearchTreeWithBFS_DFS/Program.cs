using System;
using System.Text.Json;

namespace MyBinarySearchTreeWithBFS_DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractBinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(12);
            bst.Insert(21);
            bst.Insert(5);
            bst.Insert(1);
            bst.Insert(8);
            bst.Insert(18);
            bst.Insert(23);
            
            TreePrinter<int>.Print(bst);
            
            Console.Write("Bfs: ");
            bst.PrintBfs();
            
            Console.Write("Dfs: ");
            bst.PrintDfs();
        }
    }
}