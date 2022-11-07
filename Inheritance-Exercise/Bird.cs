using Inheritance_Exercise_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            BreathesAir = true;
            HasTail = true;
            legs = 2;
            CanSwim = false;
        }
        public bool CanFly { get; set; } = true;
        public bool HasFeathers { get; set; } = true;
        public bool CanSing { get; set; } = true;
        public bool BuildsNest { get; set; } = true;
        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Can fly: {CanFly}");
            Console.WriteLine($"Speacialty: {CanSing}");

        }
    }
}
