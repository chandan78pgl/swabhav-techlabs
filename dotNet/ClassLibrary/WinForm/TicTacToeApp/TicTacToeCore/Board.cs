using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Board
    {
        private List<Cell> _cells = new List<Cell>();

        public Board()
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                _cells.Add(new Cell());
            }
        }

        public List<Cell> Cells
        {
            get
            {
                return _cells;
            }
        }

        public Cell GetCell(int position)
        {
            return _cells.ElementAt(position);
        }

        public void DisplayBoard()
        {
            Console.WriteLine("--------------------------------------------"+
                "\n {0} | {1} | {2}"+
                "\n--- --- ---"+
                "\n {3} | {4} | {5}"+
                "\n--- --- ---"+
                "\n {6} | {7} | {8}",
                _cells.ElementAt(0), _cells.ElementAt(1), _cells.ElementAt(2),
                _cells.ElementAt(3), _cells.ElementAt(4), _cells.ElementAt(5),
                _cells.ElementAt(6), _cells.ElementAt(7), _cells.ElementAt(8));
        }

        public void UpdateBoard(MarkType mark,Int32 position)
        {
            _cells.ElementAt(position - 1).Mark = mark;
        }

        public Boolean IsBoardFilled()
        {
            foreach (Cell cell in _cells)
            {
                if (cell.Mark.Name.Equals("E"))
                {
                    return false;
                }
            }
            return true;
        }

        public Cell[,] GenerateBoardMatrix()
        {
            Cell[,] mCells = new Cell[3, 3];

            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mCells[i, j] = _cells.ElementAt(k);
                    k++;
                }
            }

            return mCells;
        }
    }
}
