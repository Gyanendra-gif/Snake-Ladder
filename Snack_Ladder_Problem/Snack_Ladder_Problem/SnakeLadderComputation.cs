using System;
using System.Collections.Generic;
using System.Text;

namespace Snack_Ladder_Problem
{
    class SnakeLadderComputation
    {
        public const int NO_PLAY = 0, SNAKE = 2, LADDER = 1;
        int playerPosition = 0;
        Random rand = new Random();
        public int diceRoll()
        {
            int roll = rand.Next(1, 7);
            return roll;
        }
        public void play() {
            int Roll = this.diceRoll();
            this.playerPosition = playerPosition + Roll;
            Console.WriteLine("Position of Player is: " + playerPosition);
        } 
    }
 }
