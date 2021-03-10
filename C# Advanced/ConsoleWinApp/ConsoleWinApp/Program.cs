using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ConsoleWinApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            WelcomeForm welcome = new WelcomeForm();
            Case1(welcome);
            Case2(welcome);
            Case3(welcome);
            Application.Run(welcome);
        }

        public static void Case1(WelcomeForm welcome) 
        {
            welcome.Load += Log;
        }
        public static void Case2(WelcomeForm welcome)
        {
            welcome.Load += delegate (object sender, EventArgs e)
            {
                string path = @"C:\swabhav\C# Win Form\ConsoleWinApp\ConsoleWinApp\h1.txt";
                Console.WriteLine("\nInside anonymous func function");
                Console.WriteLine("Writing to Text file");
                File.WriteAllText(path, "Writing to first file using event");
            };
        }

        public static void Case3(WelcomeForm welcome)
        {
            welcome.Load += (sender, e) => 
            {
                string path = @"C:\swabhav\C# Win Form\ConsoleWinApp\ConsoleWinApp\h1.txt";
                Console.WriteLine("\nInside lamnda func function");
                Console.WriteLine("Writing to Text file");
                File.WriteAllText(path, "Writing to first file using event");
            };
        }

        public static void Log(object sender, EventArgs e) {
            string path = @"C:\swabhav\C# Win Form\ConsoleWinApp\ConsoleWinApp\h1.txt";
            Console.WriteLine("Inside name function");
            Console.WriteLine("Writing to Text file");
            File.WriteAllText(path, "Writing to first file using event");
        }




    }
}
