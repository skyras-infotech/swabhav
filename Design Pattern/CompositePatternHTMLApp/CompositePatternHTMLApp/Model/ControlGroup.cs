using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternHTMLApp.Model
{
    class ControlGroup : IHtml
    {
        private string _tag;
        public List<IHtml> controls = new List<IHtml>();
        public StringBuilder controlGroups = new StringBuilder();

        public ControlGroup(string tag)
        {
            _tag = tag;
        }

        public void AddControl(IHtml html) {
            controls.Add(html);
        }

        public StringBuilder ParseHTML()
        {
            controlGroups.Append("<" + _tag + ">\n");
            if (controls != null) {
                foreach (var element in controls)
                {
                    controlGroups.Append(element.ParseHTML());
                }
            }
            controlGroups.Append("</" + _tag + ">\n");
            return controlGroups;
        }

        public override string ToString()
        {
            return controlGroups.ToString();
        }
    }
}
