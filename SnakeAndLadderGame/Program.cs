using System;
namespace SnakeAndLadderGame
{ 
    class Program
    {
        static void Main(String[] args)
        {
            SnakeAndLadder game = new SnakeAndLadder();
            Console.WriteLine(game.DieRoll());
        }
    }
}


