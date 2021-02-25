using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameUsinhOOPSApp.Model
{
    class PigGame
    {
        private int _totalScore;
        private int _turnScore;
        private const int RESULT_VALUE = 20;

        public PigGame()
        {
            _totalScore = 0;
            _turnScore = 0;
        }

        public int TurnScore
        {
            get { return _turnScore; }
            set { _turnScore = value; }
        }


        public int TotalScore
        {
            get { return _totalScore; }
            set { _totalScore = value; }
        }

        public int Roll(Random random) {
            return random.Next(1, 6);
        }

        public bool HasWon() {
            if (_totalScore >= RESULT_VALUE) {
                return true;
            }
            return false;
        }

        public int BankPoints()
        {
            return _totalScore += _turnScore;
        }

    }
}
