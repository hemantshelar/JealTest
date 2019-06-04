using JealTest;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Simplifier simplifier = new Simplifier();
			StringCap stringCap = new StringCap();
			bool flag = true;
			while(flag)
			{
				Console.WriteLine("*** MENU ****");
				Console.WriteLine("1) Simplifier test");
				Console.WriteLine("2) StringCap  test");
				Console.WriteLine("3) Quite");
				Console.Write("Enter your choice : ");
				var key = Console.ReadLine();
				switch (key)
				{
					case "1":
						Console.Write("Enter numerator : ");
						var n = Console.ReadLine();
						Console.Write("Enter denominator : ");
						var d = Console.ReadLine();

						var result = simplifier.Simplyfy(Int32.Parse(n), Int32.Parse(d));
						Console.WriteLine($"Simplified answe is : {result}");

						break;
					case "2":
						Console.WriteLine("Enter words. ( to enter last word hit enter) ");
						List<string> tokens = new List<string>();
						string input = null;
						while( input != "" )
						{
							Console.Write("Enter word : ");
							input = Console.ReadLine();
							if (input != "" )
							{
								tokens.Add(input);
							}
						}

						var tokenArray = tokens.ToArray();
						var resultArray = stringCap.CamMe(tokenArray);

						Console.WriteLine("After CapMe *****" );
						foreach (var item in resultArray)
						{
							Console.WriteLine(item);
						}

						break;
					case "3":
					case "q":
					case "Q":
						flag = false;
						break;
					default:
						Console.WriteLine(key);
						break;
				}
			}
		}
	}
}
