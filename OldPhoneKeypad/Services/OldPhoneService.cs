using System.Text;

namespace OldPhoneKeypad.Services;

/// <summary>
/// Provides functionality to simulate typing on an old mobile phone keypad.
/// </summary>
public static class OldPhoneService
{
    /// <summary>
    /// Converts a numeric input sequence (simulating old phone pad presses)
    /// into the corresponding text message.
    /// </summary>
    /// <param name="input">
    /// The raw input string, containing digits (0–9),
    /// spaces (for pause), '*' for backspace, and '#' for send.
    /// </param>
    /// <returns>
    /// The translated text message. If the input is empty or invalid, returns an empty string.
    /// </returns>
    /// <example>
    /// <code>
    /// OldPhoneService.ConvertInput("4433555 555666#")  // returns "HELLO"
    /// </code>
    /// </example>
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

    /// <summary>
    /// Maps a single numeric key press sequence to its corresponding character.
    /// </summary>
    /// <param name="key">The numeric key pressed (0–9).</param>
    /// <param name="count">The number of times the key was pressed consecutively.</param>
    /// <returns>The corresponding character, cycling if pressed too many times.</returns>
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
