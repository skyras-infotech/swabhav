using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Model
{
    public class Player
    {
        private string _name;
        private Mark _mark;

        public Player(string name, Mark mark)
        {
            _name = name;
            _mark = mark;
        }

        public Mark PlayerMark
        {
            get { return _mark; }
        }

        public string PlayerName
        {
            get { return _name; }
        }

    }
}
