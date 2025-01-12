// See https://aka.ms/new-console-template for more information

public static class Kata
{
    static void Main(string[] args)
    {
        Decode(".... . -.--   .--- ..- -.. .");
    }

    public static string Decode(string message)
    {
        Dictionary<char, String> _morseCode = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };

        string[] words = message.Split('/');
        string decodedMessage = "";
        foreach (string word in words)
        {
            int space = 0;
            string[] letters = word.Split(' ');
            foreach (string letter in letters)
            {
                decodedMessage += _morseCode.FirstOrDefault(x => x.Value == letter).Key;

                if (string.IsNullOrWhiteSpace(letter))
                {
                    space++;
                    if (space == 2)
                    {
                        decodedMessage += " ";
                        space = 0;
                    }
                }
            }
            decodedMessage += " ";
        }
        return decodedMessage.Trim();
    }
}
