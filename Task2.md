Task 2 
Exception Handling :

1-

namespace Task04_search
{

    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {


            List<int> myList = new List<int>(); 

            while (true) 
            {
                Console.WriteLine("Enter your number to add:");

                int number = Convert.ToInt32(Console.ReadLine()); 

                if (myList.Contains(number)) 
                {
                    throw new InvalidOperationException("Duplicate number found: " + number);
                }
                else
                {
                    myList.Add(number);
                    Console.WriteLine("Number added successfully!");
                }
            }
        }
    }
}
**************************************************************************************************************************
2-

namespace Task04_search
{

    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {


            while (true) 
            {
                Console.WriteLine("Enter a string:");

                string input = Console.ReadLine(); 

                if (!ContainsVowel(input)) 
                {
                    throw new InvalidOperationException("No vowels found in the input string.");
                }
                else
                {
                    Console.WriteLine("The string contains vowels.");
                }

                
            }
        }

        static bool ContainsVowel(string str)
        {
            string vowels = "aeiouAEIOU";
            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    return true; 
                }
            }
            return false;


            /*List<int> myList = new List<int>(); 

            while (true) 
            {
                Console.WriteLine("Enter your number to add:");

                int number = Convert.ToInt32(Console.ReadLine()); 

                if (myList.Contains(number)) 
                {
                    throw new InvalidOperationException("Duplicate number found: " + number);
                }
                else
                {
                    myList.Add(number);
                    Console.WriteLine("Number added successfully!");*/


        }
            }
        }




