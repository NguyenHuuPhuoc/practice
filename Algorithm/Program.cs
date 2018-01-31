﻿using Algorithm.MostFrequentNumbers.Implement;
using Algorithm.Permutations.Implement;

namespace Algorithm
{
    internal class Program
    {
        /// <summary>
        /// Root Main: run program algorithm
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Permutation permutation = new Permutation();
            permutation.MainPermutation();

            MostFrequentNumber mostFrequentNumber = new MostFrequentNumber();
            mostFrequentNumber.MainMostFrequentNumber();
        }
    }
}