using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePad("33#"));            
        Console.WriteLine(OldPhonePad("227*#"));          
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));
    }

    public static string OldPhonePad(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return "";

        StringBuilder result = new StringBuilder();
        char lastChar = '\0';
        int count = 0;

        foreach (char c in input)
        {
            switch (c)
            {
                case '#': 
                    if (lastChar != '\0')
                        result.Append(GetLetter(lastChar, count));
                    return result.ToString();

                case '*': 
                    if (lastChar != '\0')
                    {
                        lastChar = '\0';
                        count = 0;
                    }
                    else if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                    }
                    break;

                case ' ':
                    if (lastChar != '\0')
                        result.Append(GetLetter(lastChar, count));
                    lastChar = '\0';
                    count = 0;
                    break;

                default:
                    if (char.IsDigit(c))
                    {
                        if (c == lastChar)
                        {
                            count++;
                        }
                        else
                        {
                            if (lastChar != '\0')
                                result.Append(GetLetter(lastChar, count));
                            lastChar = c;
                            count = 1;
                        }
                    }
                    break;
            }
        }

        return result.ToString();
    }

    private static char GetLetter(char key, int count)
    {
        string letters = key switch
        {
            '1' => "&'(",
            '2' => "ABC",
            '3' => "DEF",
            '4' => "GHI",
            '5' => "JKL",
            '6' => "MNO",
            '7' => "PQRS",
            '8' => "TUV",
            '9' => "WXYZ",
            '0' => " ",
            _ => ""
        };

        if (letters.Length == 0)
            return '\0';

        return letters[(count - 1) % letters.Length];
    }
}


