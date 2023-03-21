using System;
namespace weather_wizards
{
    class Mage : Pupil
    {

        public Mage(string title) : base(title)
        {
            Title = title;
        }

        public virtual Storm CastRainStorm()
        {
            Storm a = new Storm("rain", false, Title);
            return a;
        }
    }

}

