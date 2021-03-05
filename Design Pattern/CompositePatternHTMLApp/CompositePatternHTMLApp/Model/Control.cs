using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternHTMLApp.Model
{
    class Control : IHtml
    {
        private string _tag;
        private string _type;
        private string _value;
                       
        public StringBuilder control = new StringBuilder();

        public Control(string tag)
        {
            _tag = tag;

        }

        public Control(string tag, string type, string value)
        {
            _tag = tag;
            _type = type;
            _value = value;
        }

        public StringBuilder ParseHTML()
        {
            if (_type != null)
            {
                
                control.Append((_value.Equals("submit") ? null : _value+" : ")+"<" + _tag + " " + "type = " + _type + " value = " + _value + ">");
                control.Append("</" + _tag + ">\n");
                return control;
            }
            else {
                control.Append("<" + _tag + ">");
                control.Append("</" + _tag + ">\n");
                return control;
            }
        }

        public override string ToString()
        {
            return control.ToString();
        }
    }
}
