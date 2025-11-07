using OldPhoneKeypad.Services;

namespace OldPhoneKeypad.Tests;

public class OldPhoneServiceTests
{
    [Theory]
    [InlineData("33#", "E")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    public void ConvertInput_ShouldReturnExpectedText(string input, string expected)
    {
        var result = OldPhoneService.ConvertInput(input);
        Assert.Equal(expected, result);
    }
}
