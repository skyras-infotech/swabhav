using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTaeGameAppUsingOOAD.Model
{
    public class Game
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

        public Result Play(int pos) 
        {
            Player player;
            int size = _resultAnalyzer.GetBoard.Size;

            if (_totalMoves % 2 == 0)
                player = _players[0];
            else
                player = _players[1];

            try
            {
                _resultAnalyzer.GetBoard.SetMarkInPosition(player, pos);
            }
            catch (OutOfCellException e)
            {
                throw new OutOfCellException(e.Message);
            }
            catch (CellAlreadyOccupiedException e) 
            {
                throw new CellAlreadyOccupiedException(e.Message);
            }


            if (_totalMoves >= (2 * (size - 1))) {
                Result result = _resultAnalyzer.GameResult(player.PlayerMark, pos);

                if (result.Equals(Result.Win))
                {
                    return Result.Win;
                }
                else if (result.Equals(Result.Draw))
                {
                    return Result.Draw;
                }
                else {
                    _totalMoves++;
                    return Result.InProgress;
                }
            }

            _totalMoves++;
            return Result.InProgress;
        }
    }
}
