using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceAssingment
{
    class Dog : Animal
    {
        public enum DogBreed
        {
            Lab,
            GoldenRetriever,
            Pug,
            Terrier
        }
        public Dog(DogBreed breed, string name, int age)
        {
            Breed = breed.ToString();
            Name = name;
            Age = age;
            
        }

    }
}
