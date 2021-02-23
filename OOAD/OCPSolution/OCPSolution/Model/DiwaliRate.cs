namespace OCPSolution.Model
{
    class DiwaliRate : IFestivalRate
    {
        private const float DIWALI_RATE = 0.08f;
        public double getRate()
        {
            return DIWALI_RATE;
        }
    }
}
