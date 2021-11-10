using System;
using System.Collections.Generic;
using System.Text;

namespace Snack_Ladder_Problem
{
    class SnakeLadderComputation
    {
        public const int NO_PLAY = 0, SNAKE = 2, LADDER = 1, WIN = 100, START = 0;
        int playerPosition = 0, count=0;
        Random rand = new Random();
        public int DiceRoll()
        {
            count++;
            int rol = rand.Next(1, 7);
            return rol;
        }
        public void Play()
        {
            while (this.playerPosition < WIN)
            {
                int roll = this.DiceRoll();
                int Check = rand.Next(0, 3);
                switch (Check)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += roll;
                        if (this.playerPosition > WIN)
                        {
                            this.playerPosition -= roll;
                        }
                        break;
                    case SNAKE:
                        this.playerPosition -= roll;
                        if (this.playerPosition < START)
                        {
                            this.playerPosition = 0;
                        }
                        break;
                }
            }
        }
    }
}
