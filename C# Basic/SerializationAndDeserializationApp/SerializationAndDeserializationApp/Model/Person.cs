using System;

namespace SerializationAndDeserializationApp.Model
{
    [Serializable]
    class Person
    {
        private string username;
        private int age;

        public Person(string username, int age)
        {
            this.username = username;
            this.age = age;
        }

        public int Age
        {
            get { return age; }
        }


        public string Username
        {
            get { return username; }
        }

    }
}
