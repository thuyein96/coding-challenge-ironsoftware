using System.Text;

namespace OldPhoneKeypad.Services;

public static class OldPhoneService
{
    public static string ConvertInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        var result = new StringBuilder();
        char lastChar = '\0';
        int count = 0;

        foreach (char characters in input)
        {
            switch (characters)
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
                    if (char.IsDigit(characters))
                    {
                        if (characters == lastChar)
                        {
                            count++;
                        }
                        else
                        {
                            if (lastChar != '\0')
                                result.Append(GetLetter(lastChar, count));

                            lastChar = characters;
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
