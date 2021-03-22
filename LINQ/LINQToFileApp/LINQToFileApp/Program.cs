using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQToFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Windows\System32";
            DirectoryInfo dir = new System.IO.DirectoryInfo(folderPath);
            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly);
            IEnumerable<string> folderList = Directory.GetDirectories(folderPath);

            Console.WriteLine("Select Top 3 files using asending");
            var top3FileAsc = fileList.OrderBy(x => x.FullName).Take(3);
            foreach (var item in top3FileAsc)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine("\nSelect Top 3 files using size");
            var top3FileSize = fileList.OrderBy(x => x.Length).Take(3);
            foreach (var item in top3FileSize)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine("\nSelect Top 3 folders using asending");
            var top3FolderAsc = folderList.OrderBy(x => x).Take(3);
            foreach (var item in top3FolderAsc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSelect Top 3 folders using size");
            var top3FolderSize = folderList.OrderBy(x => x.Length).Take(3);
            foreach (var item in top3FolderSize)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGet Files Details");
            var fileDetails = fileList.OrderBy(x => x.Name).First();
            Console.WriteLine("File Name            :  " + fileDetails.Name);
            Console.WriteLine("File Full Name       :  " + fileDetails.FullName);
            Console.WriteLine("File Directory Name  :  " + fileDetails.DirectoryName);
            Console.WriteLine("File Size            :  " + fileDetails.Length);


            Console.WriteLine("\nGet All Details");
            var allFileDetails = fileList.OrderBy(x => x.Name);
            foreach (var item in allFileDetails)
            {
                Console.WriteLine("File Name            :  " + item.Name);
                Console.WriteLine("File Full Name       :  " + item.FullName);
                Console.WriteLine("File Directory Name  :  " + item.DirectoryName);
                Console.WriteLine("File Size            :  " + item.Length);
                Console.WriteLine();
            }

        }
    }
}
