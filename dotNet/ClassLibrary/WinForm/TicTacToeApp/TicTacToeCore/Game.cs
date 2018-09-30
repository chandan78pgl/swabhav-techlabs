using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private Board _board;
        private ResultAnalyzer _resultAnalyzer;
        private Player _currentPlayer;
        private bool _turn = true;
        private bool _winner = false;

        public Game(Player player1, Player player2, Board board, ResultAnalyzer resultAnalyzer)
        {
            _player1 = player1;
            _player2 = player2;
            _board = board;
            _resultAnalyzer = resultAnalyzer;
            _currentPlayer = player1;
        }

        public void InitializeGame()
        {
            _board.DisplayBoard();
        }

        public void Play(int position)
        {
            if (ValidChoice(position))
            {
                _currentPlayer = Turn;
                _board.UpdateBoard(CurrentPlayer.Mark, position);

                _resultAnalyzer.AnalyzeBoard();

                if (_turn)
                {
                    _turn = false;
                }
                else
                {
                    _turn = true;
                }
            }
            else
            {
                Console.WriteLine("Choose a valid Option: " + Turn);
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
        }

        public Board Board
        {
            get
            {
                return _board;
            }
        }

        public Boolean ValidChoice(int position)
        {
            if (!_board.GetCell(position-1).IsMarked())
            {
                return true;
            }
            return false;
        }

        public Player Turn
        {
            get
            {
                if (_turn)
                {
                    return _player1;
                }
                else
                {
                    return _player2;
                }
            }
        }

        public void DisplayGame()
        {
            if (!_winner)
            {
                _board.DisplayBoard();
            }
        }

        public ResultAnalyzer ResultAnalyzer
        {
            get
            {
                return _resultAnalyzer;
            }
        }
    }
}
