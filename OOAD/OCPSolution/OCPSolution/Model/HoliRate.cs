namespace OCPSolution.Model
{
    class HoliRate : IFestivalRate
    {
        private const float HOLI_RATE = 0.05f;
        public double getRate()
        {
            return HOLI_RATE;
        }
    }
}
