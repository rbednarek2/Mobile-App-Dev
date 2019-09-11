using System;
using System.Collections;

namespace Lab1.Program2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int inputValue = 0;
            ArrayList People = new ArrayList();

            //inputValue = Convert.ToInt32(userInput);
            while (inputValue != 3)
            {
                Console.WriteLine("Please enter a: " +
                    "1) Student\n" +
                    "2) Teacher\n" +
                    "3) End\n" +
                    "Input: ");
                userInput = Console.ReadLine();

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
