﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL.Drivers.PCI.Video;

namespace cd_osk
{
    class DesktopEnvironment
    {
        public static void InitGUI()
        {
            Console.WriteLine("");
            Console.WriteLine("Usage: init [resolution]");
            Console.WriteLine("");
            Console.WriteLine("Available Resolutions:");
            Console.WriteLine("       640x480     800x600    1024x768");
            Console.WriteLine("      1280x720    1366x768    1920x1080");
            Console.WriteLine("");
            Console.WriteLine("Example: init 800x600");
            Console.WriteLine("");
        }
        public static void InitGUI_640x480()
        {
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(640, 480);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(640, 480);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 640, 480);
            }
        }
        public static void InitGUI_800x600()
        {
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(800, 600);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(800, 600);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 800, 600);
            }
        }
        public static void InitGUI_1024x768()
        {
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(1024, 768);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(1024, 768);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 1024, 768);
            }
        }
        public static void InitGUI_1280x720()
        {
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(1280, 720);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(1280, 720);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 1280, 720);
            }
        }
        public static void InitGUI_1366x768()
        {
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(1366, 768);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(1366, 768);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 1366, 768);
            }
        }
        public static void InitGUI_1920x1080()
        {
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(1920, 1080);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(1920, 1080);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 1920, 1080);
            }
        }

        public static void ASUSEeePC1001PX_OEM() // It's recommended that this code be deleted in outside projects as it is not wanted.
        {
            Console.WriteLine("Using ASUS EeePC 1001PX Resolution Mode");
            VMWareSVGAII driver = new VMWareSVGAII();
            driver.SetMode(1024, 600);
            driver.Clear(0x37375);
            MouseDriver mouseDriver = new MouseDriver(1024, 600);
            bool OK = true;
            while (OK)
            {
                mouseDriver.Draw(driver);
                driver.Update(0, 0, 1024, 600);
            }
        }
    }
}
