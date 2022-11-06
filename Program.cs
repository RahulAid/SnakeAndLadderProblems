using System.Security.Cryptography.X509Certificates;

namespace SnakeAndLadderProblems
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int pos1 = 0;
            int pos2 = 0;
            int rollCount = 0;
            int rollCount1 = 0;
            int rollCount2 = 0;           
            bool a = true;
            bool b = false;

            Console.WriteLine($"Both Players are at position {pos1} and {pos2}");
            Console.WriteLine("Let the Snake and Ladder Game Begin");
            Console.ReadLine();

            Random random = new Random();
            while (pos1 < 100 && pos2 < 100)
            {

                if (a)
                {
                    Console.WriteLine("\nPlayer 1s Turn");
                    rollCount1++;
                    int wave = random.Next(1, 3);
                    int move = random.Next(1, 7);

                    switch (wave)
                    {
                        case 1:
                            Console.WriteLine("Player 1 got a Ladder and a value {0} on Dice, move");
                            pos1 = pos1 + move;

                            if (pos1 > 100)
                            {
                                pos1 = pos1 - move;
                                Console.WriteLine("Player 1 is now at position {0}", pos1);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Player 1 got a Snake and a value {0} on Dice", move);
                            pos1 = pos1 - move;

                            if (pos1 < 0)
                            {
                                pos1 = 0;
                                Console.WriteLine("Player 1 is moved back to Initial Position 0");

                            }
                            b = true;
                            a = false;
                            break;
                    }
                }
                else if (b)
                {
                    Console.WriteLine("Player 2s Turn");
                    rollCount2++;
                    int wave = random.Next(1, 3);
                    int move = random.Next(1, 7);
                    switch (wave)
                    {
                        case 1:
                            Console.WriteLine("Player 2 got a Ladder and a value {0} on Dice", move);
                            pos2 = pos2 + move;

                            if (pos2 > 100)
                            {
                                pos2 = pos2 - move;
                                Console.WriteLine("Player 2 is now at position {0}",pos2);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Player 2 got a Snake and a value {0} on Dice", move);
                            pos2 = pos2 - move;
                            if (pos2 < 0)
                            {
                                pos2 = 0;
                                Console.WriteLine("Player 2 is moved back to Initial Position 0");

                            }
                            a = true;
                            b = false;
                            break;
                    }
                }
            }
            rollCount = rollCount1 + rollCount2;
            if (pos1 == 100)
            {
                Console.WriteLine("Player1 Wins");
                Console.WriteLine("Dice was Rolled for a Total of {0} Times",rollCount);
                Console.WriteLine("Player1 got Victory after Rolling Dice {0} Times",rollCount1);
            }
            if (pos2 == 100)
            {
                Console.WriteLine("Player2 Wins");
                Console.WriteLine("Dice was Rolled for a Total of {0} Times", rollCount);
                Console.WriteLine("Player2 got Victory after Rolling Dice {0} Times", rollCount2);
            }
            
            
            Console.ReadLine();
        }
    }
}