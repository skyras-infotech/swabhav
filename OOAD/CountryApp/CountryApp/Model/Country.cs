namespace CountryApp.Model
{
    class Country
    {
        private string name;
        private Capital capital;

        public Capital GetCapital
        {
            get { return capital; }
            set { capital = value; }
        }


        public string CountryName
        {
            get { return name; }
            set { name = value; }
        }

    }
}
