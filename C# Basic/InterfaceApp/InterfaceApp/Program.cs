namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape r1 = new Rectangle();
            r1.Draw();
            IShape c1 = new Circle();
            c1.Draw();
        }
    }
}
