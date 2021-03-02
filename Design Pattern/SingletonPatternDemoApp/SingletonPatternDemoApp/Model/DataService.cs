using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemoApp.Model
{
    class DataService
    {
        private static DataService _dataService;

        private DataService() {
            Console.WriteLine("Service created");
        }

        public static DataService GetInstance
        {
            get {
                if (_dataService == null) {
                    _dataService = new DataService();
                }
                return _dataService;
            }
        }

        public void ProcessData() {
            Console.WriteLine("Hascode of current data serivce is " + this.GetHashCode()); ;
        }

    }
}
