using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceAssingment
{ 
 class Cat : Animal
{
        public enum CatBreed
        {
            Fat,
            Cool,
            Grumpy,
            Red
        }
        public Cat(CatBreed breed, string name, int age)
    {
        Breed = breed.ToString();
        Name = name;
        Age = age;
    }

}
}