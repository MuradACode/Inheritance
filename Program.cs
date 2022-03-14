using System;
using Inheritance.Models;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the dog's breed if you dont know type '0' : ");
            string breed = Console.ReadLine();
            ushort age;
        AgeTry:
            Console.Write("Write the dog's age is if you dont know type '0' : ");
            try
            {
                age = Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto AgeTry;
            }
            Console.Write("Write the dog's name if you dont know type '0' : ");
            string name = Console.ReadLine();
            Console.Write("Write the dog's size if you dont know type '0' : ");
            string size = Console.ReadLine();
            Console.Write("Write the dog's color if you dont know type '0' : ");
            string color = Console.ReadLine();
            double weight;
        WeightTry:
            Console.Write("Write the dog's weight (in kg)" +
                " if you dont know type '0' : ");
            try
            {
                weight = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto WeightTry;
            }
            double height;
        HeightTry:
            Console.Write("Write the dog's height if you dont know type '0' : ");
            try
            {
                height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto HeightTry;
            }

            if (age != 0)
            {
                if (breed != "0")
                {
                    if (name != "0")
                    {
                        if ((size != "0" && color != "0") && (height != 0 && weight != 0))
                        {
                            Dog dog = new Dog(breed, name, age, size, color, weight, height);
                            dog.GetDogInfo(breed, name, age, size, color, weight, height);
                        }
                        else
                        {
                            Dog dog = new Dog(breed, name, age);
                            dog.GetDogInfo(breed, name, age);
                        }
                    }
                    else
                    {
                        Dog dog = new Dog(breed, age);
                        dog.GetDogInfo(breed, age);
                    }
                }
                else if (size != "0")
                {
                    if (color != "0")
                    {
                        if (weight != 0 && height != 0)
                        {
                            Animal animal = new Animal(age, size, color, weight, height);
                            animal.GetAnimalInfo(age, size, color, weight, height);
                        }
                        else 
                        { 
                            Animal animal = new Animal(age, size, color);
                            animal.GetAnimalInfo(age, size, color);
                        }
                        
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("You don't have enough information");
            }
        }
    }
}
