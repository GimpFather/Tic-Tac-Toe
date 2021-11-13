using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] startBoard =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            char[,] gameBoard = startBoard.Clone() as char[,];

            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true;

            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();
                // TODO: Draw the board.
                if (nextIsPlayer1)
                {
                    // TODO: Player one move.
                    nextIsPlayer1 = false;
                }
                else
                {
                    // TODO: Player two move.
                    nextIsPlayer1 = true;
                }

                if (player1Won || player2Won)
                    break;
            }

            Console.Clear();
            // TODO: smth smth

            Console.WriteLine("Game ended!");
            // TODO: Print who won.
        }
    }
}
