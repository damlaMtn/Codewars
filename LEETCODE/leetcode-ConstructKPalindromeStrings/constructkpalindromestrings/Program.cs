// See https://aka.ms/new-console-template for more information

public static class Solution
{
    static void Main(string[] args)
    {
        string s = "annabelle";
        int k = 2;
        CanConstruct(s, k);
    }

    public static bool CanConstruct(string s, int k)
    {
        if (k > s.Length)
            return false;

        int[] freq = new int[26];
        foreach (char ch in s)
        {
            freq[ch - 'a']++;
        }

        int odd = 0;
        foreach (int i in freq)
            if ((i & 1) == 1)
                odd++;
        if (odd > k)
            return false;

        return true;
    }
}