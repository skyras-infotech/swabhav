using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo2App.Model
{
    abstract class University
    {
        abstract public void FillForm();
        abstract public void GetList();
        abstract public void FeePayment();
        public void StartProcess() {
            FillForm();
            GetList();
            FeePayment();
        }
    }
}
