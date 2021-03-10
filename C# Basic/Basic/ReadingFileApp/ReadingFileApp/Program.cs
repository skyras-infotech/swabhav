using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadingFile readingFile = new ReadingFile();
            Console.WriteLine("Contents of File");
            readingFile.ReadFileData();
            Console.WriteLine(readingFile.Contents);
        }
    }
}
