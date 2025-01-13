// See https://aka.ms/new-console-template for more information

public static class Solution
{
    static void Main(string[] args)
    {
        MinimumLength("abaacbcbb");
    }

    public static int MinimumLength(string s)
    {
        int[] cnt = new int[26];
        for (int i = 0; i < s.Length; ++i)
        {
            ++cnt[s[i] - 'a'];
        }
        int ans = 0;
        foreach (int x in cnt)
        {
            if (x > 0)
            {
                ans += x % 2 == 1 ? 1 : 2;
            }
        }
        Console.WriteLine(ans);
        return ans;
    }
}









