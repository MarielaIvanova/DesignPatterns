using System;

namespace MentorMate.SpeedStandartsAdapterpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mph = new MpH();
            var kmh = new Adapter(mph);
            kmh.TurnToKmPerHour();
        }
    }
}
