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
            Console.WriteLine("Player 1 rolled a dice and got a value {0}", move);
            int newpos = pos + move;
            Console.WriteLine("Player 1 is now at position {0}", newpos);



        }
    }
}