using System;

namespace Lab1.Program1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput;
            int value = 0;
            int inputValue = 0;

            while (value > 9 || value < 3)
            {
                Console.Write("Please enter a number between 3 and 9: ");
                userInput = Console.ReadLine();
                value = Convert.ToInt32(userInput);
            }

            for (int i = 1; i <= value; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= value; j++)
                {
                    Console.Write((i * j) + "\t");
                }
            }

            while (inputValue != 5)
            {
                Console.Write("\n\nFlip on...\n" +
                    "1) Horizon\n" +
                    "2) Vertical\n" +
                    "3) Diagonal Left\n" +
                    "4) Diagonal Right\n" +
                    "5) To End\n" +
                    "Input: ");
                userInput = Console.ReadLine();
                inputValue = Convert.ToInt32(userInput);

                switch (inputValue)
                {
                    case 1:
                        for (int i = value; i >= 1; i--)
                        {
                            Console.WriteLine();
                            for (int j = 1; j <= value; j++)
                            {
                                Console.Write((i * j) + "\t");
                            }
                        }
                        break;
                    case 2:
                        for (int i = 1; i <= value; i++)
                        {
                            Console.WriteLine();
                            for (int j = value; j >= 1; j--)
                            {
                                Console.Write((i * j) + "\t");
                            }
                        }
                        break;
                    case 3:
                        for (int i = 1; i <= value; i++)
                        {
                            Console.WriteLine();
                            for (int j = 1; j <= value; j++)
                            {
                                Console.Write((i * j) + "\t");
                            }
                        }
                        break;
                    case 4:
                        for (int i = 1; i <= value; i++)
                        {
                            Console.WriteLine();
                            for (int j = 1; j <= value; j++)
                            {
                                Console.Write((i * j) + "\t");
                            }
                        }
                        break;
                }
            }
        }
    }
}
