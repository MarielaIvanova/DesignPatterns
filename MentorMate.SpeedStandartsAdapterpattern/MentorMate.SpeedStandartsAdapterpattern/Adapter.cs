using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace MentorMate.SpeedStandartsAdapterpattern
{
    class Adapter : KmH
    {
        private MpH milesPerHour;
        public Adapter(MpH milesPerHour)
        {
            this.milesPerHour = milesPerHour;
        }

        public override void TurnToKmPerHour()
        {
            var mph = this.milesPerHour.GetMilesPerHour();
            var kmh = mph * 1.609;
            Console.WriteLine(kmh);
        }
    }
}
