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
            binarySearch.Insert(45);
            binarySearch.Insert(36);
            binarySearch.Insert(84);
            binarySearch.Insert(09);
            binarySearch.Insert(69);
            binarySearch.Insert(44);
            binarySearch.Insert(66);
            binarySearch.Insert(52);
            binarySearch.Insert(94);
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}
