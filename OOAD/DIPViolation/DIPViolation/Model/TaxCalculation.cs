using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class TaxCalculation
    {
        private LogType _log;

        public TaxCalculation(LogType log)
        {
            _log = log;
        }

        public LogType Log
        {
            get { return _log; }
        }

        public int Calculation(int amount,int rate)
        {
            try
            {
                return amount / rate;
            }
            catch (Exception e)
            {
                if (this.Log == LogType.TXT) {
                    TxtLogger txtLogger = new TxtLogger();
                    txtLogger.Log(e.Message);
                    return -1;
                }
                XmlLogger xmlLogger = new XmlLogger();
                xmlLogger.Log(e.Message);
                return -1;
            }
        }
    }
}
