using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolution.Model
{
    class InvoicePrinter
    {
        private Invoice _invoice;

        public InvoicePrinter(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void PrintToConsole()
        {
            Console.WriteLine("=========== Bill Summary =============");
            Console.WriteLine("Product ID           :   " + _invoice.No);
            Console.WriteLine("Product Name         :   " + _invoice.Name);
            Console.WriteLine("Product Amount       :   " + _invoice.Amount);
            Console.WriteLine("Product Discount     :   " + _invoice.DiscountPercentage);
            Console.WriteLine("Amount with discount :   " + _invoice.CalculateDiscount());
            Console.WriteLine("Amount with GST      :   " + _invoice.CalculateGST());
            Console.WriteLine("Total Amount         :   " + _invoice.CalculateTotalCost());
        }

    }
}
