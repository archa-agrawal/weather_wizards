using System;
namespace weather_wizards
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {
            Title = title;
        }

        public override Storm CastRainStorm()
        {
            Storm a = new Storm("rain", true, Title);
            return a;
        }
        public Storm CastLightningStorm()
        {
            Storm a = new Storm("lightning", true, Title);
            return a;
        }

    }
}

