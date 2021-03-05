using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternFolderApp.Model;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder dashes = new StringBuilder("");
            Folder movieFolder = new Folder("Movie");
            Folder actionMovieFolder = new Folder("Action");
            Folder comedyMovieFolder = new Folder("Comedy");
            Folder comedyActionMovieFolder = new Folder("Comedy Action");

            File afile = new File("action 1",50,"mp4");
            File bfile = new File("action 2",45,"avi");
            File cfile = new File("comdey 1",30,"mp3");
            File dfile = new File("comdey 2",33,"mp4");
            File efile = new File("comdey action 1",42,"mp3");

            movieFolder.AddChildren(actionMovieFolder);
            movieFolder.AddChildren(comedyMovieFolder);
            actionMovieFolder.AddChildren(comedyActionMovieFolder);

            actionMovieFolder.AddChildren(afile);
            actionMovieFolder.AddChildren(bfile);
            comedyMovieFolder.AddChildren(cfile);
            comedyMovieFolder.AddChildren(dfile);
            comedyActionMovieFolder.AddChildren(efile);

            movieFolder.Display(dashes);
            Console.WriteLine(movieFolder.GetDash);
        }
    }
}
