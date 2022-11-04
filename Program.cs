namespace SnakeAndLadderProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Problems");
            Console.WriteLine("Let the Snake And Ladder Game Begin");
            int pos = 0;
            Console.WriteLine("Initial position of Player 1 is {0}",pos);
            Random random = new Random();
                
            int rollCount = 0;
            
            while (pos >= 0 && pos < 100)
            
            {
                int move = random.Next(1, 7);
                int wave = random.Next(1, 3);
                rollCount++;
                switch (wave)
                {
                    case 1:
                        Console.WriteLine("Player 1 got a Ladder and a value {0} on Dice", move);
                        pos = pos + move;
                        
                        if (pos == 100)
                        {
                            Console.WriteLine("Player 1 Wins");
                        }
                        else if (pos > 100)
                        {
                            pos = pos - move;
                            Console.WriteLine("Player 1 is now at position {0}", pos);

                        }
                        else 
                        {
                            Console.WriteLine("Player 1 is now at position {0}", pos);
                        }

                        break;
                    
                    case 2:
                        Console.WriteLine("Player 1 got a Snake and a value {0} on Dice", move);
                        pos = pos - move;
                        
                        if (pos < 0)
                        {
                            pos = pos + move;
                            Console.WriteLine("Player 1 is now at position {0}", pos);
                        }
                        else
                        {
                            Console.WriteLine("Player 1 is now at position {0}", pos);
                        }

                        break;

                } 

            }
            Console.WriteLine("It took {0} number of Dice Turns in order to Win the Game", rollCount);
            Console.ReadLine();
            
        }
    }
}