using System;
using System.Collections.Generic;
using System.Text;

namespace Snack_Ladder_Problem
{
    class SnakeLadderComputation
    {
        public const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int playerPosition = 0;
        void diceRoll()
        {
            Console.WriteLine("InitialPosition of Player is: " + playerPosition);
        }
    }
}