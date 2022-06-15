using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool Appendages { get; set; }

        public string Movement { get; set; }

        public bool ShedsSkin { get; set; }

        public bool HasForkedTongue { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");

            Console.WriteLine($"Does it have legs: {Legs}");

            Console.WriteLine($"Mobility: {Movement}");
        }


    }
}
