// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Izh_04
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int FindMaxElement(int[] array)
        {
            int result = 0;
            foreach (int item in array)
            {
                if (result < item)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
