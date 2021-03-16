using System;
using System.Reflection;

namespace CustomAttributes.Model
{
    class CustomAttribute : Attribute
    {
        private string title;
        private string description;

        public CustomAttribute(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public static void DisplayAttributeInfo(Type classType) {
            Console.WriteLine("Methods of class "+ classType.Name+"\n");
            MethodInfo[] methods = classType.GetMethods();
            foreach (var item in methods)
            {
                object[] attributeArray = item.GetCustomAttributes(true);
                foreach (Attribute item1 in attributeArray)
                {
                    if(item1 is CustomAttribute)
                    {
                        CustomAttribute customAttribute = (CustomAttribute)item1;
                        Console.WriteLine("Method name : "+item.Name+"\nType of Method : "+ 
                            customAttribute.title+"\nDescription : "+ customAttribute.description+"\n");
                    }
                }
            }
        }
    }
}
