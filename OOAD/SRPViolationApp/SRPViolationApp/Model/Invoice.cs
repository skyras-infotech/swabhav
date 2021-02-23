using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Model
{
    class Invoice
    {
        private int _no;
        private string _name;
        private double _amount;
        private double _discountPercentage;
        private float _gst;

        public Invoice(int no, string name, double amount, double discountPercentage, float gst)
        {
            _no = no;
            _name = name;
            _amount = amount;
            _discountPercentage = discountPercentage;
            _gst = gst;
        }

        public float GST
        {
            get { return _gst; }
        }


        public double DiscountPercentage
        {
            get { return _discountPercentage; }
        }


        public double Amount
        {
            get { return _amount; }
        }


        public string Name
        {
            get { return _name; }
        }


        public int No
        {
            get { return _no; }
        }

        public double CalculateDiscount() {
            return _amount - (_amount * (_discountPercentage / 100));
        }

        public double CalculateGST() {
            return _amount - (_amount * (_gst / 100));
        }

        public double CalculateTotalCost() {
            return CalculateDiscount() + CalculateGST();
        }

        public void PrintToConsole() {
            Console.WriteLine("=========== Bill Summary =============");
            Console.WriteLine("Product ID           :   " + No);
            Console.WriteLine("Product Name         :   " + Name);
            Console.WriteLine("Product Amount       :   " + Amount);
            Console.WriteLine("Product Discount     :   " + DiscountPercentage);
            Console.WriteLine("Amount with discount :   " + CalculateDiscount());
            Console.WriteLine("Amount with GST      :   " + CalculateGST());
            Console.WriteLine("Total Amount         :   " + CalculateTotalCost());
        }
    }
}
