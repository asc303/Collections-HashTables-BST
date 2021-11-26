using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Demo");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(46);
            binarySearch.Insert(50);
            binarySearch.Insert(48);
            binarySearch.Insert(79);
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}
