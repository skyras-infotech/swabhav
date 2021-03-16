using CustomAttributes.Model;

namespace CustomAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomAttribute.DisplayAttributeInfo(typeof(Employee));
        }
    }
}
