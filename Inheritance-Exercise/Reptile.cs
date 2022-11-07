using Inheritance_Exercise_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            BreathesAir = true;
            legs = 4;
            HasTail = true;
            CanSwim = false;
        }

        public bool IsColdBlooded { get; set; } = true;
        public string Movement { get; set; }
        public bool HasScales { get; set; } = true;
        public bool HasForkedTongue { get; set; }
        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Is cold blooded: {IsColdBlooded}");
            Console.WriteLine($" {Movement}");
        }


    }
}
