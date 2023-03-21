using System;
namespace weather_wizards
{

    class Pupil
    {
        public string Title { get; protected set; }

        public Pupil(string title)
        {
            Title = title;
        }

        public Storm CastWindStorm()
        {
            Storm a = new Storm("wind", false, Title);
            return a;
        }
    }

}

