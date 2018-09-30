using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Player
    {
        private string _name;
        private MarkType _mark;

        public Player(String name,MarkType mark)
        {
            _name = name;
            _mark = mark;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public MarkType Mark
        {
            get
            {
                return _mark;
            }
        }

        public override string ToString()
        {
            return Name+" -> "+Mark.Name;
        }
    }
}
