using System;
using System.Collections.Generic;
using System.Text;

namespace cd_osk
{
    class UPTIME
    {
        public static void Main()
        {
            double upticks = 0;
            int updays = 0;
            int uphours = 0;
            int upmins = 0;
            int upsecs = 0;
            upticks = Environment.TickCount;
            upticks = upticks / 1000;
            updays = Convert.ToInt32(Math.Floor(upticks / (3600 * 24)));
            upticks = upticks - (Math.Floor(upticks / (3600 * 24)) * (3600 * 24));
            uphours = Convert.ToInt32(Math.Floor(upticks / 3600));
            upticks = upticks - (Math.Floor(upticks / 3600) * 3600);
            upmins = Convert.ToInt32(Math.Floor(upticks / 60));
            upticks = upticks - (Math.Floor(upticks / 60) * 60);
            upsecs = Convert.ToInt32(upticks);
            Console.WriteLine("");
            Console.WriteLine("Copyright (C) 2018-2020 SparrDrem");
            Console.WriteLine("Copyright (C) 2015-2020 SparrOSDeveloperTeam");
            Console.WriteLine("Copyright (C) 2009-2020 Innovation Inc.");
            Console.WriteLine("");
            Console.WriteLine("UPTIME Command Line Application (ported to CD-OSK)");
            Console.WriteLine("Version 1.0.285-beta");
            Console.WriteLine("");
            Console.Write("Machine current UPTIME: ");
            Console.WriteLine((updays).ToString() + ":" + (uphours).ToString() + ":" + (upmins).ToString() + ":" + (upsecs).ToString());
            Console.WriteLine("");
        }
    }
}
