using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceAssingment
{
    class Bird : Animal
    {
        public enum BirdBreed
        {
            Eagle,
            Hawk,
            GoldenDove,
            Dodo
        }
        public Bird(BirdBreed breed, string name, int age)
        {
            Breed = breed.ToString();
            Name = name;
            Age = age;
        }

    }
}