using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class ResultAnalyzer
    {
        private Board _board;
        private Result _result;
        private Cell[,] _boardCells;

        public ResultAnalyzer(Board board)
        {
            _board = board;
            _boardCells = board.GenerateBoardMatrix();
            _result = Result.ONGOING;
        }

        public void AnalyzeBoard()
        {
            for (int i = 0; i < _board.Cells.Count; i++)
            {
                if (_board.GetCell(i).IsMarked())
                {
                    CheckWin(i+1);
                }
            }

            if (_board.IsBoardFilled() && _result!=Result.WIN)
            {
                _result = Result.DRAW;
            }
        }

        private void CheckWin(int position)
        {
            switch (position)
            {
                case 1:
                    if (CheckVertical(0) || CheckHorizontal(0) || CheckDiagonal())
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 3:
                    if (CheckVertical(2) || CheckHorizontal(0) || CheckDiagonal())
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 5:
                    if (CheckVertical(1) || CheckHorizontal(1) || CheckDiagonal())
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 7:
                    if (CheckVertical(0) || CheckHorizontal(2) || CheckDiagonal())
                    {
                        _result = Result.WIN;
                    }
                    break;
                case 9:
                    if (CheckVertical(2) || CheckHorizontal(2) || CheckDiagonal())
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 2:
                    if (CheckVertical(1) || CheckHorizontal(0))
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 4:
                    if (CheckVertical(0) || CheckHorizontal(1))
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 6:
                    if (CheckVertical(2) || CheckHorizontal(1))
                    {
                        _result = Result.WIN;
                    }
                    break;

                case 8:
                    if (CheckVertical(1) || CheckHorizontal(2))
                    {
                        _result = Result.WIN;
                    }
                    break;
                default:
                    break;
            }
        }

        private Boolean CheckVertical(int col)
        {
            if (_boardCells[0,col].Mark.Name.Equals(_boardCells[1,col].Mark.Name))
            {
                if (_boardCells[0,col].Mark.Name.Equals(_boardCells[2,col].Mark.Name))
                {
                    if (!_boardCells[0, col].Mark.Name.Equals("E"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Boolean CheckHorizontal(int row)
        {
            if (_boardCells[row,0].Mark.Name.Equals(_boardCells[row,1].Mark.Name))
            {
                if (_boardCells[row,0].Mark.Name.Equals(_boardCells[row,2].Mark.Name))
                {
                    if (!_boardCells[row,0].Mark.Name.Equals("E"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Boolean CheckDiagonal()
        {
            if (_boardCells[0,0].Mark.Name.Equals(_boardCells[1,1].Mark.Name))
            {
                if (_boardCells[0,0].Mark.Name.Equals(_boardCells[2,2].Mark.Name))
                {
                    if (!_boardCells[0,0].Mark.Name.Equals("E"))
                    {
                        return true;
                    }
                }
            }

            if (_boardCells[0,2].Mark.Name.Equals(_boardCells[1,1].Mark.Name))
            {
                if (_boardCells[0,2].Mark.Name.Equals(_boardCells[2,0].Mark.Name))
                {
                    if (!_boardCells[0,2].Mark.Name.Equals("E"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Result Result
        {
            get
            {
                return _result;
            }
        }
    }
}
