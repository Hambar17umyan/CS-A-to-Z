using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Dog : Animal
    {
        public Dog() { }

        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        static Dog()
        {
            Sound = "Woof!";
        }
        public static readonly string Sound;

    }
}
