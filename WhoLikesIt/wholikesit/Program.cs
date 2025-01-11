// See https://aka.ms/new-console-template for more information
public static class Kata
{
    static void Main(string[] args)
    {
        Likes(["Max", "John"]);
    }
    public static string Likes(string[] name)
    {
        string res = "";
        int count = name.Length;
        switch (count)
        {
            case 1:
                res += name[0] + " likes this";
                break;
            case 2:
                for (int i = 0; i < count; i++)
                {
                    res += name[i] + " and ";
                }
                Console.WriteLine(res);
                res = res.Remove(res.Length - 5);
                res += " likes this";
                break;
            case 3:
                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)
                    {
                        res = res.Remove(res.Length - 2);
                        res += " and ";
                    }
                    res += name[i] + ", ";
                }
                res = res.Remove(res.Length - 2);
                res += " likes this";
                break;
            case > 3:
                for (int i = 0; i < 2; i++)
                {
                    res += name[i] + ", ";
                }
                res = res.Remove(res.Length - 2);
                res += " and "+ (name.Length-2).ToString() + " others likes this";
                break;
            default:
                res = "no one likes this";
                break;
        }
        Console.WriteLine(res);
        return res;
    }
}