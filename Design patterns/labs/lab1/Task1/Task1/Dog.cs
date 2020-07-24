using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Dog : Pet
    {
        public Dog(string name, int height, int weight, int age, string gender, string breed, string owner)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Age = age;
            this.Gender = gender;
            this.Breed = breed;
            this.Owner = owner;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("This is " + this.Name + ", a dog of " + this.Owner);
            Console.WriteLine("It's a " + this.Gender + " " + this.Breed);
            Console.WriteLine("height: " + this.Height + " cm" + " and weight: " + this.Weight + " kg");
            Console.WriteLine(this.Age + " years old");
        }

        public override void MakeSound()
        {
            Console.WriteLine("*Bark*");
        }

        public override void DoActivity()
        {
            Console.WriteLine("Making owner happy)");
        }
    }
}
