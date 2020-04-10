using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace cd_osk
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CD-OSK kernel booted successfully.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Version 0.0.1");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Copyright (C) 2018-2020 SparrDrem");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This program is distributed AS-IS with ABSOLUTELY no WARRANTY or GUARANTEE.");
            Console.WriteLine("Your continued usage of CD-OSK automatically assumes that you agree to the");
            Console.WriteLine("terms. Please see gplv3.txt bundled with the ZIP archive.");
            Console.ResetColor();
        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("CD-OSK");
            Console.ResetColor();
            Console.Write("> ");
            var input = Console.ReadLine();

            if (input.ToLower() == "ver")
            {
                Version.Main();
                Run();
            }
            if (input.ToLower() == "gencmd")
            {
                Gencode.Gencmd();
                Run();
            }
            if (input.ToLower() == "init")
            {
                DesktopEnvironment.InitGUI();
                Run();
            }
            if (input.ToLower() == "init 640x480")
            {
                DesktopEnvironment.InitGUI_640x480();
            }
            if (input.ToLower() == "init 800x600")
            {
                DesktopEnvironment.InitGUI_800x600();
            }
            if (input.ToLower() == "init 1024x768")
            {
                DesktopEnvironment.InitGUI_1024x768();
            }
            if (input.ToLower() == "init 1280x720")
            {
                DesktopEnvironment.InitGUI_1280x720();
            }
            if (input.ToLower() == "init 1366x768")
            {
                DesktopEnvironment.InitGUI_1366x768();
            }
            if (input.ToLower() == "init 1920x1080")
            {
                DesktopEnvironment.InitGUI_1920x1080();
            }
            if (input.ToLower() == "init asusoem")
            {
                InitGUI_ASUSModeExperimental();
            }
            if (input.ToLower() == "crash")
            {
                UPTIME.Main();
                Run();
            }
            if (input.ToLower() == "beep")
            {
                Beep.Main();
                Run();
            }
            if (input.ToLower() == "color")
            {
                ConsoleBackgroundColor.Color();
                Run();
            }
            if (input.ToLower() == "color black")
            {
                ConsoleBackgroundColor.Color_Black();
                Run();
            }
            if (input.ToLower() == "color blue")
            {
                ConsoleBackgroundColor.Color_Blue();
                Run();
            }
            if (input.ToLower() == "color cyan")
            {
                ConsoleBackgroundColor.Color_Cyan();
                Run();
            }
            if (input.ToLower() == "color darkblue")
            {
                ConsoleBackgroundColor.Color_DarkBlue();
                Run();
            }
            if (input.ToLower() == "color darkcyan")
            {
                ConsoleBackgroundColor.Color_DarkCyan();
                Run();
            }
            if (input.ToLower() == "color darkgray")
            {
                ConsoleBackgroundColor.Color_DarkGray();
                Run();
            }
            if (input.ToLower() == "color darkgreen")
            {
                ConsoleBackgroundColor.Color_DarkGreen();
                Run();
            }
            if (input.ToLower() == "color darkmagenta")
            {
                ConsoleBackgroundColor.Color_DarkMagenta();
                Run();
            }
            if (input.ToLower() == "color darkred")
            {
                ConsoleBackgroundColor.Color_DarkRed();
                Run();
            }
            if (input.ToLower() == "color darkyellow")
            {
                ConsoleBackgroundColor.Color_DarkYellow();
                Run();
            }
            if (input.ToLower() == "color gray")
            {
                ConsoleBackgroundColor.Color_Gray();
                Run();
            }
            if (input.ToLower() == "color green")
            {
                ConsoleBackgroundColor.Color_Green();
                Run();
            }
            if (input.ToLower() == "color magenta")
            {
                ConsoleBackgroundColor.Color_Magenta();
                Run();
            }
            if (input.ToLower() == "color red")
            {
                ConsoleBackgroundColor.Color_Red();
                Run();
            }
            if (input.ToLower() == "color white")
            {
                ConsoleBackgroundColor.Color_White();
                Run();
            }
            if (input.ToLower() == "color yellow")
            {
                ConsoleBackgroundColor.Color_Yellow();
                Run();
            }
            if (input.ToLower() == "color reset")
            {
                ConsoleBackgroundColor.Color_Reset();
                Run();
            }
            if (input.ToLower() == "halt")
            {
                Console.WriteLine("Flushing system cycles.");
                Sys.Power.Shutdown();
            }
            if (input.ToLower() == "time")
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(DateTime.Now.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Run();
            }
            if (input.ToLower() == "help")
            {
                Help.Main();
                Run();
            }
        }
        private void InitGUI_ASUSModeExperimental() // Remove this if you are forking/referencing this project.
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("! Warning !: ");
            Console.ResetColor();
            Console.WriteLine("This graphic mode is meant for ASUS EeePC Model 1001PX only. Using this");
            Console.WriteLine("mode can have unintentional side effects as it is experimental.");
            Console.WriteLine("Proceed?");
            Console.WriteLine("");
            retryPrompt:
            Console.Write("(Y/N)> ");
            var promptAnswer = Console.ReadLine();
            if (promptAnswer.ToLower() == "y")
            {
                DesktopEnvironment.ASUSEeePC1001PX_OEM();
            }
            if (promptAnswer.ToLower() == "n")
            {
                Run();
            }
            goto retryPrompt;
        }
    }
}
