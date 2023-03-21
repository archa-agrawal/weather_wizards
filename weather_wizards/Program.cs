using System;
using static System.Net.Mime.MediaTypeNames;

namespace weather_wizards
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm Razi = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(Razi.Announce());

            Pupil b = new Pupil("Mezil-kree");
            Storm f = b.CastWindStorm();
            Console.WriteLine(f.Announce());

            Mage m = new Mage("Gul'dan");
            Storm r = m.CastRainStorm();
            Console.WriteLine(r.Announce());



        }
    }
}