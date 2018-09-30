using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkFactory.EMPTY;
        }

        public MarkType Mark
        {
            get
            {
                return _mark;
            }

            set
            {
                if (!IsMarked())
                {
                    _mark = value;
                }
                else
                {
                    Console.WriteLine("Already Marked");
                }
            }
        }

        public Boolean IsMarked()
        {
            if (!_mark.Name.Equals(MarkFactory.EMPTY.Name))
                return true;
            return false;
        }

        public override string ToString()
        {
            return _mark.Name;
        }
    }
}
