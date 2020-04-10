using System;
using System.Collections.Generic;
using System.Text;

namespace cd_osk
{
    class ConsoleBackgroundColor
    {
        public static void Color()
        {
            Console.WriteLine("");
            Console.WriteLine("Usage: color [color] [option]");
            Console.WriteLine("");
            Console.WriteLine("Available Colors:");
            Console.WriteLine("      black    blue    cyan    darkblue    darkcyan    darkgray");
            Console.WriteLine("      darkgreen    darkmagenta    darkred    darkyellow    gray");
            Console.WriteLine("      green    magenta    red    white    yellow");
            Console.WriteLine("");
            Console.WriteLine("Available Options:");
            Console.WriteLine("      reset");
            Console.WriteLine("");
            Console.WriteLine("Example: color darkblue");
            Console.WriteLine("");
        }
        public static void Color_Black()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void Color_Blue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        public static void Color_Cyan()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        public static void Color_DarkBlue()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public static void Color_DarkCyan()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        public static void Color_DarkGray()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        public static void Color_DarkGreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        public static void Color_DarkMagenta()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }
        public static void Color_DarkRed()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        public static void Color_DarkYellow()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        }
        public static void Color_Gray()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        public static void Color_Green()
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        public static void Color_Magenta()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
        public static void Color_Red()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public static void Color_White()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        public static void Color_Yellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        public static void Color_Reset()
        {
            Console.ResetColor();
        }
    }
}
