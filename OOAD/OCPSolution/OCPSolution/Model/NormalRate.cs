namespace OCPSolution.Model
{
    class NormalRate : IFestivalRate
    {
        private const float NORMAL_RATE = 0.03f;
        public double getRate()
        {
            return NORMAL_RATE;
        }
    }
}
