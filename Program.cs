using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Binarysearchtree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Binary Search Tree");

            Console.WriteLine("Welcome to Binary Search Tree!");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            Console.ReadKey();

        }
    }
}
