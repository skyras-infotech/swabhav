using System;
using SerializationAndDeserializationApp.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serialization
            string path = @"D:\objectSerialized.txt";
            Person person = new Person("John Dae",20);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, person);
            stream.Close();
            Console.WriteLine("\nObjects sucessfully serialized");

            //Deseriallization
            FileStream fileStream = new FileStream(path,FileMode.Open,FileAccess.Read);
            Person p1 = (Person)formatter.Deserialize(fileStream);
            fileStream.Close();
            Console.WriteLine("\nObjects sucessfully deserialized");
            Console.WriteLine("Person name is "+p1.Username);
            Console.WriteLine("Person age is "+p1.Age+"\n");

        }
    }
}
