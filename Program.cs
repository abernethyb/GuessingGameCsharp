using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            question();

        }

        static void question()
        {
            int answer = new Random().Next(1, 100);
            Console.WriteLine("Welcome to the game. You will soon be asked to guess a number between 1 and 100, but first, choose your dificulty level");
            Console.Write("Cheater 'c', Easy 'E', Medium 'M', or Hard 'H'");
            string dificulty = Console.ReadLine().ToLower();
            while (dificulty != "c" && dificulty != "e" && dificulty != "m" && dificulty != "h")
            {
                Console.Write("Cheater 'c', Easy 'E', Medium 'M', or Hard 'H'");
                dificulty = Console.ReadLine().ToLower();
            }
            int difNum = 4;
            int cheater = 1;
            bool cheats = false;
            if (dificulty == "e")
            {
                difNum = 8;
            }
            else if (dificulty == "m")
            {
                difNum = 6;
            }
            else if (dificulty == "h")
            {
                difNum = 4;
            }
            else if (dificulty == "c")
            {
                cheater = 0;
                cheats = true;
            }
            Console.WriteLine("Hi there! I'm thinking of a number, but I bet you won't be able to guess what it is.");
            Console.Write("But why don't you give it a shot anyway ");
            string input = Console.ReadLine();
            int numInput = 0;
            try
            {
                numInput = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a number, silly!");
            }
            for (int i = 1; i < difNum; i = i + cheater)
            {
                if (numInput == answer)
                {
                    Console.WriteLine("Oh wow, good job.  You guessed the right answer, I really wasn't expecting that");
                    break;
                }
                else
                {
                    if (numInput > answer)
                    {
                        if (cheats)
                        {
                            Console.WriteLine("Too High!");
                            Console.Write("Guess Again!");
                            input = Console.ReadLine();
                            //numInput = Int32.Parse(input);
                            try
                            {
                                numInput = Int32.Parse(input);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("That's not a number, silly!");
                            }
                        }
                        else
                        {
                            Console.Write($"Too High! You have {difNum - i} guesses remaining");
                            Console.Write("Guess Again!");
                            input = Console.ReadLine();
                            //numInput = Int32.Parse(input);
                            try
                            {
                                numInput = Int32.Parse(input);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("That's not a number, silly!");
                                Console.Write("Guess Again!");
                                input = Console.ReadLine();
                            }
                        }

                    }
                    else if (numInput < answer)
                    {
                        if (cheats)
                        {
                            Console.WriteLine("Too Low!");
                            Console.Write("Guess Again!");
                            input = Console.ReadLine();
                            //numInput = Int32.Parse(input);
                            try
                            {
                                numInput = Int32.Parse(input);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("That's not a number, silly!");
                            }
                        }
                        else
                        {
                            Console.Write($"Too Low! You have {difNum - i} guesses remaining");
                            Console.Write("Guess Again!");
                            input = Console.ReadLine();
                            //numInput = Int32.Parse(input);
                            try
                            {
                                numInput = Int32.Parse(input);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("That's not a number, silly!");
                                Console.Write("Guess Again!");
                                input = Console.ReadLine();
                            }
                        }
                    }
                }

            }
            if (numInput != answer)
            {
                Console.WriteLine($"Nope! Wrong again! I knew you wouldn't be able to guess {answer}");
            }
        }
    }
}