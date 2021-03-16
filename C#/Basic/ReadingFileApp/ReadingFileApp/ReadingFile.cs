using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFileApp
{
    class ReadingFile
    {
        private string contents;

        public string Contents
        {
            get { return contents; }
        }

        public void ReadFileData() 
        {
            StreamReader reader = new StreamReader("D://students.txt");
            string str = reader.ReadLine();
            
            while (str != null) {
                var items = str.Split(' ');
                foreach (var item in items)
                {
                    if (item.Equals(null) || item.Equals("")) {
                        contents += "Unspecified ";
                    }
                    else
                    {
                        contents += item + " ";
                    }
                }
                contents += "\n";
                str = reader.ReadLine();
             }
            reader.Close();
       }
    }
}
