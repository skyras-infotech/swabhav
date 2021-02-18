namespace CountryApp.Model
{
    class Capital
    {
        private int population;
        private string name;

        public string CapitalName
        {
            get { return name; }
            set { name = value; }
        }

        public int Populations
        {
            get { return population; }
            set { population = value; }
        }

    }
}
