using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public string breed;
        public string name;
        public Dog(string breed, ushort age) : base(age)
        {
            this.breed = breed;
            this.age = age;
        }
        public Dog(string breed, string name, ushort age) : this(breed, age)
        {
            this.name = name;
        }
        public Dog(string breed, string name, ushort age, string size, string color, double weight, double height) : base(age, size, color, weight, height)
        {
            this.breed = breed;
            this.name = name;
        }
        /// <summary>
        /// Getting information about dog
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="age"></param>
        public void GetDogInfo(string breed, ushort age)
        {
            Console.Clear();
            Console.WriteLine("Information about dog:" + "\n" + "Breed: " + this.breed + "\n" + "Age: " + this.age);
        }
        /// <summary>
        /// Getting information about dog
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public void GetDogInfo(string breed, string name, ushort age)
        {
            Console.Clear();
            Console.WriteLine("Information about dog:" + "\n" + "Breed: " + this.breed + "\n" + "Name: " + this.name + "\n" + "Age: " + this.age);
        }
        /// <summary>
        /// Getting information about dog
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public void GetDogInfo(string breed, string name, ushort age, string size, string color, double weight, double height)
        {
            Console.Clear();
            Console.WriteLine("Information about dog:" + "\n" + "Breed: " + this.breed + "\n" + "Name: " + this.name + "\n" + "Age: " + this.age + "\n" + "Size: " + this.size + "\n" + "Color: " + this.color + "\n" + "Weight: " + this.weight + "\n" + "Height: " + this.height);
        }
    }
}
