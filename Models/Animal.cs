using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    public class Animal
    {
        public ushort age;
        public string size;
        public string color;
        public double weight;
        public double height;

        public Animal(ushort age)
        {
            this.age = age;
        }
        public Animal(ushort age, string size, string color) : this(age)
        {
            this.size = size;
            this.color = color;
        }
        public Animal(ushort age, string size, string color, double weight, double height) : this(age, size, color)
        {
            this.weight = weight;
            this.height = height;
        }

        /// <summary>
        /// Getting information about animal
        /// </summary>
        /// <param name="age"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        public void GetAnimalInfo(ushort age, string size, string color)
        {
            Console.Clear();
            Console.WriteLine("Information about animal:" + "\n" + "Age: " + this.age + "\n" + "Size: " + this.size + "\n" + "Color: " + this.color);
        }
        /// <summary>
        /// Getting information about animal
        /// </summary>
        /// <param name="age"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public void GetAnimalInfo(ushort age, string size, string color, double weight, double height)
        {
            Console.Clear();
            Console.WriteLine("Information about animal:" + "\n" + "Age: " + this.age + "\n" + "Size: " + this.size + "\n" + "Color: " + this.color + "\n" + "Weight: " + this.weight + "\n" + "Height: " + this.height);
        }
    }
}
