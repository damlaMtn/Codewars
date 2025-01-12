﻿// See https://aka.ms/new-console-template for more information
public class Solution
{
    static void Main(string[] args)
    {
        CanBeValid("))()))", "010100");
    }

    public static bool CanBeValid(string s, string locked)
    {
        if (s.Length % 2 != 0) return false;

        int minOpen = 0, maxOpen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (locked[i] == '1')
            {
                if (s[i] == '(')
                {
                    minOpen++;
                    maxOpen++;
                }
                else
                {
                    minOpen--;
                    maxOpen--;
                }
            }
            else
            {
                minOpen--;
                maxOpen++;
            }

            minOpen = Math.Max(minOpen, 0);

            if (maxOpen < 0) return false;
        }

        return minOpen == 0;
    }
}