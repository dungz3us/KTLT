// Nguyễn Quang Dũng - 20206277
using System;
using System.Drawing;
using System.IO;

namespace WEEK_3_20206277_1_1
{
    class Program
    {
		static string path;
		static string result_path;
		static int pixelInterval = 8;
		static double brightnessMultiplier = 1;
		static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Enter the path: ");
			path = Console.ReadLine();
			Console.WriteLine("Enter the result's path: ");
			result_path = Console.ReadLine();
			try
			{
				ConvertToText();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Main();
			}
		}
		static void ConvertToText()
		{

			Bitmap bmp = new Bitmap(path);
			string WrittenLine = "";
			for (int y = 0; y < bmp.Size.Height - (bmp.Size.Height % pixelInterval); y += pixelInterval)
			{
				for (int x = 0; x < bmp.Size.Width; x++)
				{
					if (x % pixelInterval == 0 || x % pixelInterval == 1) 
					{
						WrittenLine += GetSymbolFromBrightness(bmp.GetPixel(x, y).GetBrightness() * brightnessMultiplier);
					}
				}
				Console.WriteLine(WrittenLine);
				using (StreamWriter writer = new StreamWriter(result_path, true)) 
				{
					writer.WriteLine(WrittenLine);
				}
				WrittenLine = "";

			}
			Main();
		}

		static string GetSymbolFromBrightness(double brightness)
		{
			switch ((int)(brightness * 10))
			{
				case 0:
					return "@";
				case 1:
					return "$";
				case 2:
					return "#";
				case 3:
					return "*";
				case 4:
					return "!";
				case 5:
					return "+";
				case 6:
					return ":";
				case 7:
					return "~";
				case 8:
					return "-";
				case 9:
					return ".";
				default:
					return " ";
			}
		}
	}
}
