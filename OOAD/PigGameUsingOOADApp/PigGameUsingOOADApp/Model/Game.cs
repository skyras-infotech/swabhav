namespace PigGameUsingOOADApp.Model
{
    class Game
    {
        private const int RESULT_VALUE = 20;
        private int _turn;
        private Die _die;
        private int _score;
        private bool _isTurnOver;
        private bool _isGameOver;
        private int _totalTurn;

        public Game(Die die)
        {
            _turn = 0;
            _die = die;
            _score = 0;
            _isTurnOver = false;
            _isGameOver = false;
            _totalTurn = 1;
        }

        public int TotalTurn
        {
            get { return _totalTurn; }
            set { _totalTurn = value; }
        }


        public bool IsGameOver
        {
            get { return _isGameOver; }
            set { _isGameOver = value; }
        }


        public bool IsTurnOver
        {
            get { return _isTurnOver; }
            set { _isTurnOver = value; }
        }


        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }


        public Die GetDie
        {
            get { return _die; }
            set { _die = value; }
        }


        public int TurnScore
        {
            get { return _turn; }
            set { _turn = value; }
        }

        public bool HasWon() {
            if (_score >= RESULT_VALUE) {
                return true;
            }
            return false;
        }

    }
}
