using System;

namespace Program
{
    public class DogAbstract : AnimalAbstract
    {
        public override void animalSound()
        {
            Console.WriteLine("anjing bunyinya guk - guk");
        }
    }
}