using System;
using System.Collections.Generic;
using System.Text;

namespace Snack_Ladder_Problem
{
    class SnakeLadderComputation
    {
        public const int NO_PLAY = 0, SNAKE = 2, LADDER = 1, WIN = 100, START = 0;
        int playerPosition = 0;
        Random rand = new Random();
        public int diceRoll()
        {
            int roll = rand.Next(1, 7);
            return roll;
        }
        public void play()
        {
            while (this.playerPosition < WIN)
            {
                int Roll = this.diceRoll();
                int Check = rand.Next(0, 3);
                switch (Check)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += Roll;
                        if (this.playerPosition > WIN)
                        {
                            this.playerPosition -= Roll;
                        }
                        break;
                    case SNAKE:
                        this.playerPosition -= Roll;
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
