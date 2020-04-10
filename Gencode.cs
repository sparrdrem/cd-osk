using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace cd_osk
{
    class Gencode
    {
		public static void Gencmd()
        {
			List<int> Letters = new List<int>();
			Random Rnd = new Random();
			StringBuilder SBa = new StringBuilder();
			StringBuilder SBb = new StringBuilder();
			StringBuilder SBc = new StringBuilder();
			StringBuilder SBd = new StringBuilder();
			StringBuilder SBe = new StringBuilder();
			StringBuilder SBf = new StringBuilder();
			StringBuilder SBg = new StringBuilder();
			StringBuilder SBh = new StringBuilder();
			StringBuilder SBi = new StringBuilder();
			StringBuilder SBj = new StringBuilder();
			StringBuilder SBk = new StringBuilder();
			StringBuilder SBl = new StringBuilder();
			StringBuilder SBm = new StringBuilder();
			StringBuilder SBn = new StringBuilder();
			StringBuilder SBo = new StringBuilder();
			StringBuilder SBp = new StringBuilder();
			int Temp = 0;
			for (int i = 48; i <= 57; i++)
			{
				Letters.Add(i);
			}
			for (int i = 97; i <= 122; i++)
			{
				Letters.Add(i);
			}
			for (int i = 65; i <= 90; i++)
			{
				Letters.Add(i);
			}
			for (int counta = 1; counta <= 1; counta++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBa.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countb = 1; countb <= 1; countb++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBb.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countc = 1; countc <= 1; countc++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBc.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countd = 1; countd <= 1; countd++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBd.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int counte = 1; counte <= 1; counte++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBe.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countf = 1; countf <= 1; countf++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBf.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countg = 1; countg <= 1; countg++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBg.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int counth = 1; counth <= 1; counth++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBh.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int counti = 1; counti <= 1; counti++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBi.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countj = 1; countj <= 1; countj++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBj.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countk = 1; countk <= 1; countk++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBk.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countl = 1; countl <= 1; countl++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBl.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countm = 1; countm <= 1; countm++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBm.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countn = 1; countn <= 1; countn++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBn.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int counto = 1; counto <= 1; counto++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBo.Append(Strings.ChrW(Letters[Temp]));
			}
			for (int countp = 1; countp <= 1; countp++)
			{
				Temp = Rnd.Next(0, Letters.Count);
				SBp.Append(Strings.ChrW(Letters[Temp]));
			}
			Console.WriteLine("");
            Console.WriteLine("Copyright (C) 2018-2020 SparrDrem");
            Console.WriteLine("Copyright (C) 2015-2020 SparrOSDeveloperTeam");
            Console.WriteLine("Copyright (C) 2009-2020 Innovation Inc.");
            Console.WriteLine("");
            Console.WriteLine("Gencode Command Line Utility (ported to CD-OSK)");
            Console.WriteLine("Version 0.1b-Preview");
			Console.WriteLine("");
			Console.Write("Your String is: ");
			Console.Write(SBa.ToString());
			Console.Write(SBb.ToString());
			Console.Write(SBc.ToString());
			Console.Write(SBd.ToString());
			Console.Write(SBe.ToString());
			Console.Write(SBf.ToString());
			Console.Write(SBg.ToString());
			Console.Write(SBh.ToString());
			Console.Write(SBi.ToString());
			Console.Write(SBj.ToString());
			Console.Write(SBk.ToString());
			Console.Write(SBl.ToString());
			Console.Write(SBm.ToString());
			Console.Write(SBn.ToString());
			Console.Write(SBo.ToString());
			Console.WriteLine(SBp.ToString());
			Console.WriteLine("");
		}
    }
}
