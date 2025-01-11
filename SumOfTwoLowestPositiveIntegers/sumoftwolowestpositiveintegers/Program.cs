// See https://aka.ms/new-console-template for more information

public static class Kata
{
    static void Main(string[] args)
    {
        sumTwoSmallestNumbers([19, 5, 42, 2, 77]);
    }

    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        Array.Sort(numbers);
        Console.WriteLine(numbers[0] + numbers[1]);
        return numbers[0] + numbers[1];
    }
}