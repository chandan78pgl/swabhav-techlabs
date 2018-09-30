using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class MarkFactory
    {
        public static MarkType NOUGHT
        {
            get
            {
                return new NOUGHT();
            }
        }

        public static MarkType CROSS
        {
            get
            {
                return new CROSS();
            }
        }

        public static MarkType EMPTY
        {
            get
            {
                return new EMPTY();
            }
        }
    }
}
