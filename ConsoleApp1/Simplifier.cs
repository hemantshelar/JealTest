using System;
using System.Collections.Generic;
using System.Text;

namespace JealTest
{
	public class Simplifier
	{
		public string Simplyfy(int n, int d)
		{
			bool flag = true;
			while( flag )
			{
				int nIndex = 2;
				bool divided = false;
				while( nIndex <= n && nIndex <= d && divided == false )
				{
					if ( n % nIndex == 0 && d % nIndex == 0 )
					{
						n = n / nIndex;
						d = d / nIndex;
						divided = true;
					}
					else
					{
						nIndex++;
					}
				}
				if ( divided == true )
				{
					nIndex = 2;
				}
				else
				{
					flag = false;
				}
			}
			var result = d == 1 ? $"{n}" :  $"{n}/{d}";

			return result;
		}
	}
}
