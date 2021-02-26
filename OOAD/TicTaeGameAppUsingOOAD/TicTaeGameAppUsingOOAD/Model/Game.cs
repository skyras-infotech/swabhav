using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTaeGameAppUsingOOAD.Model
{
    class Game
    {
        private ResultAnalyzer _resultAnalyzer;
        private Player[] _players;
        private int _totalMoves;

        public Game(ResultAnalyzer resultAnalyzer, Player p1,Player p2)
        {
            _resultAnalyzer = resultAnalyzer;
            _players = new Player[] {p1,p2};
            _totalMoves = 0;
        }

        public ResultAnalyzer ResultAnalyzer {
            get { return _resultAnalyzer; }
        }

        public int TotalMoves {
            get { return _totalMoves; }
        }

        public int Play(int pos) 
        {
            Player player;
            int size = _resultAnalyzer.GetBoard.Size;

            if (_totalMoves % 2 == 0)
                player = _players[0];
            else
                player = _players[1];

            _resultAnalyzer.GetBoard.SetMarkInPosition(player, pos);

            if (_totalMoves >= (2 * (size - 1))) {
                Result result = _resultAnalyzer.GameResult(player.PlayerMark, pos);

                if (result.Equals(Result.Win))
                {
                    return 1;
                }
                else if (result.Equals(Result.Draw))
                {
                    return -1;
                }
                else {
                    _totalMoves++;
                    return 0;
                }
            }

            _totalMoves++;
            return 0;
        }
    }
}
