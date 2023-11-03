﻿using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome to Algorithms *******");
            
            int[] sequence = { 5, 2, 4, 6, 1, 3 };
            Console.Write("Current Sequence: ");
            PrintIntArray(sequence);


            // Algorithm 2.1
            // Refer InsertionSort.cs
            InsertionSort insertionSort = new InsertionSort(sequence);
            int[] increasingSortedArray = insertionSort.IncreasingSort();
            PrintIntArray(increasingSortedArray, "Insertion Sorted Increasing Sequence: ", true);


            // Question 2.1-1
            // Refer InsertionSort.cs
            InsertionSort insertionSort2 = new InsertionSort(new int[] {31, 41, 59, 26, 41, 58});
            int[] increasingSortedArray2 = insertionSort2.IncreasingSort();
            PrintIntArray(increasingSortedArray2, "Insertion Sorted Increasing Sequence on [31, 41, 59, 26, 41, 58]: ", true);


            // Question 2.1-2
            // Refer InsertionSort.cs
            int[] decreasingSortedArray = insertionSort.DecreasingSort(); // Uses Algorithm 2.1 instance and sequence
            PrintIntArray(decreasingSortedArray, "Insertion Sorted Decreasing Sequence: ", true);


            // Question 2.1-3
            // Refer LinearSearch.cs
            int[] searchSequence = new int[] { 31, 41, 59, 26, 41, 58 };
            LinearSearch linearSearch = new LinearSearch(searchSequence, 41);
            Console.WriteLine($"Index of {41} in [{string.Join(", ", searchSequence)}] is: {linearSearch.Search()}");
            linearSearch.SearchValue = 98;
            Console.WriteLine($"Index of {98} in [{string.Join(", ", searchSequence)}] is: {linearSearch.Search()}");
            Console.WriteLine("**********************************");


            // Question 2.1-4
            // Refer NBitAddition.cs
            int[] arrayA = new int[8] { 0, 1, 1, 0, 1, 1, 1, 1 };
            int[] arrayB = new int[8] { 1, 1, 1, 0, 0, 0, 1, 1 };
            NBitAddition nBitAddition = new NBitAddition(arrayA, arrayB);
            PrintIntArray(arrayA, "Array A:    ");
            PrintIntArray(arrayB, "Array B:    ");
            PrintIntArray(nBitAddition.Sum(), "Array C: ", true);


            // Question 2.2-2
            // Refer SelectionSort.cs
            sequence = new int[] { 41, 59, 26, 41, 58 };
            PrintIntArray(sequence, "Current Sequence: ");
            SelectionSort selectionSort = new SelectionSort(sequence);
            PrintIntArray(selectionSort.Sort(), "Selection Sorted Sequence: ", true);


            // Helper Utility
            static void PrintIntArray(int[] sequence, string message = "", bool pattern = false)
            {
                Console.WriteLine($"{message}[ {string.Join(", ", sequence)} ]");
                if ( pattern ) Console.WriteLine("**********************************");
            }
        }
    }
}