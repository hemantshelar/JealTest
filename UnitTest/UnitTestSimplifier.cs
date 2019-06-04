using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using ConsoleApp1;
using JealTest;

namespace UnitTest
{
	[TestClass]
	public class UnitTestSimplifier
	{
		[TestMethod]
		public void test()
		{
			//Arrange
			int n = 4;
			int d = 6;

			//Act
			Simplifier simplifier = new Simplifier();

			var result1 =  simplifier.Simplyfy(n, d);
			Assert.AreEqual(result1, "2/3");

			n = 10;
			d = 11;
			var result2 = simplifier.Simplyfy(n, d);
			Assert.AreEqual(result2, "10/11");

			n = 100;
			d = 400;
			var result3 = simplifier.Simplyfy(n, d);
			Assert.AreEqual(result3, "1/4");

			n = 8;
			d = 4;
			var result4 = simplifier.Simplyfy(n, d);
			Assert.AreEqual(result4, "2");

			
		}

	}
}
