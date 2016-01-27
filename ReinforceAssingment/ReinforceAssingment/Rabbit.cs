using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceAssingment
{
    class Rabbit : Animal
    {
        public enum RabbitBreed
        {
            Long,
            Fast,
            Small,
            Large
        }
        public Rabbit(RabbitBreed breed, string name, int age)
        {
            Breed = breed.ToString();          
            Name = name;
            Age = age;
        }

    }
}
