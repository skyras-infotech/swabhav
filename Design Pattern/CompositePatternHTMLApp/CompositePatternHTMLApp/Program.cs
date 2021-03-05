using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CompositePatternHTMLApp.Model;

namespace CompositePatternHTMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup html = new ControlGroup("html");
            ControlGroup body = new ControlGroup("body");
            ControlGroup div = new ControlGroup("div");

            html.AddControl(body);
            body.AddControl(div);
            div.AddControl(new Control("input", "text", "Username"));
            div.AddControl(new Control("br"));
            div.AddControl(new Control("input", "password", "Password"));
            div.AddControl(new Control("br"));
            div.AddControl(new Control("input", "button", "submit"));
            div.AddControl(new Control("br"));

            StringBuilder stringBuilder = html.ParseHTML();
            WriteDataToFile(stringBuilder);
        }

        private static void WriteDataToFile(StringBuilder stringBuilder)
        {
            string path = @"d:/htmlfile.html";
            File.WriteAllText(path, stringBuilder.ToString());
        }
    }
}
