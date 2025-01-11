// See https://aka.ms/new-console-template for more information
public static class Kata
{
    static void Main(string[] args)
    {
        AlphabetPosition("The sunset sets at twelve o' clock.");
    }

    public static string AlphabetPosition(string text)
    {
        string res = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsLetter(text[i]))
                res += char.ToUpper(text[i]) - 64 + " ";
        }
        if(res.Length > 0) res = res.Remove(res.Length - 2);
        Console.WriteLine(res);
        return res;
    }

}