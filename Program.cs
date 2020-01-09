using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Vide_67_Searching_a_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            BuildList(numbers);
            Display(numbers);
            numbers.Sort();
            Display(numbers);
            numbers.Reverse();
            Display(numbers);
        }
        static void Display(List<int> lyst) // Displays the random number generators and adds a space every 5th line
        {
            for (int i = 0; i < lyst.Count; ++i)
            {
                if (i % 25 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(lyst[i] + " ");
                }
            }
        }
        static void BuildList(List<int> lyst) // This method populates our list with random numbers using .Next method
        {
            Random rand = new Random();
            for (int i = 0; i < 100; ++i)
            {
                lyst.Add(rand.Next(1, 101));
            }
        }
        
    }
}
