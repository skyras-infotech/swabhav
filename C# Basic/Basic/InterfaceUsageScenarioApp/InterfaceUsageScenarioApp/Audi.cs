using System;

namespace InterfaceUsageScenarioApp
{
    class Audi : Car, INewFeatures
    {
        public string NewFeatures()
        {
            return "New Features are added";
        }
    }
}
