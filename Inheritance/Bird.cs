using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public bool CanFly { get; set; }

        public bool IsPredatory { get; set; }

        public bool IsNocturnal { get; set; }

        public bool BuildsNest { get; set; }

        public void Printdetails()
        {
            Console.WriteLine($"{GetType().Name}");

            Console.WriteLine($"Can fly: {CanFly}");

            Console.WriteLine($"Is nocturnal: {IsNocturnal}");
        }
    }
}
