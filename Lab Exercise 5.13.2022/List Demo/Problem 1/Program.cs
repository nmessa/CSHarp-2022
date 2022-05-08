//Lab Exerecise 5.13.2022 List Demo
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 arrays
            int[] a1 = {4, 5, 2, 1, 4, 9, 7, 2};
            int[] a2 = {1, 2, 1, 1, 3, 2, 5, 4, 4};
            int[] a3 = {1, 2, 3, 4, 5, 6};

            //Create List
            List<int> myList = new List<int>();

            //Add 5 elements to list
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an integer: ");
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Print the lists
            printList(myList);
        }

        static void printList(List<int> lst)
        {
            Console.Write("[");
            for (int i = 0; i < lst.Count; i++)
                Console.Write(lst[i] + " ");
            Console.WriteLine("]");
        }
    }
}

//Output
//Enter an integer: 34
//Enter an integer: 56
//Enter an integer: 21
//Enter an integer: 76
//Enter an integer: 44
//[34 56 21 76 44 ]