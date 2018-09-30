using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCore;

namespace TicTaeToeConsoleApp
{
    public class TicTacToeConsole
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Chandan", MarkFactory.CROSS);
            Player player2 = new Player("Dharmesh", MarkFactory.NOUGHT);

            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(player1, player2, board, resultAnalyzer);

            Console.WriteLine("Welcome to Tic Tac Toe.\n 1. Startgame\n  Enter Choice: ");
            String start = Console.ReadLine();
            
            if (start.Equals("1"))
            {
                StartGame(game);
            }
        }

        private static void StartGame(Game game)
        {
            game.InitializeGame();
            String choice = "0";
            while (game.ResultAnalyzer.Result.Equals(Result.ONGOING))
            {

                Console.WriteLine("Turn:\n Player: " + game.Turn
                        + "\nEnter Number: ");

                choice = Console.ReadLine();
                
                game.Play(Convert.ToInt32(choice));

                if (game.ResultAnalyzer.Result == Result.WIN)
                {
                    Console.WriteLine("Winner is " + game.CurrentPlayer);
                }
                else if (game.ResultAnalyzer.Result == Result.DRAW)
                {
                    Console.WriteLine("Game is draw.\nNo one is Winner.");
                }
                game.DisplayGame();
            }
        }
    }
}
