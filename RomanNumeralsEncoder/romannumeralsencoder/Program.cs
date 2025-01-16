// See https://aka.ms/new-console-template for more information
public static class Solution
{
    static void Main(string[] args)
    {

    }

	public static string RomanConvert(int n)
	{		
    if (n < 1) return string.Empty;            
    if (n >= 1000) return "M" + RomanConvert(n - 1000);
    if (n >= 900) return "CM" + RomanConvert(n - 900); 
    if (n >= 500) return "D" + RomanConvert(n - 500);
    if (n >= 400) return "CD" + RomanConvert(n - 400);
    if (n >= 100) return "C" + RomanConvert(n - 100);            
    if (n >= 90) return "XC" + RomanConvert(n - 90);
    if (n >= 50) return "L" + RomanConvert(n - 50);
    if (n >= 40) return "XL" + RomanConvert(n - 40);
    if (n >= 10) return "X" + RomanConvert(n - 10);
    if (n >= 9) return "IX" + RomanConvert(n - 9);
    if (n >= 5) return "V" + RomanConvert(n - 5);
    if (n >= 4) return "IV" + RomanConvert(n - 4);
    if (n >= 1) return "I" + RomanConvert(n - 1);
    else throw new ArgumentOutOfRangeException(nameof(n), "insert value between 1 and 3999");
	}
}