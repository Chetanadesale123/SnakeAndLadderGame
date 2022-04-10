using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class SnakeAndLadder
    {
        int position = 0;
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int count = 0,player1=0,player2=0;
        public int DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;
        }
        public int Game()
        {
            while (this.position < 100)
            {

                Random random = new Random();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        this.position += 0;
                        break;
                    case SNAKE:
                        this.position -= this.DieRoll(n);
                        if (this.position < 0)
                        {
                            this.position = 0;
                        }
                        break;
                    case LADDER:
                        int roll = this.DieRoll(n);
                        this.position += roll;
                        if (this.position > 100)
                        {
                            this.position -= roll;
                        }
                        break;
                }
                
               // Console.WriteLine("position after every die roll : " + this.position);
               count++;

            }return this.position;
            
           Console.WriteLine("number of times dice was played :" + count++);

        }
        public void WonGame()
        {
            while(player1 < 100 || player2 < 100)
                Console.WriteLine("its turn of player1\n");
            player1 =DieRoll();
            player1 =Game();
            if(player1 < 100)
            {
                
                Console.WriteLine("winner of game is player1");
                player1++;
                
            }
            
            else
            {
                Console.WriteLine("its turn of player2 \n");
                player2 =DieRoll();
                player2 = Game();
                if(player2 < 100)
                {
                    player2++;
                    Console.WriteLine("winner of game is player2");
                    //player2++;
                }

            }

        }

        

        


    }
}
