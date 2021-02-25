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
        private int _switchTurn;

        public Game(Die die)
        {
            _turn = 0;
            _die = die;
            _score = 0;
            _isTurnOver = false;
            _isGameOver = false;
            _switchTurn = 1;
        }

        public int SwitchTurn
        {
            get { return _switchTurn; }
            set { _switchTurn = value; }
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


        public int Turn
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
