using System.IO;

namespace WritingFileApp
{
    class FileWriting
    {
        public void WriteDataIntoFile() {
            StreamWriter writer = new StreamWriter("D://students.txt");
            string str = "ID : 101\nName : John\nCGPA : 9.89\n\n" +
                "ID : 102\nName : Dae\nCGPA : 7.92";
            writer.WriteLine(str);
            writer.Flush();
            writer.Close();
        }
    }
}
