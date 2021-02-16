using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Model
{
    public class Person
    {
        private string name;
        private string gender;
        private int age;
        private float height,weight;

        public Person(string name, string gender, int age, float height, float weight)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public Person(string name, int age)
        {
            this.name = name;
            gender = "Male";
            this.age = age;
            height = 1.8f;
            weight = 60f;
        }

        public float Workout()
        {
            float a1 = (weight * 2) / 100;
            weight += a1;
            return weight;
        }
        public float Eat()
        {
            float a1 = (weight * 5) / 100;
            weight += a1;
            return weight;
        }
        public double CalculateBMIIndex()
        {
            return weight / (height * height);
        }

        public string Name {
            get { return name; }
        }
        public string Gender {
            get { return gender; }
        }
        public int Age {
            get { return age; }
        }
        public float Height
        {
            get { return height; }
        }
        public float Weight
        {
            get { return weight; }
        }

       
        
    }
}
