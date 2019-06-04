using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using ConsoleApp1;

namespace UnitTest
{
	[TestClass]
	public class UnitTestStringCap
	{
		[TestMethod]
		public void when_StringCap_receives_array_of_string_it_should_capitalize_first_letter()
		{
			//Arrange
			List<string> list = new List<string>();
			list.Add("mavis");
			list.Add("senaida");
			list.Add("letty");
			list.Add("HEMANT");
			list.Add("a");

			var input = list.ToArray();

			//Act
			StringCap stringCap = new StringCap();
			var output = stringCap.CamMe(input);

			//Assert
			List<string> expectedOutput = new List<string>();
			expectedOutput.Add("Mavis");
			expectedOutput.Add("Senaida");
			expectedOutput.Add("Letty");
			expectedOutput.Add("Hemant");
			expectedOutput.Add("A");

			int nIndex = 0;

			foreach (var item in expectedOutput)
			{
				Assert.AreEqual(item, output[nIndex]);
				nIndex++;
			}
		}

		[TestMethod]
		public void when_StringCap_receives_array_having_null_string_it_should_return_null_and_should_capitalize_first_letter_if_string_is_not_null()
		{
			//Arrange
			List<string> list = new List<string>();
			list.Add(null);
			list.Add("senaida");
			list.Add("letty");

			var input = list.ToArray();

			//Act
			StringCap stringCap = new StringCap();
			var output = stringCap.CamMe(input);

			//Assert
			List<string> expectedOutput = new List<string>();
			expectedOutput.Add("");
			expectedOutput.Add("Senaida");
			expectedOutput.Add("Letty");

			int nIndex = 0;

			foreach (var item in expectedOutput)
			{
				Assert.AreEqual(item, output[nIndex]);
				nIndex++;
			}
		}
	}
}
