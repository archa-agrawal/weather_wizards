using System;
namespace weather_wizards
{

    class Storm
    {
        public string Essence { get; private set; }
        public bool IsStrong { get; private set; }
        public string Caster { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        public string Announce()
        {
            string strength = "weak";
            if (IsStrong)
            {
                strength = "strong";
            }
            return ($"{Caster} cast a {strength} {Essence} storm!");
        }

    }
}

