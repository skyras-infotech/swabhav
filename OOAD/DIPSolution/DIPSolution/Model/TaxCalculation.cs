using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class TaxCalculation
    {
        private ILogger _logger;

        public TaxCalculation(ILogger logger)
        {
            _logger = logger;
        }

        public int Calculation(int amount, int rate)
        {
            try
            {
                return amount / rate;
            }
            catch (Exception e)
            {
                _logger.Logger(e.Message);
                return -1;
            }
        }
    }
}
