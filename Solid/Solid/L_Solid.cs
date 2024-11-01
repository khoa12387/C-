using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public abstract class Bird
    {
        public abstract void Display();
    }

    public class FlyingBird : Bird
    {
        public override void Display()
        {
            Console.WriteLine("This is a flying bird.");
        }

        public void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }

    public class NonFlyingBird : Bird
    {
        public override void Display()
        {
            Console.WriteLine("This bird cannot fly.");
        }
    }

    public class Penguin : NonFlyingBird
    {
        public override void Display()
        {
            Console.WriteLine("This is a penguin.");
        }
    }

}
