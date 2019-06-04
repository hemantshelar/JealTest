using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class StringCap
	{
		public string [] CamMe(string [] input )
		{
			string[] output = new string[input.Length];

			int nIndex = 0;

			foreach (var item in input)
			{
				var s1 = "";
				var s2 = "";
				s1 = item == null ? null : item.Substring(0, 1);
				s2 = ( item == null || item.Length == 1 ) ? null : item.Substring(1, item.Length-1);
				s1 = s1?.ToUpper();
				s2 = s2?.ToLower();

				output[nIndex] =$"{s1}{s2}";
				nIndex++;
			}


			return output;
		}
	}
}
