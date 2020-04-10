using System;
using System.Collections.Generic;
using System.Text;

namespace cd_osk
{
    class Help
    {
        public static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("For more information, please visit docs\\index.html in the ZIP.");
            Console.WriteLine("");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("beep");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]   - BEEP Driver for CD-OSK.");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("color");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]  - Changes the Background Color of the CD-OSK Cursor.");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("crash");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]  - Crashes the CPU (causes CPU exception).");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("gencmd");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("] - Generate random string (based on gencode project).");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("halt");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]   - Halts and shuts down system.");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("help");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]   - Displays this help menu.");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("init");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]   - Initializes the Desktop environment (experimental).");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("time");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]   - Displays the time and date.");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ver");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]    - Displays CD-OSK's version.");
            Console.WriteLine("");
        }
    }
}
