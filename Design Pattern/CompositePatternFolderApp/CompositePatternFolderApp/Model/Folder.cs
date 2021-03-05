using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp.Model
{
    class Folder : IStorable
    {
        private string _name;
        private static string _dash;
        private List<IStorable> _storables = new List<IStorable>();
        private static int count = 0;

        public Folder(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public string GetDash
        {
            get { return _dash; }
        }

        public void AddChildren(IStorable storable) {
            _storables.Add(storable);
        }

        public void Display(StringBuilder dashes)
        {
            if(count == 0)
            {
                dashes.Append("\n-> " + _name);
                count++;
            }
            else { 
                dashes.Append("\n--> " + _name);
            }
            if (_storables != null)
            {
                foreach (var item in _storables)
                {
                    item.Display(dashes);
                }
                _dash = dashes.ToString();
                return;
            }
        }
    }
}
