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
            int move = random.Next(1, 7);
            int wave = random.Next(1, 4);
            int incpos = pos + move;
            int decpos = pos - move;
            switch (wave)
            {
                case 1:
                    Console.WriteLine("Player 1 got a Ladder and a value {0} on Dice", move);
                    
                    Console.WriteLine("Player 1 is now at position {0}", incpos);
                    break;
                case 2:
                    Console.WriteLine("Player 1 got a Snake and a value {0} on Dice", move);

                    Console.WriteLine("Player 1 is now at position {0}", decpos);
                    break;
                case 3:
                    Console.WriteLine("Player 1's Move is Unclear and Remains at Position {0}", pos);
                    break;

            }
            
        }
    }
}