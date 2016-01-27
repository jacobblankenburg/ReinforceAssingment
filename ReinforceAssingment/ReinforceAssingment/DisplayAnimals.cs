using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceAssingment
{
    class DisplayAnimals
    {
        Dog dog = new Dog(Dog.DogBreed.GoldenRetriever, "Fluffy", 4);

        Cat cat = new Cat(Cat.CatBreed.Red, "Garfield", 76);

        Rabbit rabbit = new Rabbit(Rabbit.RabbitBreed.Large, "Peter", 12);

        Bird bird = new Bird(Bird.BirdBreed.Dodo, "Henery", 21);

        public void Display()
        {
            Console.WriteLine("Breed: " + dog.Breed + " Name: " + dog.Name + " Age: " + dog.Age);
            Console.WriteLine("Breed: " + cat.Breed + " Name: " + cat.Name + " Age: " + cat.Age);
            Console.WriteLine("Breed: " + rabbit.Breed + " Name: " + rabbit.Name + " Age: " + rabbit.Age);
            Console.WriteLine("Breed: " + bird.Breed + " Name: " + bird.Name + " Age: " + bird.Age);
        }
    }
}
