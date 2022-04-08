using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counterOfO = 0;
            int counterOfC = 0;
            int counterOfN = 0;
            string word = "";
            string completedWord = "";

            while (input != "End")
            {
                char inputChar = input[0];
                int inputInt = inputChar;
                if (inputInt >= 65 && inputInt <= 90 || inputInt >= 97 && inputInt <= 122)
                {
                    if (input != "o" && input != "c" && input != "n")
                    {
                        word += input;
                    }
                    else
                    {
                        if (input == "o")
                        {
                            if (counterOfO == 0)
                            {
                                counterOfO++;
                            }
                            else
                            {
                                word += input;
                            }
                        }
                        else if (input == "c")
                        {
                            if (counterOfC == 0)
                            {
                                counterOfC++;
                            }
                            else
                            {
                                word += input;
                            }
                        }
                        else if (input == "n")
                        {
                            if (counterOfN == 0)
                            {
                                counterOfN++;
                            }
                            else
                            {
                                word += input;
                            }
                        }
                    }

                    if (counterOfO == 1 && counterOfC == 1 && counterOfN == 1)
                    {
                        completedWord += word + " ";
                        counterOfO = 0;
                        counterOfC = 0;
                        counterOfN = 0;
                        word = "";
                    }
                }

                input = Console.ReadLine();

            }

            if (input == "End")
            {
                Console.WriteLine(completedWord);
            }
        }
    }
}
