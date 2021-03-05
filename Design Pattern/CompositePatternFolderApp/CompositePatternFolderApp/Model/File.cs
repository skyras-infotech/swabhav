using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp.Model
{
    class File : IStorable
    {
        private string _name;
        private double _size;
        private string _extension;

        public File(string name, double size, string extension)
        {
            _name = name;
            _size = size;
            _extension = extension;
        }

        public string Extension
        {
            get { return _extension; }
        }

        public double Size
        {
            get { return _size; }
        }

        public string FileName
        {
            get { return _name; }
        }

        public void Display(StringBuilder dashes)
        {
            dashes.Append("\n---> " + _name + "." + _extension + " and Size : " + _size);
        }
    }
}
