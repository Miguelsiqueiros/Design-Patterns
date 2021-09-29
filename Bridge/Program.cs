using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Device tv = new Tv();

            var remote = new Remote(tv);

            Console.WriteLine(tv.Volume);

            remote.volumeUp();

            Console.WriteLine(tv.Volume);
        }
    }
}
