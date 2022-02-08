using System;

namespace MyBinarySearchTreeWithBFS_DFS
{
    public interface IAbstractBinarySearchTree<T> where T: IComparable
    {
        //Вставка элемента
        void Insert(T element);
        //Содержит ли дерево данный элемент?
        bool Contains(T element);
        //Поиск
        IAbstractBinarySearchTree<T> Search(T element);
        //Корень дерева/поддерева
        Node<T> Root { get;  }
        //Дочерний элемент слева
        Node<T> LeftChild { get;  }
        //Дочерний элемент справа
        Node<T> RightChild { get; }
        //Значение
        T Value { get; }



        public void PrintBfs();
        public void PrintDfs();
    }
}