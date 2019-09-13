using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(AlphaPhoneToNumber("555-GET-FOOD"));
	}

	public static string AlphaPhoneToNumber(string val)
	{
		//strings are immutable so let's get the array version of the value
		var phoneNumberArr = val.ToCharArray();
		for (int i = 0; i < val.Length; i++)
		{
			phoneNumberArr[i] = AlphaPhoneCharToNumber(phoneNumberArr[i]);
		}
		return new string(phoneNumberArr);
	}

	public static char AlphaPhoneCharToNumber(char val)
	{
		switch (val)
		{
			case 'A':
			case 'B':
			case 'C':
				return '2';
			case 'D':
			case 'E':
			case 'F':
				return '3';
			case 'G':
			case 'H':
			case 'I':
				return '4';
			case 'J':
			case 'K':
			case 'L':
				return '5';
			case 'M':
			case 'N':
			case 'O':
				return '6';
			case 'P':
			case 'Q':
			case 'R':
				return '7';
			case 'S':
			case 'T':
			case 'U':
				return '8';
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
				return '9';
			default: return val;
				
		}
		 		
		
	}
}