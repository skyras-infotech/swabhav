using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemoApp
{
    class SingletonDemo
    {
        private static SingletonDemo _singletonDemo;

        private SingletonDemo() { 
        
        }

        public static SingletonDemo GetInstance
        {
            get {
                if (_singletonDemo == null) {
                    _singletonDemo = new SingletonDemo();
                }
                return _singletonDemo;
            }
        }



    }
}
